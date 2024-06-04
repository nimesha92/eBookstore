using System;
using System.Globalization;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookStore.Helpers
{
    public static class HtmlExtensions
    {
        public static IHtmlContent DisplayPrice(this IHtmlHelper helper, decimal? price)
        {
            if (price.HasValue)
            {
                return new HtmlString(price.Value.ToString("C", CultureInfo.CurrentCulture));
            }
            else
            {
                return new HtmlString(string.Empty);
            }
        }
    }
}
