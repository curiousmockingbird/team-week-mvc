#pragma checksum "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e211e1c2540f0a957fa47293c800b003ded6a99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e211e1c2540f0a957fa47293c800b003ded6a99", @"/Views/Items/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ea02e49d09b87f45804e478cbd7b45230b36a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
  
	Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("//desert\r\n");
#nullable restore
#line 5 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
  using (Html.BeginForm("Category"))   
 {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
 Write(Html.Hidden("desert", "cat"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
                                   ;

#line default
#line hidden
#nullable disable
            WriteLiteral("      <button type=\"submit\" name=\"button\" value=\"ActionOne\" class=\"button\" style=\"border-style: none;\"><img src=\"css/assets/img/desert-category.png\" width=\"150px\"/></button>\r\n");
#nullable restore
#line 9 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"

 }

#line default
#line hidden
#nullable disable
            WriteLiteral(" //forest\r\n");
#nullable restore
#line 12 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
 using (Html.BeginForm("Category"))   
 {
       

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
  Write(Html.Hidden("forest", "cat"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
                                    ;

#line default
#line hidden
#nullable disable
            WriteLiteral("      <button type=\"submit\" name=\"button\" value=\"ActionOne\" class=\"button\" style=\"border-style: none;\">\r\n         <img src=\"css/assets/img/forest-category.png\" width=\"150px\"/></button>\r\n");
#nullable restore
#line 17 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral(" //coast\r\n");
#nullable restore
#line 19 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
  using (Html.BeginForm("Category"))   
 {
       

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
  Write(Html.Hidden("coast", "cat"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
                                   ;

#line default
#line hidden
#nullable disable
            WriteLiteral("      <button type=\"submit\" name=\"button\" value=\"ActionOne\" class=\"button\" style=\"border-style: none;\">\r\n         <img src=\"css/assets/img/coast-category.png\" width=\"150px\"/></button>\r\n");
#nullable restore
#line 24 "C:\Users\HLehr\desktop\ForageMvc\Views\Items\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
