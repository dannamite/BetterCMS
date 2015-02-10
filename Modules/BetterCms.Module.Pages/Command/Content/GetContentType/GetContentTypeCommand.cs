﻿using System;
using System.Linq;

using Devbridge.Platform.Core.DataAccess.DataContext;

using BetterCms.Module.Pages.Models;
using BetterCms.Module.Root.Mvc;

using Devbridge.Platform.Core.Web.Mvc.Commands;

namespace BetterCms.Module.Pages.Command.Content.GetContentType
{
    public class GetContentTypeCommand : CommandBase, ICommand<Guid, GetContentTypeCommandResponse>
    {
        public GetContentTypeCommandResponse Execute(Guid request)
        {
            var result =  Repository
                .AsQueryable<Root.Models.Content>(w => w.Id == request)
                .Select(w => new
                             {
                                 Id = w.Id,
                                 Type = w.GetType()
                             })
                 .FirstOne();

            var response = new GetContentTypeCommandResponse { Id = result.Id };
            if (typeof(ServerControlWidget).IsAssignableFrom(result.Type))
            {
                response.Type = WidgetType.ServerControl.ToString();
            }
            else if (typeof(HtmlContentWidget).IsAssignableFrom(result.Type))
            {
                response.Type = WidgetType.HtmlContent.ToString();
            }

            return response;
        }
    }
}