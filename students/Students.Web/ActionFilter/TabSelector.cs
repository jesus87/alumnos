using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Web.ActionFilter
{

    public enum Tabs
    {
        Students = 0,
        Orders = 1,
    }

    public class TabSelector : ActionFilterAttribute
    {
        private readonly Tabs _selectedTab;

        public TabSelector(Tabs selectedTab)
        {
            _selectedTab = selectedTab;
        }


        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {

            await base.OnActionExecutionAsync(context, next);

            var controller = context.Controller as Controller;
            if (controller == null) return;
            controller.ViewBag.SelectedTab = _selectedTab;

        }
    }
}
