$(document).ready(function(){
    // $('#searchLive').hide();  // Sayfa yüklendiğinde searchLive textbox ını gizler

    // selection da seçtiğimiz item i alert olarak ekrana yazar
    $('#selSection').change(function(){
        tabloDoldur($('#selSection').val());
    })

    function tabloDoldur(txtOyuncu){

        // $('#searchLive').show(); // click eventi başladıgında searchLive textbox ını göster
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
            url: "https://api.tvmaze.com/singlesearch/shows?q=" +txtOyuncu, // singlesearch dizi getiriyoruz
            type: "GET",
            cache: false,
            success: function(data){                    
                console.log(data)                
                $.ajax({
                    url: "https://api.tvmaze.com/shows/" + data.id + "/cast", // dizi oyuncularını getiriyoruz
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
        $('#selSection').append("<option>" + $('#txtOyuncu').val() + "</option>");

    }
    
    // -------------------- Dizi oyuncularını tabloya doldurma --------------------
    
    $('#btnOyuncularGetir').click(function(){

        // Butona tıklandığında h4 tag i içindeki Recent Search yazısı da yüklenir
        $('#recentSearch').show();
        $('#selSection').show();
        $('#searchButton').show();     
        
        txtOyuncu = $('#txtOyuncu').val();

        tabloDoldur(txtOyuncu);

    })  
    
    // -------------------- SearchLive --------------------

    $("#searchLive").on("keyup", function(){
        var value = $(this).val().toLowerCase();
        $("#tBody tr").filter(function(){
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        })
    });

    // -------------------- Arama kutusunu yavaşça açıp kapatmaya yarar --------------------

    $('#flip').click(function(){
        $('#searchLive').slideToggle("slow");
    })

    $('#searchButton').click(function(){
        console.log($('#selSection').val())
    })

});