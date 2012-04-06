

function isNumberKey(evt, target) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    var isnum = true;
    if (!evt.ctrlKey && charCode > 31 && (charCode < 48 || charCode > 57)) {
        isnum = false;
        if (evt.which)
            evt.preventDefault();
        else
            evt.returnValue = false;
    }
    return fireDefault(evt, target) && isnum;
}

function fireDefault(evt, target) {

    var charCode = (evt.which) ? evt.which : evt.keyCode;
    if (charCode == 13 && target != undefined) {
        evt.cancelBubble = true;
        if (evt.stopPropagation) {
            evt.stopPropagation();
            evt.preventDefault();
        }
        var btn = document.getElementById(target);
        btn.click();
        return false;
    }
    return true;
}


function SetAddress() {


    geocoder = new google.maps.Geocoder();
    var input = document.getElementById('txtAddress');
    var autocomplete = new google.maps.places.Autocomplete(input);
    google.maps.event.addListener(autocomplete, 'place_changed', function() {

        var place = autocomplete.getPlace();

        var startLatitude = place.geometry.location.lat();
        var startLongitude = place.geometry.location.lng();


        document.getElementById("hidLatitude").value = startLatitude;
        document.getElementById("hidLongitude").value = startLongitude;

        var address = '';
        if (place.address_components) {
            address = [(place.address_components[0] &&
                        place.address_components[0].short_name || ''),
                       (place.address_components[1] &&
                        place.address_components[1].short_name || ''),
                       (place.address_components[2] &&
                        place.address_components[2].short_name || '')
                      ].join(' ');
        }

        $("#txtFullAddress").val(place.formatted_address);

        var imagelink = "http://maps.google.com/maps/api/staticmap?center=" + startLatitude + "," + startLongitude + "&zoom=15&size=250x180&maptype=roadmap&" +
         "markers=size:mid%7Ccolor:green%7Clabel:D%7C" + startLatitude + "," + startLongitude + "&sensor=false";
        imagelink = "<img border='0' src=" + imagelink + " alt='image could not be found' />";
        $("#MapImage").html(imagelink);

        var arr = place.address_components;


        $("#txtStreetName").val('');
        $("#txtCountry").val('');
        $("#txtState").val('');
        $("#txtCity").val('');
        $("#txtZipCode").val('');
        $("#txtStreetNo").val('');


        var holder = "";
        var type = "";
        for (var i = 0; i < arr.length; i++) {
            type = arr[i].types;


            if (type.indexOf("street_address") != -1) {
                $("#txtStreetName").val(arr[i].long_name);
            }

            if (type.indexOf("country") != -1) {
                $("#txtCountry").val(arr[i].long_name);
            }

            if (type.indexOf("administrative_area_level_2") != -1) {
                $("#txtCounty").val(arr[i].long_name);
            }

            if (type.indexOf("locality") != -1) {
                $("#txtCity").val(arr[i].short_name);
            }

            if (type.indexOf("administrative_area_level_1") != -1) {
                $("#txtState").val(arr[i].long_name);
            }

            if (type.indexOf("administrative_area_level_3") != -1) {
                //alert(type + "     " + arr[i].long_name + "   " + arr[i].short_name);
            }

            if (type.indexOf("postal_code") != -1) {
                $("#txtZipCode").val(arr[i].long_name);
            }

            if (type.indexOf("street_number") != -1) {
                $("#txtStreetNo").val(arr[i].long_name);
            }



        }

    });
    GetMap();
}


function GetMap() {
    if ($("#hidState").val() != "3") {
        var imagelink = "http://maps.google.com/maps/api/staticmap?center=" + $("#hidLatitude").val() + "," + $("#hidLongitude").val() + "&zoom=15&size=250x180&maptype=roadmap&" +
                 "markers=size:mid%7Ccolor:green%7Clabel:D%7C" + $("#hidLatitude").val() + "," + $("#hidLongitude").val() + "&sensor=false";
        imagelink = "<img border='0' src=" + imagelink + " alt='image could not be found' />";
        $("#MapImage").html(imagelink);
    }
}



function initialize(startZoom) {
    //centerLatitude, centerLongitude,
    //center: new google.maps.LatLng(centerLatitude, centerLongitude),
    centerLatitude = 33.8592430000;
    centerLongitude = -118.0232100000;

    startZoom = 10;
    opts = null;
    opts = {
        zoom: startZoom,
        center: new google.maps.LatLng(centerLatitude, centerLongitude),
        scrollwheel: true,
        streetViewControl: false,
        disableDefaultUI: true,
        navigationControl: true,
        noClear: false,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    }






    if (map == null) {


        map = null;
        map = new google.maps.Map(document.getElementById("map"), opts);
        map.getMapType = google.maps.MapTypeId.ROADMAP;
        map.setOptions({ styles: pinkParksStyles });



        batch = [];

        for (i = 0; i < markers.length; i++) {
            if (markers[i] != null) {
                batch.push(createMarker(markers[i]));
            }
        }




        bounds = null;
        bounds = new google.maps.LatLngBounds();
        for (var i = 0; i < markers.length; i++) {
            if (markers[i] != null) {
                bounds.extend(new google.maps.LatLng(markers[i].latitude, markers[i].longitude));
            }
        }

        map.fitBounds(bounds);


    }
    else {



        deleteOverlays();
        for (i = 0; i < markers.length; i++) {
            if (markers[i] != null) {
                batch.push(createMarker(markers[i]));
            }
        }


        bounds = null;
        bounds = new google.maps.LatLngBounds();

        var count = 0;
        var detail = "";

        for (var i = 0; i < markers.length; i++) {
            //alert(markers[i].title);
            if (markers[i].title != null) {
                bounds.extend(new google.maps.LatLng(markers[i].latitude, markers[i].longitude));
                detail += " [" + markers[i].latitude + "," + markers[i].longitude + " ] ";
                count++;
            }
        }
        map.fitBounds(bounds);
    }
}






var markers;
var map;
var bounds;
var opts;
var listener;
var markersArray = [];
var geocoder;
var pinkParksStyles = [
    {
        featureType: "water",
        elementType: "geometry",
        stylers: [
      { hue: "#53458A" },
      { gamma: 0.5 },
      { visibility: "on" }
    ]
    }
  ,
     {
         featureType: "road",
         elementType: "geometry",
         stylers: [
      { hue: "#00c3ff" },
      { visibility: "on" }
    ]
     }
   ,
   {
       featureType: "administrative",
       elementType: "geometry",
       stylers: [
      { hue: "#999999" },
      { visibility: "on" }
    ]
   },
     {
         featureType: "landscape",
         elementType: "geometry",
         stylers: [
      { hue: "#ffffff" },
      { visibility: "on" }
    ]
     },
     {
         featureType: "poi",
         elementType: "geometry",
         stylers: [
      { hue: "#00ffaa" },
      { visibility: "on" }
    ]
     }

];







function createMarker(pointData) {
    var marker = new google.maps.Marker({
        position: new google.maps.LatLng(pointData.latitude, pointData.longitude),
        map: map,
        title: pointData.title,
        clickable: true,
        icon: pointData.icon,
        zIndex: pointData.zIndex
    });



    if (marker.getIcon() != undefined) {

        var aPosition = marker.getIcon().indexOf("home");
        if (aPosition < 0) {
            google.maps.event.addListener(marker, 'mouseover', function() {
                //this.setIcon(this.getIcon() + "&Col=yellow")
                this.setIcon(mutateImageLink(this.getIcon(), true));
                this.setZIndex(5);
            });


            google.maps.event.addListener(marker, 'mouseout', function() {
                //this.setIcon(this.getIcon().replace("&Col=yellow", ""))
                this.setIcon(mutateImageLink(this.getIcon(), false));
                this.setZIndex(1);
            });

            google.maps.event.addListener(marker, 'click', function() {

            });
        }
    }
    marker.setMap(map);
    markersArray.push(marker);
    return marker;
}






// Deletes all markers in the array by removing references to them
function deleteOverlays() {

    for (i = 0; i < markersArray.length; i++) {
        if (markersArray[i] != null) {
            markersArray[i].setMap(null);
        }
    }
    markersArray.length = 0;

}

