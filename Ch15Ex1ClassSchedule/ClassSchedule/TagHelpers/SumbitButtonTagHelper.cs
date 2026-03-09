using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ClassSchedule.TagHelpers
{
    [HtmlTargetElement(Attributes = "[tye=sumbit]")]
    public class SumbitButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.AppendCssClass("btn btn-dark");
        }
    }
}
