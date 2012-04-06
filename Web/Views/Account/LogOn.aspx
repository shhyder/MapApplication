<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Web.Models.LogOnModel>" %>


<%@ Register assembly="Google Analytics Desbord Controls" namespace="GADCAPI" tagprefix="cc1" %>


<asp:Content ID="loginTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Log On
</asp:Content>

<asp:Content ID="loginContent" ContentPlaceHolderID="MainContent" runat="server">
    
   
    
    
    
   <div class="fullscreen">



<table width="100%" height="100%">
	<tr>
    	<td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    
    <tr>
    	<td>&nbsp;</td>
        <td align="center">
        
                 <% using (Html.BeginForm("Logon", "Account", FormMethod.Post, new { @id = "logonForm", @name = "logonForm" }))
            { %>
        <table  style=" vertical-align:middle;" width="350px" class="Grid"  >            <tbody>                <tr class="Grid" bgcolor="#60555F" >
            <th height="40" colspan = "3" align="left" valign="middle" bgcolor="#60555F" class="Grid" style="font-size:20px; color:white; background:#60555F; vertical-align:middle;" >&nbsp; User Login</th>
          </tr>
                <tr class="Grid" height="15">
            <th class="Grid" height="15"  style="font-size:10px;" colspan = "3" align="left" valign="middle" >&nbsp;Enter your user name and Password to login</th>
          </tr>
                <tr  >
            <td width="8" align="left">&nbsp;</td>
            <td width="81" align="left">&nbsp;</td>
            <td width="219" align="left">&nbsp; </td>
            </tr>
                <tr>
            <td align="left">&nbsp;</td>
            <td align="left" class="RTextAlign"><strong><%= Html.LabelFor(m => m.UserName)%></strong></td>
            <td align="left"><%=  Html.TextBoxFor(m => m.UserName, new { @Value ="Admin"})%> </td>
            </tr>
                <tr>
            <td align="left">&nbsp;</td>
            <td align="left"><%= Html.ValidationMessageFor(m => m.UserName)%></td>
            <td align="left">&nbsp;</td>
            </tr>
                <tr>
            <td align="left">&nbsp;</td>
            <td align="left" class="RTextAlign"><strong><%= Html.LabelFor(m => m.Password)%></strong></td>
            <td align="left"><%= Html.PasswordFor(m => m.Password, new { @Value = "Admin" })%></td>
            </tr>
                <tr >
            <td colspan="3" align="left"><%= Html.ValidationSummary(true, "Login was unsuccessful. Please correct the errors and try again.")%>                    <%= Html.ValidationMessageFor(m => m.Password)%>            </td>
            
          </tr>
           <tr >
            <td align="left">&nbsp;</td>
            <td align="right" style="padding-left:45px;"> <%= Html.CheckBoxFor(m => m.RememberMe)%>
                    </td>
            <td align="left" class="LTextAlign"><%= Html.LabelFor(m => m.RememberMe)%> <a onclick="javascript:document.logonForm.submit()" class="gradButton"  >Log On</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
          </tr>                    <tr >
            <td colspan="3" class="Error" align="left"></td>
            
          </tr>
          </tbody>        </table>
           

   
        
        
    <% } %>
        
        
        
    &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    
    <tr>
    	<td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>


</table>
</div>
  
    
    
</asp:Content>
