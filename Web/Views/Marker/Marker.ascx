<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<style type="text/css">
    .style2
    {
        width: 65px;
    }
    .style3
    {
        width: 138px;
    }
    .style5
    {
        width: 353px;
    }
    .style6
    {
        width: 94px;
    }
</style>

<%
    bool Is_Control_RO = false;
    string strClass = "";

    if ( Convert.ToInt32( ViewData[UIMarker.hidState.ToString()] ) == 2 || 
        Convert.ToInt32( ViewData[UIMarker.hidState.ToString()] ) == 3 )
    {
        Is_Control_RO = false;
    }
    else
    {
        Is_Control_RO = true;
    }
    
    

    if (Convert.ToInt32(ViewData[UIMarker.hidState.ToString()]) == 3)
    {
        strClass = "Enabled";
    }
    else
    {
        strClass = "Disabled";
    }
    
    
 %>


<form id="formMarker" action="Approved.ascx" method="post"> 
 <%= Html.Hidden(UIMarker.hidState.ToString(), ViewData[UIMarker.hidState.ToString()].ToString())%>
 <%= Html.Hidden(UIMarker.hidID.ToString(), ViewData[UIMarker.hidID.ToString()].ToString())%>
 <%= Html.Hidden(UIMarker.hidLatitude.ToString(), ViewData[UIMarker.hidLatitude.ToString()].ToString())%>
 <%= Html.Hidden(UIMarker.hidLongitude.ToString(), ViewData[UIMarker.hidLongitude.ToString()].ToString())%>
 
 
 <table border="0" style="width: 610px; border-top-style: none;" >
       
        
        <tr>
          <td></td>
          <td class="style2" >Marker</td>
          <td class="style3" colspan="4">
            <input class="<%= strClass %>" type="text" style=" width:290px;" name="txtMarker" id="txtMarker"  maxlength="50"  value="<%= ViewData[ UIMarker.txtMarker.ToString()].ToString()  %>"/>
          </td>
          
          <td   rowspan="8" id="MapImage" align="right" valign="top" style=" width:250px;"><img border='0' style="width:250px;height:180px;" src='<%=  Url.Content("~/images/Google-Maps-icon.png")%>' alt='image could not be found' /> </td>
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td class="style2" ></td>
            <td colspan="4" ><span class="error" id="MarkerError"></span></td>
        </tr>
        
        
        
      
        
       
       
          
        <tr>
          <td>&nbsp;</td>
          <td class="style2" >Address</td>
          <td class="style3" colspan="4">   
            <input class="<%= strClass %>" type="text" name="txtAddress" id="txtAddress" style=" width:280px;" value="<%= ViewData[UIMarker.txtAddress.ToString()].ToString()  %>"/>
          </td>
          
        </tr>
        <tr>
            <td >&nbsp;</td>
            <td class="style2" ></td>
            <td class="style3" colspan="4"><span class="error" id="AddressError" ></span></td>
            
        </tr>
       
       
       
        <tr>
            <td >&nbsp;</td>
            <td class="style2" >City</td>
            <td class="style3" colspan="4">
                <input class="<%= strClass %>" type="text" name="txtCity" id="txtCity" maxlength="5" Style ="width:100px;" value="<%= ViewData[UIMarker.txtCity.ToString()].ToString()  %>"/>
                
            </td>
        </tr>
        
        <tr>
            <td >&nbsp;</td>
            <td class="style2" ></td>
            <td class="style3" colspan="4"><span class="error" id="Span1" ></span></td>
            
        </tr>
       
      <tr>
          <td></td>
          <td class="style2">State</td>
          <td class="style3" colspan="4">
                <input class="<%= strClass %>" type="text" name="txtState" id="txtState" maxlength="5" Style ="width:90px;" value="<%= ViewData[UIMarker.txtState.ToString()].ToString()  %>"/>
                 Country <input class="<%= strClass %>" type="text" name="txtCountry" id="txtCountry" maxlength="5" Style ="width:90px;" value="<%= ViewData[UIMarker.txtCountry.ToString()].ToString()  %>"/>
          </td>
        </tr>
     
        
        
     
        <tr>
            <td >&nbsp;</td>
            <td class="style2" >&nbsp;</td>
            <td colspan="2" ><span class="error" id="CityError" ></span></td>
            <td class="style6" >&nbsp;</td>
            <td class="style5" >&nbsp;</td>
            <td  ><span class="error" id="Span11" ></span></td>
        </tr>
        
        
      
        
      
       
       
        
         
        <tr>
          <td></td>
          <td class="style2"></td>
          <td class="style3" colspan="4"><input name="Is_Website_Display" <%= Convert.ToBoolean( ViewData[UIMarker.is_Recurring_Event.ToString()] ) ? "checked='checked'":""  %>  id="is_Recurring_Event" type="checkbox"/>is_Recurring_Event
          
          </td>
          
           
            
            <td ></td>
            
        </tr>
        <tr>
            <td></td>
            <td></td>
             <td colspan="4" ><span class="error" id="WebsiteError" ></span></td>
            
        </tr>
    
     </table>
</form>

<script>
    $("#txtAddress").live("focus", function() {
        $('.pac-container').attr('Style', 'position: absolute; z-index: 1005; left: 215px; top: 155px; width: 420px; display: none');
    });

    $("#formMarker").delegate("input", "focus", function() {
        $(".error").html("");
    });
</script>

   