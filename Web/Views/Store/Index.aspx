<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/App.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="System.Web.Configuration"  %>



<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
       
    <script src='<%=  Url.Content("~/Pro_files/jquery_002.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/Awesome.js")%>' type="text/javascript"></script>
    
    <script src='<%=  Url.Content("~/MapJS/Store.js")%>' type="text/javascript"></script>
    <link id="Link1" href='<%=  Url.Content("~/Pro_files/jquery-ui.css")%>' rel="stylesheet" type="text/css"/>
    <script src='<%=  Url.Content("~/Pro_files/jquery.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/jquery-ui.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/jquery_002.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/Awesome.js")%>' type="text/javascript"></script>
    <script src='<%=  Url.Content("~/Pro_files/style.js")%>' type="text/javascript"></script>
    <script type="text/javascript" src='<%=  Url.Content("~/js/jquery.ez-pinned-footer.js")%>'></script>
    <script type="text/javascript" src='<%=  Url.Content("~/js/Main.js")%>'></script>
  
  <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
<script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?libraries=places&sensor=false"></script>

                                        <div id="map" style="width: 1200px; height: 480px"></div> 
                        

     <div id="StoreList" >
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
         var queryString = jQuery('#formStoreSearch').formSerialize();
         jQuery('.gridContent').fadeTo('slow', 0.5, function() { });
         lastpage = page;
         jQuery.ajax({
             url: pfxURL.staticVar + "/Store/GetList/" + page,
             dataType: 'json',
             type: "POST",
             data: queryString,
             success: function(json) {
                 jQuery('.gridContent').remove();
                 jQuery(json.StoreList).insertAfter('#StoreGrid');
                 document.getElementById("footer").innerHTML = json.Navigator;
                 markers = json.Markers; //[{ id: 5, latitude: 33.8592430000, longitude: -118.0232100000, title: 'sdfdsf', icon: '/MarkerIcon.ashx?label=1', detail: '5', zIndex: 5, facebook: 5}];
                 initialize(5);
                 jQuery(".SearchCritaria").html(json.SearchCritaria);
                 json = null;
                 jQuery('.gridContent').fadeTo('slow', 1.0, function() { });
             }
         });
     }

    

    

    

    


    

   


//     jQuery("select").change(function() {
//         GetList(1);
//     });

//     jQuery("input, [checkbox]").click(function(event) {
//         GetList(1);
//     });
     
</script>

    <script type="text/javascript">



 function OnNew() {
     var queryString = "";
     var id = 1;
   
     ae_popup('<%= UIStore.dlgStore.ToString() %>', 650, 500, 'Store', true, 'center', true,
        { "Save": function() { OnSave(); }, "Cancel": function() { $(this).dialog('close'); } },
        false);
     lpf<%= UIStore.dlgStore.ToString() %> = true;

     $.get(pfxURL.staticVar + "/Store/New/" + id,
            NewStore
            );
        
    }
    
    
    
    
    
    function NewStore(data) {

        lpf<%= UIStore.dlgStore.ToString() %> = null;
        //style = "width: auto; min-height: 0px; height: 150px; "

        $("#<%= UIStore.dlgStore.ToString() %>").html(data);

        jQuery('#<%= UIStore.dlgStore.ToString() %>').attr("Style", "width: 600px; min-height: 300px; height: 500px;");
        jQuery("#<%= UIStore.dlgStore.ToString() %>").dialog('open');
        jQuery("#<%= UIStore.dlgStore.ToString() %> form input:visible:first").focus();
        SetAddress();  
        
       
    }
    
    
    function OnSave()
    {
         var queryString = $('#<%= UIStore.formStore.ToString() %>').serialize();
         
         $.getJSON(pfxURL.staticVar + "/Store/Save", queryString, function(data) {
                    
                    if( data.Has_Error )
                    {
                        $('#CodeError').html(data.CodeError );
                        $('#StoreError').html(data.StoreError);
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
                        alert("Store has been saved");
                        $('#<%= UIStore.dlgStore.ToString() %>').dialog('close'); 
                        GetList(lastpage );
                    }
                    
                });
    
    
    }
    
    
    
    function OnEdit(id) {
    
     ae_popup('<%= UIStore.dlgStore.ToString() %>', 650, 500, 'Store', true, 'center', true,
        { "Save": function() { OnSave(); }, "Cancel": function() { $(this).dialog('close'); } },
        false);
     lpf<%= UIStore.dlgStore.ToString() %> = true;

     $.get(pfxURL.staticVar + "/Store/Edit/" + id ,
            EditStore
            );
        
    }
    
    
    function EditStore(data) {

        lpf<%= UIStore.dlgStore.ToString() %> = null;
        $("#<%= UIStore.dlgStore.ToString() %>").html(data);
        jQuery('#<%= UIStore.dlgStore.ToString() %>').attr("Style", "width: 600px; min-height: 300px; height: 500px;");
        jQuery("#<%= UIStore.dlgStore.ToString() %>").dialog('open');
        jQuery("#<%= UIStore.dlgStore.ToString() %> form input:visible:first").focus();
        SetAddress();  
    }
    
    
    
    function OnDelete(codeSLSP,SalesRepCode,Territory )
    {
         var str = codeSLSP + "/" + SalesRepCode + "/" + Territory; 
       
         $.getJSON( pfxURL.staticVar + "/Store/Delete/" + str , "", function(data) {
                    if( data.Has_Error )
                    {
                       
                    }
                    else
                    {
                        alert("Store Has been deleted");
                        GetList(lastpage );
                    }
                    
                });
    
    
    }
    
    
       
jQuery(document).ready(function() {
    pfxURL.staticVar = '<%= WebConfigurationManager.AppSettings["GSite"]  %>';
    GetList(1);
});
    
    
    

</script>
  </asp:Content> 