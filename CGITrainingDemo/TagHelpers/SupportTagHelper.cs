using CGITrainingDemo.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CGITrainingDemo.TagHelpers
{
    public class SupportTagHelper:TagHelper
    {
        public SupportInfo Info { get; set; }
        public override void Process(TagHelperContext apple, TagHelperOutput mango)
        {
            
            mango.TagName = "div";
           
            mango.Content.SetHtmlContent($@"<p>{Info.Address}</p><p>Tel No:{Info.PhoneNumber}</p><p>Email:{Info.Email}</p>");
        }
    }
}
