$(document).ready(function(){

    var score=0;
    soruGetir();

    //jservis.io/api/random

    var question
    var correctAnswer;
    var wrongAnswer;
    var dataID;
    var totalQuestion;

    function soruGetir(){

        $('#question').empty();        
        
        $.ajax({
            url: "http://jservice.io/api/random",
            type: "GET",
            cashe: false,
            async: false,
            success: function(data1){
                console.log(data1)
                $('#question').append(data1[0].question);
                question = data1[0].question;
                correctAnswer = data1[0].answer;
                dataID = data1[0].id;
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
    
    

    $('#answer1').click(function(){
        $('#score').empty();
        if(correctAnswer == $('#answer1').text()){
            score++;
            $('#correctAnswers').append("<h6>Question</h6>" + question + "<br>" + "<h6>Answer</h6>" + correctAnswer + "<hr>");           
        }
        $('#score').append("Score:"+score);
        soruGetir();
    })   

    $('#answer2').click(function(){
        $('#score').empty();
        if(correctAnswer == $('#answer2').text()){
            score++;           
        }
        $('#score').append("Score:"+score);
        soruGetir();
    })    

    if(totalQuestion > 15){
        $('#correctAnswers').show();
    }

})