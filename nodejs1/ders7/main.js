$( document ).ready(function(){

    $.ajax({
        url:"http://localhost:3000/home",
        type:"GET",
        cache: false,
        async: false,
        success: function(data){
            console.log(data);
        }
    })

    // Bütün actor leri getirir
    $.ajax({
        url:"http://localhost:3000/actors",
        type:"GET",
        cache: false,
        async: false,
        success: function(data){
            console.log("Aktörler");
            console.log(data);
        }
    })

    $.ajax({
        url:"http://localhost:3000/kategori",
        type:"GET",
        cache: false,
        async: false,
        success: function(data){
            console.log("Kategoriler");
            console.log(data);
        }
    })

    // specific actor getirir
    $.ajax({
        url:"http://localhost:3000/actor?id=2",
        type:"GET",
        cache: false,
        async: false,
        success: function(data){
            console.log("Id=2 olan actor")
            console.log(data);
        }
    })

});