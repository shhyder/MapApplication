<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/App.Master" Inherits="System.Web.Mvc.ViewPage" %>




<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
       
    <script src='<%=  Url.Content("~/Pro_files/jquery_002.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/Awesome.js")%>' type="text/javascript"></script>
    
    <script src='<%=  Url.Content("~/MapJS/Category.js")%>' type="text/javascript"></script>
    <link id="Link1" href='<%=  Url.Content("~/Pro_files/jquery-ui.css")%>' rel="stylesheet" type="text/css"/>
    <script src='<%=  Url.Content("~/Pro_files/jquery.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/jquery-ui.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/jquery_002.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/Awesome.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/style.js")%>' type="text/javascript"></script>
    
    <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?libraries=places&sensor=false"></script>
  <script type="text/javascript" src='<%=  Url.Content("~/js/jquery.ez-pinned-footer.js")%>'></script>
    <script type="text/javascript" src='<%=  Url.Content("~/js/Main.js")%>'></script>
  


    <div id="CategoryList" >
        <% Html.RenderPartial("List");%>
    </div>
     
     
     <div id="footer" align="right" class="GridFooter" style="position: fixed" >
            <br />
                <% if ((string)ViewData["pageLinks"] != "" && Convert.ToInt16(ViewData["Count"]) > 0)
                   { %>
           <%= ViewData["pageLinks"]%>
           <br /><br />
            <% } %>
    </div>
     
     <script type="text/javascript">
     var lastpage = 0;
     function GetList(page) {
         var queryString = jQuery('#formCategorySearch').formSerialize();
         jQuery('.gridContent').fadeTo('slow', 0.5, function() { });
         lastpage = page;
         jQuery.ajax({
         url: pfxURL.staticVar + "/Category/GetList/" + page,
             dataType: 'json',
             type: "POST",
             data: queryString,
             success: function(json) {
                 jQuery('.gridContent').remove();
                 jQuery(json.CategoryList).insertAfter('#CategoryGrid');
                 document.getElementById("footer").innerHTML = json.Navigator;
                 jQuery(".SearchCritaria").html(json.SearchCritaria);
                 json = null;
                 jQuery('.gridContent').fadeTo('slow', 1.0, function() { });
             }
         });
     }

     
</script>
    
  
  
 <script type="text/javascript">



 function OnNew() {
     var queryString = "";
     var id = 1;
   
     ae_popup('<%= UIProductType.dlgProductType.ToString() %>', 450,190, 'Category', true, 'center', true,
        { "Save": function() { OnSave(); }, "Cancel": function() { $(this).dialog('close'); } },
        false);
     lpf<%= UIProductType.dlgProductType.ToString() %> = true;

     $.get(pfxURL.staticVar + "/Category/New/" + id,
            NewCategory
            );
        
    }
    
    
    function NewCategory(data) {

        lpf<%= UIProductType.dlgProductType.ToString() %> = null;
        //style = "width: auto; min-height: 0px; height: 150px; "

        $("#<%= UIProductType.dlgProductType.ToString() %>").html(data);

        jQuery('#<%= UIProductType.dlgProductType.ToString() %>').attr("Style", "width: 600px; min-height: 300px; height: 500px;");
        jQuery("#<%= UIProductType.dlgProductType.ToString() %>").dialog('open');
        jQuery("#<%= UIProductType.dlgProductType.ToString() %> form input:visible:first").focus();
        
       
    }
    
    
    function OnSave()
    {
         var queryString = $('#<%= UIProductType.formProductType.ToString() %>').serialize();
         
         $.getJSON(pfxURL.staticVar + "/Category/Save", queryString, function(data) {
                    
                    if( data.Has_Error )
                    {
                        $('#CodeError').html(data.CodeError );
                        $('#CategoryError').html(data.CategoryError);
                        $('#BuildingError').html(data.BuildingError);
                        $('#AddressError').html(data.AddressError);
                        $('#FullAddressError').html(data.FullAddressError);
                        $('#CityError').html(data.CityError);
                        $('#Email1Error').html(data.Email1Error);
                        $('#Email2Error').html(data.Email2Error);
                        $('#Phone1Error').html(data.Phone1Error);
                        $('#Phone2Error').html(data.Phone2Error);
                        $('#WebsiteError').html(data.WebsiteError);
                    }
                    else
                    {
                        alert("Category has been saved");
                        $('#<%= UIProductType.dlgProductType.ToString() %>').dialog('close'); 
                        GetList(lastpage );
                    }
                    
                });
    
    
    }
    
    
    
    function OnEdit(id) {
    
     ae_popup('<%= UIProductType.dlgProductType.ToString() %>', 450,190, 'Category', true, 'center', true,
        { "Save": function() { OnSave(); }, "Cancel": function() { $(this).dialog('close'); } },
        false);
     lpf<%= UIProductType.dlgProductType.ToString() %> = true;

     $.get(pfxURL.staticVar + "/Category/Edit/" + id ,
            EditCategory
            );
        
    }
    
    
    function EditCategory(data) {

        lpf<%= UIProductType.dlgProductType.ToString() %> = null;
        $("#<%= UIProductType.dlgProductType.ToString() %>").html(data);
        jQuery('#<%= UIProductType.dlgProductType.ToString() %>').attr("Style", "width: 600px; min-height: 300px; height: 500px;");
        jQuery("#<%= UIProductType.dlgProductType.ToString() %>").dialog('open');
        jQuery("#<%= UIProductType.dlgProductType.ToString() %> form input:visible:first").focus();
        
    }
    
    
    
    function OnDelete(codeSLSP,SalesRepCode,Territory )
    {
         var str = codeSLSP + "/" + SalesRepCode + "/" + Territory; 
       
         $.getJSON( pfxURL.staticVar + "/Category/Delete/" + str , "", function(data) {
                    if( data.Has_Error )
                    {
                       
                    }
                    else
                    {
                        alert("Category Has been deleted");
                        GetList(lastpage );
                    }
                    
                });
    
    
    }
    
    
    
    
    
    
    

</script>











  
  </asp:Content> 