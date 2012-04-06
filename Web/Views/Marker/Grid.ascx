<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>


<%@ Import Namespace="System.Collections.Generic"  %>


<%
    string _class = "ui-button ui-widget ui-state-default ui-corner-all ui-button-text-only linkSimple  ";
    int grid_No = 1;
    string rowStyle = "";
    //DataSet.DSParameter ds2 = (DSParameter)System.Web.HttpContext.Current.Cache["data"];
    string link = "";
%>

 <% bool rowFlag = true; %>
    <% int sr_No = Convert.ToInt32( ViewData["start"] ) ;  %>
    <% foreach (var consumer in (ViewData[ UIMarker.listMarker.ToString()] as List< System.Data.DataRow>))
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
     
           <tr class="gridContent gridRow"  >
            
            <td class="<%=rowStyle %>">
                <%= sr_No.ToString()%>
            </td>
            
            <td class="<%=rowStyle %> col1">
                <%= consumer["Marker_Tag"].ToString()%> 
            </td>
            <td class="<%=rowStyle %> col2" style="width:190px" >
               <p class="<%=rowStyle %>" style="width:180px;"><%= consumer["Address"].ToString()%> </p>
            </td>
            
            <td class="<%=rowStyle %> col2" style="width:80px" >
               <p class="<%=rowStyle %>" style="width:80px;"><%= consumer["current_Monthly_Rank"].ToString()%> </p>
            </td>
            
            <td class="<%=rowStyle %> col2" style="width:80px" >
               <p class="<%=rowStyle %>" style="width:80px;"><%= consumer["Current_Monthly_Count"].ToString()%> </p>
            </td>
            
            <td class="<%=rowStyle %> col2" style="width:80px" >
               <p class="<%=rowStyle %>" style="width:80px;"><%= consumer["Current_Daily_Count"].ToString()%> </p>
            </td>
            
            <td class="<%=rowStyle %> col3" style="width:120px">
                <p class="<%=rowStyle %>" style="width:120px;"><%= consumer["City"].ToString()%> </p>
            </td>
            <td class="<%=rowStyle %>" style="width:120px">
                <p class="<%=rowStyle %>" style="width:120px;"><%= consumer["State"].ToString()%> </p>
            </td>
            <td class="<%=rowStyle %>" style="width:60px">
                <p class="<%=rowStyle %>" style="width:60px;"><%= consumer["Country"].ToString()%> </p>
            </td>
            <td class="<%=rowStyle %>">
                <a href="javascript:OnEdit(<%= consumer["Marker_ID"].ToString()%>)" class="gradButton">Edit</a>
            </td>
            
          </tr>
           <tr class="<%=rowStyle %> gridContent">
                <td colspan="10" class="<%=rowStyle %>">
                    <div id='<%= "Con" + sr_No.ToString() %>' style="padding-left:20px"></div>                                        
                </td>
            </tr>
          <% sr_No++; %>
    <% } %>
    
    
    
            
    
    
          
    
    
    
    
    
    
    
    
    
    
    <tr class="gridContent">
            <td colspan="10" align="right"  >
                
           <br /><br />
            </td>
    </tr>
    
    <%-- <tr class="gridContent">
            <td colspan="10" align="right" class="GridFooter" >
                <br />
                <% if ((string)ViewData["pageLinks"] != "" && Convert.ToInt16(ViewData["Count"]) > 0)
                   { %>
           <%= ViewData["pageLinks"]%>
           <br /><br />
        <% } %>
            </td>
    </tr>--%>


   