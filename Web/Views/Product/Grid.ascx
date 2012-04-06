<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%@ Import Namespace="System.Collections.Generic"  %>
<%
    string _class = "ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only linkSimple  ";
    int grid_No = 1;
    string rowStyle = "";
    DataSet.DSParameter ds2 = (DataSet.DSParameter)System.Web.HttpContext.Current.Cache["data"];
    string link = "";
%>

 <% bool rowFlag = true; %>
    <% int sr_No = Convert.ToInt32( ViewData["start"] ) ;  %>
    
   
    
                
  
    
    
    <% foreach (var consumer in (ViewData[ UIProduct.listProduct.ToString()] as List< System.Data.DataRow>))
       { %>
        <% if (grid_No % 2 == 0)
               {
                   rowStyle = "GridNonAlt";
               }
               else
               {
                   rowStyle = "GridAlt";
               }
               grid_No++;
       %>
     
           <tr class="gridContent" >
            
            <td class="<%=rowStyle %>" style="vertical-align:middle;text-align:center;">
                <%= sr_No.ToString()%>
            </td>
            
            <td class="<%=rowStyle %>" style="vertical-align:middle;text-align:center;">
                <img onError="this.src='<%=  Url.Content("~/images/no-product-image.jpg" )%>'"  src="<%=  Url.Content("~/ProdImg/" +  consumer["Product_Image_Link"].ToString())%>"  alt="" name="product_r9_c2" width="60px" height="60px" border="0" class="catfixed" id="product_r9_c2"  style="opacity: 1; ">
            </td>
            <td class="<%=rowStyle %>" style="vertical-align:middle;text-align:center;" >
               <p class="<%=rowStyle %>" style="width:60px;"><%= consumer["Product_Code"].ToString()%> </p>
            </td>
            <td class="<%=rowStyle %>" style="vertical-align:middle;text-align:center;" >
               <p class="<%=rowStyle %>" style="width:60px;"><%= consumer["Product_Code_To_Display"].ToString()%> </p>
            </td>
            <td class="<%=rowStyle %>" style="vertical-align:middle;text-align:center;" >
               <p class="<%=rowStyle %>" style="width:60px;"><%= consumer["Product"].ToString()%> </p>
            </td>
            <td class="<%=rowStyle %>" style=" padding: 5px 5px 6px 5px; overflow:hidden;width:200px;">
                <p class="<%=rowStyle %>" style="width:60px;"><%= consumer["Description"].ToString()%> </p>
            </td>
            <td class="<%=rowStyle %>" style="vertical-align:middle;text-align:center;">
                <p class="<%=rowStyle %>" style="width:60px;"><%= ds2.Product_Type.FindByProduct_Type_ID(Convert.ToInt32(consumer["Product_Type_ID"])).Product_Type%> </p>
            </td>
            <td class="<%=rowStyle %>" style="vertical-align:middle;text-align:center;">
                <%if ( Convert.ToBoolean( consumer["Is_Active"] ) )
                  { %>
                    Active
                <%}else
                { %>
                    In-active
                <%} %>
            </td>
            <td class="<%=rowStyle %>" style="vertical-align:middle;text-align:center;">
            <a href="javascript:OnEdit('<%= consumer["Product_ID"].ToString()  %>')" class="gradButton">Edit</a>
            
            
             </td>
            
          </tr>
          
          <% sr_No++; %>
    <% } %>
    
    <tr class="gridContent">
            <td colspan="10" align="right"  >
                
           <br /><br />
            </td>
    </tr>
    
    <%--<tr class="gridContent GridFooter">
            <td colspan="9" align="right" class="GridFooter" >
                <% if ((string)ViewData["pageLinks"] != "" && Convert.ToInt16(ViewData["Count"]) > 0)
                   { %>
           <%= ViewData["pageLinks"]%>
        <% } %>
            </td>
    </tr>
--%>


