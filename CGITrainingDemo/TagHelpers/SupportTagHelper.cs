using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGITrainingDemo.TagHelpers
{
    public class SupportTagHelper:TagHelper
    {
        public override void Process(TagHelperContext apple, TagHelperOutput mango)
        {
            mango.TagName = "div";
            mango.Content.SetHtmlContent(@"<p>Contact Adress: 5th Avenue, Newyork, USA</p><p> Tel No: 9191919182882</p><p>Email:support @org.com</p>");
        }
    }
}
