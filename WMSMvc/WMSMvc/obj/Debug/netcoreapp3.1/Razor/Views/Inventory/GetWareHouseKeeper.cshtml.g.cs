#pragma checksum "E:\大二项目\WMSMVC\WMSMvc\WMSMvc\Views\Inventory\GetWareHouseKeeper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81c263753e74432895533eb934f6fd1d9a13f16d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_GetWareHouseKeeper), @"mvc.1.0.view", @"/Views/Inventory/GetWareHouseKeeper.cshtml")]
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
#line 1 "E:\大二项目\WMSMVC\WMSMvc\WMSMvc\Views\_ViewImports.cshtml"
using WMSMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\大二项目\WMSMVC\WMSMvc\WMSMvc\Views\_ViewImports.cshtml"
using WMSMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81c263753e74432895533eb934f6fd1d9a13f16d", @"/Views/Inventory/GetWareHouseKeeper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0683fd9041664bf11709a99e9a9062b0e2bf0ac1", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_GetWareHouseKeeper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ElementUI/element-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vue.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ElementUI/element-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/axios.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\大二项目\WMSMVC\WMSMvc\WMSMvc\Views\Inventory\GetWareHouseKeeper.cshtml"
  
    ViewData["Title"] = "GetWareHouseKeeper";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>库管理员管理</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81c263753e74432895533eb934f6fd1d9a13f16d5160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div id=""div1"">
    <el-form :model=""ruleForm"" status-icon :rules=""rules"" ref=""ruleForm"" label-width=""100px"" class=""demo-ruleForm"">
        <span>库管理员:</span>
        <el-input placeholder=""请输入内容"" style=""width:200px""
                  v-model=""input1""
                  clearable>
        </el-input>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <span>手机号:</span>
        <el-input placeholder=""请输入内容"" style=""width:200px""
                  v-model=""input2""
                  clearable>
        </el-input>
        <el-button type=""primary"" v-on:click=""Show()"">查询</el-button>
        <el-button v-on:click=""addRow()"" type=""primary"" class=""el-icon-circle-plus-outline"">新增库管理员</el-button>
        <!-- 新增库区窗口 -->
        <el-dialog title=""新增库管理员"" :visible.sync=""addFormVisible"">
            <el-form>
                <el-form-item label=""姓名"" :label-width=""formLabelWidth"">
                    <el-input v-model=""KeeperName"" autocomplete=""off""></el-input>
                </el-form-item>

                <el");
            WriteLiteral(@"-form-item label=""手机号"" :label-width=""formLabelWidth"">
                    <el-input v-model=""KeeperPhone"" autocomplete=""off""></el-input>
                </el-form-item>
            </el-form>
            <div>
                <el-button v-on:click=""cancel()"">取消</el-button>
                <el-button type=""primary"" v-on:click=""sumbitAddRow()"">确定</el-button>
            </div>
        </el-dialog>
    </el-form>
    <el-table :data=""tableData""
              style=""width: 100%""
              height=""250"">
        <el-table-column fixed
                         prop=""wareHouserKeeperId""
                         label=""序号""
                         width=""150"">
        </el-table-column>
        <el-table-column prop=""keeperName""
                         label=""姓名""
                         width=""150"">
        </el-table-column>
        <el-table-column prop=""keeperPhone""
                         label=""手机号""
                         width=""150"">
        </el-table-column>
        <el-table");
            WriteLiteral(@"-column prop=""createTime""
                         label=""创建时间""
                         width=""150"">
        </el-table-column>
        <el-table-column label=""状态""
                         width=""150"">
            <template slot-scope=""scope"">
                <p v-if=""scope.row.state==0"">禁用</p>
                <p v-if=""scope.row.state==1"">启用</p>
            </template>
        </el-table-column>
        <el-table-column label=""操作"">
            <template slot-scope=""scope"">
                <span v-if=""scope.row.state==0"">
                    <el-button v-on:click=""StartUsing(scope.row)"" size=""mini"" type=""primary"">启用</el-button>
                </span>
                <span v-if=""scope.row.state==1"">
                    <el-button v-on:click=""StopUsing(scope.row)"" size=""mini"" type=""primary"">禁用</el-button>
                </span>
                <el-button v-on:click=""Upt(scope.row)"" size=""mini"" type=""primary"">编辑信息</el-button>
            </template>
        </el-table-column>
    </el-tab");
            WriteLiteral(@"le>
    <!-- 新增编辑窗口 -->
    <el-dialog title=""添加库管理员"" :visible.sync=""editFormVisible"">
        <el-form>
            <el-form-item label=""姓名"" :label-width=""formLabelWidth"">
                <el-input v-model=""KeeperName1"" autocomplete=""off""></el-input>
            </el-form-item>

            <el-form-item label=""手机号"" :label-width=""formLabelWidth"">
                <el-input v-model=""KeeperPhone1"" autocomplete=""off""></el-input>
            </el-form-item>
        </el-form>
        <div>
            <el-button v-on:click=""cancel()"">取消</el-button>
            <el-button type=""primary"" v-on:click=""sumbitEditRow()"">确定</el-button>
        </div>
    </el-dialog>
");
            WriteLiteral(@"    <el-pagination v-on:size-change=""handleSizeChange""
                   v-on:current-change=""handleCurrentChange""
                   :current-page=""pageIndex""
                   :page-sizes=""[3, 10, 15, 20]""
                   :page-size=""100""
                   layout=""total, sizes, prev, pager, next, jumper""
                   :total=""totalCount"">
    </el-pagination>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c263753e74432895533eb934f6fd1d9a13f16d10710", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c263753e74432895533eb934f6fd1d9a13f16d11750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c263753e74432895533eb934f6fd1d9a13f16d12790", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    new Vue({
        el: ""#div1"",
        data: {
            tableData: '',
            editFormVisible: false,
            addFormVisible: false,//是否显示编辑窗口
            formLabelWidth: '120px',
            fanLoading: false,
            input1: '',
            input2: '',
            ruleForm: {

            },
            rules: '',
            pageIndex: 1,
            pageSize: 3,
            totalCount: 11,
            KeeperName: '',
            KeeperPhone: '',
            KeeperName1: '',
            KeeperPhone1: ''
        },

        methods: {
            Show() {//查询显示
                var _this = this
                console.log(this.w);
                axios
                    .get('http://localhost:3687/api/GetWareHouseKeeper?keeperName=' + this.input1 + '&keeperPhone=' + this.input2 + '&pageIndex=' + this.pageIndex + '&pageSize=' + this.pageSize)
                    .then(response => { this.tableData = response.data.keeperDto, this.totalCount = respon");
            WriteLiteral(@"se.data.totalCount })
                    .catch(function (error) {
                        console.log(error);
                    })
            },
            StartUsing(row) {
                this.Id = row.wareHouserKeeperId
                axios.get('http://localhost:3687/api/StartUsing?id=' + this.Id)
                    .then((response) => {
                        if (response.data == true) {

                            this.$message({
                                type: ""success"",
                                message: ""启用成功！""

                            })
                        }
                    })
                    .catch(function (error) {
                        console.log(error);
                    });

            },
            StopUsing(row) {
                this.Id = row.wareHouserKeeperId
                axios.get('http://localhost:3687/api/StopUsing?id=' + this.Id)
                    .then((response) => {
                        if (response.dat");
            WriteLiteral(@"a == true) {

                            this.$message({
                                type: ""success"",
                                message: ""已禁用！""

                            })

                        }
                    })
                    .catch(function (error) {
                        console.log(error);
                    });

            },
            addRow() {//点击添加
                this.addFormVisible = true
            },
            sumbitAddRow() {//确认添加
                var time = new Date();
                var aa = {
                    ""KeeperName"": this.KeeperName, ""KeeperPhone"": this.KeeperPhone, ""CreateTime"": time.toLocaleTimeString(), ""State"":0
                }
                console.log(aa);
                axios({
                    headers: {
                        'Content-Type': 'application/json'
                    },

                    dataType: ""json"",
                    url: 'http://localhost:3687/api/AddKeeper',
            ");
            WriteLiteral(@"        method: 'post',
                    data: aa,
                })
                    .then((response) => {
                        console.log(response);
                        if (response.data == true) {
                            this.addFormVisible = false
                            this.$message({
                                type: ""success"",
                                message: ""添加成功！""
                            })
                            this.Show()
                        }
                    })
                    .catch(function (error) {
                        console.log(error);
                    });
            },
            Upt(row) {//点击编辑
                this.editFormVisible = true
                this.WareHouserKeeperId = row.wareHouserKeeperId
                this.KeeperName1 = row.keeperName
                this.KeeperPhone1 = row.keeperPhone
            },
            sumbitEditRow() {//编辑后提交
                axios.post('http://localhost:");
            WriteLiteral(@"3687/api/UptKeeper',
                    {
                        WareHouserKeeperId: parseInt(this.WareHouserKeeperId),
                        KeeperName: this.KeeperName1,
                        KeeperPhone: this.KeeperPhone1,
                    })
                    .then((response) => {
                        if (response.data > 0) {
                            this.editFormVisible = false,
                                this.$message({
                                    type: ""success"",
                                    message: ""修改成功！""
                                })
                            this.Show()
                        }
                    })
                    .catch(function (error) {
                        console.log(error);
                    })

            },
            cancel() {//取消
                this.addFormVisible = false
                this.editFormVisible = false
                this.$message({
                    type: 'info',
     ");
            WriteLiteral(@"               message: '已取消操作'
                });
            },
            //初始页pageIndex、初始每页数据pageSize和数据data
            handleSizeChange: function (size) {
                this.pageSize = size;
                console.log(this.pageSize)//每页下拉
                this.Show(this.pageSize);
            },
            handleCurrentChange: function (pageIndex) {
                this.pageIndex = pageIndex;
                console.log(this.pageIndex);
                this.Show(this.pageIndex);
            },
        },
        mounted() {//首次加载
            this.Show();
        }
    });
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
