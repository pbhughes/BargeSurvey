using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc.Html
{
    public static class JqueryMobileExtension
    {
        public static MvcHtmlString FlipSwitchFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            ModelMetadata metadata = ModelMetadata.FromLambdaExpression(expression, htmlHelper.ViewData);
            bool value = (bool)(metadata.Model ?? false);

            List<SelectListItem> items =
                new List<SelectListItem>()
                    {

                        new SelectListItem() { Text = "No", Value = "False", Selected = (!value) },
                        new SelectListItem() { Text = "Yes", Value = "True", Selected = (value) }
                    };

            return htmlHelper.DropDownListFor(expression, items, new { @data_role = "slider" });
        }
    }
}