<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="System.Collections.Generic"  %>
<form id="formProductSearch" action="Approved.ascx" method="post"> 
      <div id="map-pane" style="position: absolute;width:1200px;"  >
        <div id="map-loading" class="loading"><img  src='<%=  Url.Content("~/images/ajax-loader.gif")%>' width="32" height="32" /><strong>Loading</strong></div>
    <div id="divLoading" ></div>
    
    <%if (Convert.ToInt16(ViewData["Count"]) > 0)
      {%>
         <table width="1200px" class="mainTable">
             <thead id="ProductGrid" >
                 <tr style="background-color:#DCDCDB;">
                    <th colspan="10">
                        <table width="100%">
                            <tr>
                                <td align="left" width="60%">
                                &nbsp;<a href="javascript:OnNew()" class="gradButton">New</a>
                &nbsp;&nbsp;<a onclick="javascript:AddLoading(this);" href="<%=  Url.Content("~/Store/Index")%>">Store Search</a> 
                &nbsp;&nbsp;<a onclick="javascript:AddLoading(this);" href="<%=  Url.Content("~/Analysis/Index")%>">Analysis</a>
                &nbsp;&nbsp;<a onclick="javascript:AddLoading(this);" href="<%=  Url.Content("~/Category/Index")%>">Category</a>
            </td>
            <td align="right" width="40%">
                <% Html.RenderPartial("LogOnUserControl");%>
            </td>
                            </tr>
                        </table>
                    </th>
                </tr>
            
                 <tr style="background-color:#DCDCDB;">
                <th class="Grid" colspan="10" align="left">Rows <%=  Html.DropDownList(UIAll.gridSize.ToString(), (SelectList)ViewData[UIAll.gridSizeList.ToString()], new { @class = "gridSize", style = "width: 70px;", onChange = "searchChange(this)" })%>
                <span class="SearchCritaria" id="SearchCritaria" name="SearchCritaria"><%= ViewData["SearchCritaria"].ToString()%></span>
                </th>
            </tr>
         
            <tr class="Grid" >
                <th class="Grid" style="width:45px">
                    Sr. <br />
                    <a href="javascript:OnReset()" >Reset</a>
                </th>
                <th class="Grid" style="width:90px"></th>
                <th class="Grid col1" style="width:70px">
                    <div class="GridOrder gridOrderCode" id="gridOrderCode" style="width:100%; text-align: left" onclick="checkClick(this);" >
                <table width="100%">
                    <tr>
                        <td align"left">Code</td>
                        <td class="headerArrow"></td>
                    </tr>
                </table>
                <input name="ordCode" id="ordCode" class="hidOrder" type="hidden" value="0" />
                </div>
                <%= Html.TextBox("srhCode", "", new { @class = "srhCode", maxlength = 25, Style = "width: 70px;color:Gray;", onkeyup = "searchChange(this)" })%>
            </th>
                <th class="Grid" style="width:90px">
                    <div class="GridOrder gridOrderDisplayCode" id="gridOrderDisplayCode" style="width:100%; text-align: left" onclick="checkClick(this);" >
                <table width="100%">
                    <tr>
                        <td align"left">Disp Code</td>
                        <td class="headerArrow"></td>
                    </tr>
                </table>
                <input name="ordDisplayCode" id="ordDisplayCode" class="hidOrder" type="hidden" value="0" />
                </div>
                    
                    <%= Html.TextBox("srhDisplayCode", "", new { maxlength = 25, Style = "width: 100%;color:Gray;", onkeyup = "searchChange(this)" })%>
                </th>
                <th class="Grid" style="width:170px">
                    <div class="GridOrder gridOrderProduct" id="gridOrderProduct" style="width:100%; text-align: left" onclick="checkClick(this);" >
                <table width="100%">
                    <tr>
                        <td align"left">Product</td>
                        <td class="headerArrow"></td>
                    </tr>
                </table>
                <input name="ordProduct" id="ordProduct" class="hidOrder" type="hidden" value="0" />
                </div>
                    <%= Html.TextBox("srhProduct", "", new { maxlength = 25, Style = "width: 100%;color:Gray;", onkeyup = "searchChange(this)" })%>
                </th>
                <th class="Grid" style="width:270px">
                    <div class="GridOrder gridOrderDescription" id="gridOrderDescription" style="width:100%; text-align: left" onclick="checkClick(this);" >
                <table width="100%">
                    <tr>
                        <td align"left">Description</td>
                        <td class="headerArrow"></td>
                    </tr>
                </table>
                <input name="ordDescription" id="ordDescription" class="hidOrder" type="hidden" value="0" />
                </div>
                    <%= Html.TextBox("srhDescription", "", new { Style = "width: 100%;color:Gray;", onkeyup = "searchChange(this)" })%>
                </th>
                <th class="Grid" style="width:80px">
                    Product Type
                    <%=  Html.DropDownList(UIProduct.srhProductType.ToString(), (SelectList)ViewData[UIProductSearch.listProductType.ToString()], new { style = "width: 120px;", onchange = "searchChange(this)" })%>
                </th>
                 <th class="Grid" style="width:80px">
                    Status
                    <input name="srhStatus" class="cbs srhStatus" checked="checked"  id="srhStatus" type="checkbox" onchange="searchCheckedChange(this);"/>
                </th>
                <th class="Grid" style="width:140px">
                    Action 
                </th>
        </tr>
            
            </thead>
            <tr>
                <% Html.RenderPartial("Grid");%>
            </tr>
        </table>
     <%}
      else
      {%>
        <p>No consumer has been found</p>
    <%} %>
    </div>
</form>



<% ViewDataDictionary vdd = new ViewDataDictionary();
   vdd["name"] = UIProduct.dlgProduct.ToString();
    Html.RenderPartial("Dialog", vdd);%>