using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace DotaSite.Helpers
{
    public static class HtmlHelpers
    {

        public static MvcHtmlString MenuLink(this HtmlHelper htmlHelper,
                                            string linkText,
                                            string actionName,
                                            string controllerName,
                                            string targetId
                                            )
        {

            string currentAction = htmlHelper.ViewContext.RouteData.GetRequiredString("action");
            string currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            if (actionName == currentAction && controllerName == currentController)
            {
                return htmlHelper.ActionLink(linkText, actionName, controllerName, null, new { @class = "selected" });
            }

            return htmlHelper.ActionLink(linkText, actionName + "/" + targetId, controllerName);


        }

        public static MvcHtmlString TopNavLink(this HtmlHelper htmlHelper,
                                    string linkText,
                                    string actionName,
                                    string controllerName
                                    )
        {
            string currentController = htmlHelper.ViewContext.RouteData.GetRequiredString("controller");

            if (controllerName == currentController)
            {
                return htmlHelper.ActionLink(linkText, actionName, controllerName, null, new { @class = "selected" });
            }

            return htmlHelper.ActionLink(linkText, actionName, controllerName);


        }
    }
}