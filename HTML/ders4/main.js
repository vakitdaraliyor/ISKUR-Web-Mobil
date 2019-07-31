$(document).ready(function(){   

    
    // -------------------- Dizi oyuncularını getirdik --------------------
    
    $('#btnOyuncularGetir').click(function(){

        $('#oyuncularTablo').empty(); // Her seferinde tabloyu boşaltır

        // Tablo başlıklarını bir kere oluşturduk
        $('#oyuncularTablo').append("<thead>"+
                                        "<tr>"+
                                            "<th>Actor Image</th>"+
                                            "<th>Actor Name</th>"+
                                            "<th>Country</th>"+
                                            "<th>Birthday</th>"+
                                            "<th>Character Name</th>"+
                                            "<th>URL</th>"+
                                        "</tr>" +
                                        "<tbody id=\"tBody\">" + 
                                        "</tbody>"+
                                    "</thead>"
                                    )

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
                            $('#tBody').append("<tr>" +
                                                            "<td>" + "<img style='width: 100px; height: 100px' src = " + value.person.image.medium + "></td>" +
                                                            "<td>" + value.person.name + "</td>" + 
                                                            "<td>" + value.person.country.name + "</td>" + 
                                                            "<td>" + value.person.birthday + "</td>" + 
                                                            "<td>" + value.character.name + "</td>" + 
                                                            "<td>" + "<a href=" + value.person._links.self.href+">Link</a>" + "</td>" + 
                                                        "</tr>" 
                                                        )
                        })
                    }
                })                
            }
        })
        $('#yapılanAramalar').append($('#txtOyuncu').val() + "<br>");

    })  
    
    // -------------------- SearchLive --------------------

    $("#searchLive").on("keyup", function(){
        var value = $(this).val().toLowerCase();
        $("#tBody tr").filter(function(){
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        })
    });

});