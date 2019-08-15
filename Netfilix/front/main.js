/*document.addEventListener('DOMContentLoaded', function() {
    var elems = document.querySelectorAll('.carousel');
    var instances = M.Carousel.init(elems, options);
});*/

  
// Or with jQuery
$(document).ready(function(){
    
    // Corousel baslatan funciton
    function initializeCarosel(){
        $('.carousel').carousel(
            {
                numVisible: 5, // slide ta gozuken sayisi
                onCycleTo: function(slide){
                    $('#image').attr("src", slide.firstElementChild.src)
                    console.log(slide.firstElementChild.id);
                    getDescription(slide.firstElementChild.id);
                }
            }
        );
    }

    function getDescription(id){
        $.ajax({
            url: "http://localhost:3000/getDescription?picture_id="+id,
            type: "GET",
            cache: false,
            async: false,
            success: function(data){
                console.log(data);
                $('#description').empty();
                $('#description').text(data[0].description);
            }
        })
    }

    // -------------------------------------------------------------
    // Imageleri alip carousel e yerlestiriyoruz
    // Daha sonra carousel i calistiriyoruz
    // -------------------------------------------------------------
    $.ajax({
        url: "http://localhost:3000/getFilmInfos",
        type: "GET",
        cache: false,
        async: false,
        success: function(data){
            console.log(data)
            $.each(data, function(key, value){
                $('#car').append('<a class="carousel-item"><img id='+ value.picture_id +' src=' + value.picture_name + '></a>');
            })
            initializeCarosel();
        }
    })

    // -------------------------------------------------------------
    // Carousel de tiklanan image i ust div deki alana gonderdik
    // -------------------------------------------------------------
    /*$("img").click(function(){
        console.log($(this).attr("src"))
        $("#image").attr("src", $(this).attr("src"));

    });*/

});