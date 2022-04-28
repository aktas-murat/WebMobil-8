console.log("4.js dosyası çalıştı.");

//GeoLocation

var initMap = () => {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    } else {
        console.log("Geolocation is not supported by this browser.");
    }
}

var showPosition = (position) => {
    console.log(position);
    var pos={
        lat:position.coords.latitude,
        lng:position.coords.longitude
    };
    var mapDiv=document.getElementById('map');
    var map =new google.maps.Map(mapDiv,{
        center:pos,
        zoom:18
    });
    var marker=new google.maps.Marker({
        position:pos,
        map:map
    });
     
    map.addListener('click',(e)=>{
        var posClick={
            lat:e.latLng.lat(),
            lng:e.latLng.lng()
        };
        //markerları temizle
        marker.setMap(null);
        //tıklanana konuma göre marker ekleme
        marker =new google.maps.Marker({
            position:posClick,
            map:map,
            title:'Clicked Location',
            animation:google.maps.Animation.DROP
        });
    });

}