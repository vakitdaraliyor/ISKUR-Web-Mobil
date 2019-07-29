$(document).ready(function(){

    var number = 1;

    $("#ImageButton").click(function(){
        if((number %2) == 0){
            $('#myImage').attr('src', 'kalp.png');
            $('#ImageButton').text("Dünya");           
        }
        if((number %2) != 0){
            $('#myImage').attr('src', 'home.png');
            $('#ImageButton').text("Kalp");
        }
        number = number + 1;
    })

    $("#LinkButton").click(function(){
        if((number %2) == 0){
            $('#myLink').attr('href', 'https://www.google.com');
            $('#myLink').text("Google");
        }
        if((number %2) != 0){
            $('#myLink').attr('href', 'https://www.w3schools.com/html/');
            $('#myLink').text("W3School");
        }
        number = number + 1;
    })

    $('#firstItem').click(function(){
        $('#firstItem').text("Süt");
    })

    $('#firstItem').dblclick(function(){
        $('#firstItem').text("Çay");
    })

// ------------------------------ Tabloya yeni satır ekleme ------------------------------
    $('#tableButton').click(function(){
        $('#ogrenci').append("<tr><td>Omer</td><td>MİNTEMUR</td><td>48</td></tr>");
        $('#ogrenci').append("<tr><td>Mustafa</td><td>AKAY</td><td>26</td></tr>");
    })
    
    var studentsName = ["Ramazan", "Osman", "Mustafa",]
    var studentsSurname = ["MERCAN", "SAVAŞ", "AKAY"]
    var studentsAge = ["21", "26", "28"]
    var studentsNumber = ["1", "2", "3"]

    var count = 0;
    
    
    $('#tableButton2').click(function(){
        if(count > studentsName.length - 1){

        }
        else{
            $('#ogrenciTable').append("<tr><td>"+studentsName[count]+"</td>" +
            "<td>"+studentsSurname[count]+"</td>" +
            "<td>"+studentsAge[count]+"</td>" + 
            "<td>"+studentsNumber[count]+"</td></tr>");

            count++;
        }            
    })
    
    // ---------------------- JSON verileri ile tablo doldurma ----------------------

    $.ajax({
        url: "https://get.geojs.io/v1/ip/country.json",
        type: "GET",
        cache: false,
        success: function(data){
            console.log(data);

            $('#tableButton3').click(function(){
                
                $('#countryTable').append("<tr><td>"+data["name"]+"</td>" +
                "<td>"+data["country"]+"</td>" +
                "<td>"+data["ip"]+"</td></tr>");     
                                               
            })

        }
    });    
  
});

