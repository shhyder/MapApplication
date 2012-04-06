<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="System.Collections.Generic"  %>




<form id="formStoreSearch" action="Approved.ascx" method="post"> 
    
    <div id="map-pane" style="position: absolute;width:1200px;"  >
        <div id="map-loading" class="loading"><img  src='<%=  Url.Content("~/images/ajax-loader.gif")%>' width="32" height="32" /><strong>Loading</strong></div>
     <div id="divLoading" ></div>
    
    <%if (Convert.ToInt16(ViewData["Count"]) > 0)
      {%>
        <table width="1200px" class="mainTable">
            <thead id="StoreGrid" >
                <tr style="background-color:#DCDCDB;">
                    <th colspan="10" >
                        
                      
                        
                        <%--<table width="100%" border="1" >
                            <tr style="height:100px;" >
                                <td align="left">
                                    
                                </td>
                            </tr>
                         </table> --%>  
                    </th>
                </tr>
                
                <tr style="background-color:#DCDCDB;">
                    
                    
                    <th colspan="10">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    &nbsp;<a href="javascript:OnNew()" class="gradButton">New</a>
                                    &nbsp;&nbsp;<a onclick="javascript:AddLoading(this);" href="<%=  Url.Content("~/Product/Index")%>">Product Search</a>
                                    &nbsp;&nbsp;<a onclick="javascript:AddLoading(this);" href="<%=  Url.Content("~/Analysis/Index")%>">Analysis</a>
                                    &nbsp;&nbsp;<a onclick="javascript:AddLoading(this);" href="<%=  Url.Content("~/Category/Index")%>">Category</a>
                                </td>
                                <td align="right">
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
            
            <tr>
                <th class="Grid" style="width:70px">
                    Sr. <br />
                    <a href="javascript:OnReset()" >Reset</a>
                </th>
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
                    <%= Html.TextBox("srhCode", "", new { @class = "srhCode", maxlength = 25, Style = "width: 70px;color:Gray;", onkeyup = "searchChange(this)", onkeypress = "javascript:searchChangeNumeric(event,this,this);" })%>
                </th>
                <th class="Grid col2" style="width:190px">
                    <div class="GridOrder gridOrderStore" id="gridOrderStore" style="width:100%; text-align: left" onclick="checkClick(this);">
                    <table width="100%">
                        <tr>
                            <td align"left">Store</td>
                            <td class="headerArrow"></td>
                        </tr>
                    </table>
                    <input name="ordStore" id="ordStore" class="hidOrder" type="hidden" value="0" />
                    </div>
                    <%= Html.TextBox("srhStore", "", new { @class = "srhStore", maxlength = 25, Style = "width: 190px;color:Gray;", onkeyup = "searchChange(this)" })%>
                </th>
                
                <th class="Grid col3" style="width:270px">
                    <div class="GridOrder gridOrderAddress" id="gridOrderAddress" style="width:100%; text-align: left" onclick="checkClick(this);">
                    <table width="100%">
                        <tr>
                            <td align"left">Address</td>
                            <td class="headerArrow"></td>
                        </tr>
                    </table>
                    <input name="ordAddress" id="ordAddress" class="hidOrder" type="hidden" value="0" />
                    </div>
                    <%= Html.TextBox("srhAddress", "", new { @class = "srhAddress", maxlength = 25, Style = "width: 270px;color:Gray;", onkeyup = "searchChange(this)" })%>
                </th>
                <th class="Grid" style="width:80px">
                    <div class="GridOrder gridOrderCity" id="gridOrderCity" style="width:100%; text-align: left" onclick="checkClick(this);">
                    <table width="100%">
                        <tr>
                            <td align"left">City</td>
                            <td class="headerArrow"></td>
                        </tr>
                    </table>
                    <input name="ordCity" id="ordCity" class="hidOrder" type="hidden" value="0" />
                    </div>
                    <%= Html.TextBox("srhCity", "", new { @class = "srhCity", maxlength = 25, Style = "width:80px;color:Gray;", onkeyup = "searchChange(this)" })%>
                </th>
                 <th class="Grid" style="width:60px">
                    <div class="GridOrder gridOrderState" id="gridOrderState" style="width:100%; text-align: left" onclick="checkClick(this);">
                    <table width="100%">
                        <tr>
                            <td align"left">State</td>
                            <td class="headerArrow"></td>
                        </tr>
                    </table>
                    <input name="ordState" id="ordState" class="hidOrder" type="hidden" value="0" />
                    </div>
                    
                    <%= Html.TextBox("srhState", "", new { @class = "srhState", maxlength = 25, Style = "width:60px;color:Gray;", onkeypress = "searchChange(this)" })%>
                </th>
                <th class="Grid" style="width:150px">
                    <div class="GridOrder gridOrderEmail" id="gridOrderEmail" style="width:100%; text-align: left" onclick="checkClick(this);">
                    <table width="100%">
                        <tr>
                            <td align"left">Email</td>
                            <td class="headerArrow"></td>
                        </tr>
                    </table>
                    <input name="ordEmail" id="ordEmail" class="hidOrder" type="hidden" value="0" />
                    </div>
                    <%= Html.TextBox("srhEmail", "", new { @class = "srhEmail", maxlength = 25, Style = " width:100%;color:Gray;", onkeypress = "searchChange(this)" })%>
                </th>
                <th class="Grid" style="width:130px; overflow: hidden">
                    <div class="GridOrder gridOrderPhone" id="gridOrderPhone" style="width:100%; text-align: left" onclick="checkClick(this);">
                    <table width="100%">
                        <tr>
                            <td align"left">Phone</td>
                            <td class="headerArrow"></td>
                        </tr>
                    </table>
                    <input name="ordPhone1" id="ordPhone" class="hidOrder" type="hidden" value="0" />
                    
                    <%= Html.TextBox("srhPhone1", "", new { @class = "srhPhone1", maxlength = 25, Style = "width:100%;color:Gray;", onkeypress = "searchChange(this)" })%>
                </th>
                <th class="Grid" style="width:80px">
                    Status
                    <input name="srhStatus" id="srhStatus" class="cbs srhStatus" checked="checked"  type="checkbox" onchange="searchCheckedChange(this);"/>
                </th>
                <th class="Grid" >
                    Action
    </th>
            </tr>
              </thead>
        <tr >
        
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
   vdd["name"] = UIStore.dlgStore.ToString();
    Html.RenderPartial("Dialog", vdd);%>