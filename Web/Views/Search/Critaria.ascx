<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ OutputCache Duration="10000" VaryByParam="none" %>
<%@ Import Namespace="System.Collections.Generic"  %>
<%@ Import Namespace="System.Data"  %>
<%@ Import Namespace="DataSet"  %>
<%
    string heading = "";
    string panelExpandStatus = "";
    DSParameter ds = (DSParameter)System.Web.HttpContext.Current.Cache["data"];
    DataRow[] rows = ds.Product.Select(" Is_Active = 1 and Product_Type_ID = " + ViewData[UISearch.hidProduct_Type_ID.ToString()].ToString(), " Product_Code_To_Display asc ");
    int lower_limit = Convert.ToInt32(  Math.Floor( Convert.ToDecimal(  rows.Length/2 ) ) );
    string attr = "pro-";// ViewData[UISearch.hidProduct_Type_ID.ToString()].ToString();
    string proType = "prt-" + ViewData[UISearch.hidProduct_Type_ID.ToString()].ToString();
    string checkMark = "checked='checked'";
    int product_Type_ID = Convert.ToInt32(ViewData[UISearch.hidProduct_Type_ID.ToString()]);
    
    
    if( product_Type_ID > 21 )
        checkMark = " ";
    
    heading = ds.Product_Type.FindByProduct_Type_ID(Convert.ToInt32(ViewData[UISearch.hidProduct_Type_ID.ToString()])).Product_Type + "  (" + rows.Length.ToString() + ")";
    lower_limit = rows.Length;
    if (rows.Length == 0)
        return;
    if (lower_limit == 0)
        lower_limit = 2;   
    
    if( Convert.ToBoolean( ViewData["Is_Panel_Expand"] )  )
    {
        panelExpandStatus = "display: block;";
    }
    else
    {
        panelExpandStatus = "display: none;";   
    }
    
    
%>


 
<div id="ctl01_ucBlocks_ucMake_upHeader" class="label">
        <div id="ctl01_ucBlocks_ucMake_pnHeader" class="facethead label" onclick="slider.process(this);">
		     <div id="Multiselect Make" style="color:#695B72;"><%= heading%></div>
             <span style="color:#695B72;" class="count">Select Items</span>
        </div>
</div>

<div id="makes-content" class="content" style="<%= panelExpandStatus %>">
    <div class="text" id="<%= proType %>">
            <div class="scroller">
                <table class="" cellpadding="0" cellspacing="0" border="0" style="width:100%; margin-top:0px; margin-left:0px;">
                        <tbody>
                            <% for (int i = 0; i <= lower_limit + 3; i= i + 1)
                            {%>
                                <tr>
                                    <td class="cbs" style="width:310px" >
                                        <%if( i < rows.Length ) 
                                          {%>
                                                <table>
                                                    <tr >
                                                        <td style="width:10px;vertical-align: middle;"><input <%= checkMark %> name="<%= rows[i]["Product"].ToString()%>" class="cbs" rel="NotSet" id='<%= attr +  rows[i]["Product_ID"].ToString()%>' type="checkbox"/></td>
                                                        <td class="label" style="width:110px;vertical-align:top; padding:0em 0em 0em 3em"><a target="_blank" href="<%= rows[i]["Heading_Link"].ToString()  %>" ><img onError="this.src='<%=  Url.Content("~/images/no-product-image.jpg" )%>'" src="<%=  Url.Content("~/ProdImg/" +  rows[i]["Product_Image_Link"].ToString())%>"   alt="" name="product_r9_c2" width="120px" height="120px" border="0" class="catfixed" id="product_r9_c2"  style="opacity: 1; "></a></td>
                                                        <td class="labelBold" style="width:60px; vertical-align:top; padding:0em 0.5em 0em 0.5em"><label for="<%= rows[i]["Product_ID"].ToString()%>"><%= rows[i]["Product_Code_To_Display"].ToString()%> &nbsp;&nbsp;&nbsp;  </label></td>
                                                        <td class="labelBold" style="width:90px;vertical-align:top;padding:0em 2em 0em 1em"><%= rows[i]["Product"].ToString()%></td>
                                                        <td class="textBlack" style="width:170px;vertical-align:top;padding:0em 0em 0em 0em"><%= rows[i]["Description"].ToString()%></td>
                                                    </tr>
                                                </table>
                                          <%} %>
                                    </td>
                                </tr>
                            <%} %>
                        </tbody></table>
                        </div>
                            &nbsp;<a href="javascript:checkAll('<%= proType %>','Multiselect Make');" >Check All</a>
                            &nbsp;&nbsp;<a href="javascript:uncheckAll('<%= proType %>','Multiselect Make');">Uncheck All</a>
                        <div class="replace" style="margin:10px 5px 0px 0pt;float:left;">
                        </div><div class="replace" style="margin:10px 5px 0px 0pt;float:left;">
                        </div><br clear="both"></div>
</div>
