using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Infrastructure
{
    public class ReverseExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var ReversedArrayOfChars = context.ControllerName.ToLower().ToCharArray().Reverse().ToArray();
            ReversedArrayOfChars[0] = char.ToUpper(ReversedArrayOfChars[0]);

            return new List<string> {
                $"/Views/{new string(ReversedArrayOfChars)}/{context.ViewName}.cshtml",
                $"/Views/Shared/{context.ViewName}.cshtml"
            };
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }
    }
}
