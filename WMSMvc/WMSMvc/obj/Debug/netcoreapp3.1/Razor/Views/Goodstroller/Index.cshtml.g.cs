#pragma checksum "F:\项目\常少楠11\WMSMvc\WMSMvc\Views\Goodstroller\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f13d3492da74c6a895d011b0b511f44c7a5e1db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Goodstroller_Index), @"mvc.1.0.view", @"/Views/Goodstroller/Index.cshtml")]
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
#nullable restore
#line 1 "F:\项目\常少楠11\WMSMvc\WMSMvc\Views\_ViewImports.cshtml"
using WMSMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\项目\常少楠11\WMSMvc\WMSMvc\Views\_ViewImports.cshtml"
using WMSMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f13d3492da74c6a895d011b0b511f44c7a5e1db", @"/Views/Goodstroller/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0683fd9041664bf11709a99e9a9062b0e2bf0ac1", @"/Views/_ViewImports.cshtml")]
    public class Views_Goodstroller_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2000", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\项目\常少楠11\WMSMvc\WMSMvc\Views\Goodstroller\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f13d3492da74c6a895d011b0b511f44c7a5e1db4878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<h1>商品设置</h1>
<table class=""table table-bordered"">
    <tr>
        <td>
            商品编号
        </td>
        <td>
            商品名称
        </td>
        <td>
            商品数量
        </td>
        <td>
            库存设置
        </td>

    </tr>
    <tbody id=""tb"">
    </tbody>
</table>
    

<div style=""margin-left: 545px; "">
    <input id=""Hidden1"" value=""1"" type=""hidden"" /><input id=""Hidden2""");
            BeginWriteAttribute("value", " value=\"", 518, "\"", 526, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"hidden\" />\r\n    <input");
            BeginWriteAttribute("class", " class=\"", 556, "\"", 564, 0);
            EndWriteAttribute();
            WriteLiteral(" id=\"bu1\" type=\"button\" value=\"上一页\" onclick=\"fist()\" />\r\n    <input style=\"margin-left:281px\" id=\"bu1\"");
            BeginWriteAttribute("class", " class=\"", 667, "\"", 675, 0);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" value=\"下一页\" onclick=\"next()\" />\r\n    <select style=\"margin-left: 339px; \" id=\"yema\" onclick=\"Show()\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f13d3492da74c6a895d011b0b511f44c7a5e1db7063", async() => {
                WriteLiteral("3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f13d3492da74c6a895d011b0b511f44c7a5e1db8225", async() => {
                WriteLiteral("10");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f13d3492da74c6a895d011b0b511f44c7a5e1db9388", async() => {
                WriteLiteral("100");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f13d3492da74c6a895d011b0b511f44c7a5e1db10552", async() => {
                WriteLiteral("2000");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </select>
    <script>
        function next() {
            var i = $(""#Hidden1"").val();//页码
            var j = $(""#yema"").val();//页数
            var count = $(""#Hidden2"").val();//总数据
            var lin = Number(Math.ceil(count / j));

            if (i < lin) {
                $(""#Hidden1"").val(Number(Number($(""#Hidden1"").val()) + 1));
            }

            Show();

        }
        function fist() {
            if ($(""#Hidden1"").val() == ""1"") {
                $(""#Hidden1"").val(1);
            }
            else {
                $(""#Hidden1"").val(Number(Number($(""#Hidden1"").val()) - 1));
            }
            Show();

        }
    </script>
</div>

<!-- 模态框（Modal） -->
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""m");
            WriteLiteral(@"odal"" aria-hidden=""true"">
                    &times;
                </button>
                <h4 class=""modal-title"" id=""myModalLabel"">
                    设置商品
                </h4>
            </div>
            <div class=""modal-body"">
                <table>
                    <tr>
                        <td>商品上限</td>
                        <td><input type=""text"" id=""T1"" /></td>
                    </tr>
                    <tr>
                        <td>商品下限</td>
                        <td><input type=""text""id=""T2"" /></td>
                    </tr>
                    <tr>
                        <td>商品库存警告</td>
                        <td><input type=""text""id=""T3"" /></td>
                    </tr>
                    <tr>
                        <td>货架区</td>
                        <td><input type=""text""id=""T4"" /></td>
                    </tr>
                </table>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" cla");
            WriteLiteral(@"ss=""btn btn-default"" data-dismiss=""modal"">
                    关闭
                </button>
                <button type=""button"" class=""btn btn-primary"" onclick=""Gengai()"">
                    提交更改
                </button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal -->
</div>

<script>



    $(function () {

        Show();

    })

    function Gengai() {
        var t1 = $(""T1"").val();
        var t2 = $(""T2"").val();
        var t3 = $(""T3"").val();
        var t4 = $(""T4"").val();
        if (t1 == """" || t2 == """" || t3 == """" || t4 == """") {
            alert('不能为空！')
            return;
        }    
        else {
            alert('保存成功！')
        }

    }
    function Show() {
        $.ajax({
            url: 'http://localhost:3687/api/goods1',
            type: ""get"",
            dataType: ""json"",
            data: {
                page: $(""#Hidden1"").val(),
                size: $(""#yema"").val(),
            },
       ");
            WriteLiteral(@"     success: function (d) {
                $(""#Hidden2"").val(d.count);
                $(""#tb"").empty();
                $(d.golist).each(function () {

                    var ttt = '<tr>' +
                        + '<td>' + this.conding + '</td>'
                        + '<td>' + this.inventorySettings + '</td>'
                        + '<td>' + this.gname + '</td>'
                        + '<td>' + this.level + '</td>'
                        + '<td><input id=""Button1""  class=""btn btn-primary btn-lg"" type=""button"" value=""删除"" onclick=""shan(' + this.goodsId + ')"" /><button class=""btn btn-primary btn-lg"" data-toggle=""modal"" data-target=""#myModal"">设置商品</button> </td> '
                        + '</tr>'
                    $(""#tb"").append(ttt);

                })

            }

        })
    }


    function shan(id) {
        if (confirm(""你确定删除吗？"")) {
            $.ajax({
                url: 'http://localhost:3687/api/Del?ids=' + id,
                dataType: ""json"",
      ");
            WriteLiteral(@"          type: ""get"",
                success: function (d) {
                    if (d > 0) {
                        alert(""删除成功"");
                    }
                    else {
                        alert(""删除失败"");
                    }
                }
            })
        }

    }

</script>


");
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