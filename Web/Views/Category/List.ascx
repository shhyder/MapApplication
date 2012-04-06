<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%@ Import Namespace="System.Collections.Generic"  %>

<form id="formCategorySearch" action="Approved.ascx" method="post"> 

    <div id="map-pane" style="position: absolute;width:1200px;"  >
        <div id="map-loading" class="loading"><img  src='<%=  Url.Content("~/images/ajax-loader.gif")%>' width="32" height="32" /><strong>Loading</strong></div>
     <div id="divLoading" ></div>
     
     <%if (Convert.ToInt16(ViewData["Count"]) > 0)
      {%>
        <table width="1200px" class="mainTable">
            <thead id="CategoryGrid" >
            
                <tr style="background-color:#DCDCDB;">
                    <th colspan="10">
                        <table width="100%">
                            <tr>
                                <td align="left">
                                    &nbsp;<a href="javascript:OnNew()" class="gradButton">New</a>
                                    &nbsp;&nbsp;<a onclick="javascript:AddLoading(this);" href="<%=  Url.Content("~/Product/Index")%>">Product Search</a>
                                    &nbsp;&nbsp;<a onclick="javascript:AddLoading(this);" href="<%=  Url.Content("~/Analysis/Index")%>">Analysis</a>
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
        
                <tr class="Grid" >
                    <th class="Grid" style="width:70px">
                        Sr. <br />
                        <a href="javascript:OnReset()" >Reset</a>
                </th>
                    <th class="Grid" style="width:270px">
                        <div class="GridOrder gridOrderCategory" id="gridOrderCategory" style="width:100%; text-align: left" onclick="checkClick(this);" >
                            <table width="100%">
                                <tr>
                                    <td align"left">Category</td>
                                    <td class="headerArrow"></td>
                                </tr>
                            </table>
                            <input name="ordProductType" id="ordProductType" class="hidOrder" type="hidden" value="0" />
                        </div>
                        <%= Html.TextBox("srhProductType", "", new { @class = "srhProductType", maxlength = 25, Style = "width: 100%;color:Gray;", onkeyup = "searchChange(this)" } )%>
                    </th>
                    <th class="Grid" style="width:80px">
                        Status
                               <input name="srhStatus" id="srhStatus" class="cbs srhStatus" checked="checked"  type="checkbox" onchange="searchCheckedChange(this);"/>
             
                    </th>
                    <th class="Grid" style="width:120px">
                        Action
                    </th>
                </tr>
            </thead>
            
            <% Html.RenderPartial("Grid");%>
            
        </table>
     <%}
      else
      {%>
        <p>No consumer has been found</p>
    <%} %>
    
    </div>
   
</form>

<% ViewDataDictionary vdd = new ViewDataDictionary();
   vdd["name"] = UIProductType.dlgProductType.ToString();
    Html.RenderPartial("Dialog", vdd);%>