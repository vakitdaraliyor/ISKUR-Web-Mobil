$(document).ready(function(){

    var score=0;
    var question
    var correctAnswer;
    var wrongAnswer;
    var dataID;
    var totalQuestion=1;

    soruGetir();

    // jservis.io/api/random  --> API adres   
    // ---------------------------- Soru Getirme Fonksiyonu ----------------------------
    function soruGetir(){

        $('#answer1').css("background-color", "")
        $('#answer2').css("background-color", "")
        $('#question').empty();        
        
        $.ajax({
            url: "http://jservice.io/api/random",
            type: "GET",
            cashe: false,
            async: false,
            success: function(data1){
                console.log(data1)            
    
                question = data1[0].question;
                correctAnswer = data1[0].answer;
                dataID = data1[0].id;
                $('#question').append("<h5 align=\"center\">" + totalQuestion + ") " + question + "</h5><br>");                  
                totalQuestion++;
                
                // console.log(correctAnswer);
                // console.log(dataID);     
            }
        })
    
        $.ajax({
            url: "http://jservice.io/api/random",
            type: "GET",
            cashe: false,
            async: false,
            success: function(data2){
                // console.log(data2)
                wrongAnswer = data2[0].answer;           
            }
        })

        if((dataID %2) == 0){
            $('#answer1').text(correctAnswer);
            $('#answer2').text(wrongAnswer);
        }
        else{
            $('#answer1').text(wrongAnswer);
            $('#answer2').text(correctAnswer);
        }
    } 

    // ---------------------------- Sonuçları getiren fonksiyon ----------------------------
    function finish(){
        $('#score').show().append("Correct answers:" + score + "  /  Wrong answers:" + (totalQuestion-score-1));
        $('#correctAnswers').show();
        $('#question').hide();
        $('#answer1').hide();
        $('#answer2').hide();     
        $('#info').hide();       
        $('#resultHeader').show();
        $('#btnRetry').show();
    }
    
    // ---------------------------- Buttonlara tıklandığında gerçekleşen olaylar ----------------------------

    $('#answer1').click(function(){
        $('#score').empty();
        if(correctAnswer == $('#answer1').text()){            
            score++;
            $('#correctAnswers').append("<h6>Question</h6>" + question + "<br>" + "<h6>Answer</h6>" + correctAnswer + "<hr>");                                   
        }
        
        if(totalQuestion <= 15){
            soruGetir();
        }
        else{
            finish();
        }
        
    })   

    $('#answer2').click(function(){
        $('#score').empty();
        if(correctAnswer == $('#answer2').text()){
            score++;
            $('#correctAnswers').append("<h6>Question</h6>" + question + "<br>" + "<h6>Answer</h6>" + correctAnswer + "<hr>");                     
        }     
           
        if(totalQuestion < 15){
            soruGetir();
        }
        else{
            finish();
        }
    })  

    $('#btnRetry').click(function(){
        $('#question').show();
        $('#answer1').show();
        $('#answer2').show(); 
        $('#correctAnswers').hide();
        $('#score').hide();
        $('#resultHeader').hide();
        $(this).hide();
        totalQuestion=1;
        score=0;
        soruGetir();
    })

})