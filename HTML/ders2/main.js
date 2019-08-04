$(document).ready(function(){

    $('#addUser').click(function(){
        $('#ogrenciTable').append("<tr>" +
                                  "<td>" + $('#fname').val() + "</td>" +
                                  "<td>" + $('#lname').val() + "</td>" + 
                                  "<td>" + $('#age').val() + "</td>" + 
                                  "</tr>")
    })

    /*$.ajax({
        url: "https://api.tvmaze.com/singlesearch/shows?q=girls",
        type: "GET",
        cache: false,
        success: function(data){
            console.log(data);            

        }
    });*/  

    // ------------------------- Buton a basıldıgında textbox a girilen dizi adına göre JSON döner -------------------------
    // -------------------- single search yaptık --------------------
    $('#btnDiziGetir').click(function(){
        
        $.ajax({
            url: "https://api.tvmaze.com/singlesearch/shows?q="+$('#diziAdı').val(),
            type: "GET",
            cache: false,
            success: function(data){
                console.log(data);
                image = data.image.medium;
                $('#diziImage').append("<div style='width:47%; float: left; margin: 5px'> <img src=" + image + ">" +
                                       "<br>" + "<strong>" + data.genres + "</strong>" + 
                                       "<br>" + "Country: " + data.network.country.name + 
                                       "<br>" +data.summary + "</div>");                      
            }
        });  
    })

    // -------------------- multi search yaptık --------------------
    $('#btnDizileriGetir').click(function(){
        $.ajax({
            url: "https://api.tvmaze.com/search/shows?q=" + $('#diziArama').val(),
            type: "GET",
            cache: false,
            success: function(data){
                console.log(data);
                $.each(data, function(key, value){
                    $('#diziTablo').append("<tr>" +
                                           "<td>" + "<img src = " + value.show.image.medium + "></td>" +
                                           "<td>" + value.show.name + "</td>" + 
                                           "<td>" + value.score + "</td>" + 
                                           "<td>" + value.show.genres + "</td>" + 
                                           "<td>" + value.show.summary + "</td>" +                                             
                                           "<td>" + "<a href=" + value.show.url + ">Link</a></td>" + 
                                           "</tr>")
                })
            }
        })
    })

    // -------------------- Dizi oyuncularını getirdik --------------------
    
    $('#btnOyuncularGetir').click(function(){
        $.ajax({
            url: "https://api.tvmaze.com/singlesearch/shows?q=" + $('#txtOyuncu').val(),
            type: "GET",
            cache: false,
            success: function(data){                    
                console.log(data)
                $.ajax({
                    url: "https://api.tvmaze.com/shows/" + data.id + "/cast",
                    type: "GET",
                    cache: false,
                    success: function(data){
                        console.log(data);
                        $.each(data, function(key, value){
                            $('#oyuncularTablo').append("<tr>" +
                                                        "<td>" + "<img style='width: 100px; height: 100px' src = " + value.person.image.medium + "></td>" +
                                                        "<td>" + value.person.name + "</td>" + 
                                                        "<td>" + value.person.country.name + "</td>" + 
                                                        "<td>" + value.character.name + "</td>" + 
                                                        "</tr>")
                        })
                    }
                })                
            }
        })
    })

    // -------------------- Textbox a yazarken aynı anda parag. yazar -------------------- 

    $('#keyup').keyup(function(){
        $('#key').text($('#keyup').val())
    })
    

});