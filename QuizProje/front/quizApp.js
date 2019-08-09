$(document).ready(function(){

    // Quiz blogu icindeki textbox ve buttonlar
    var divQuiz = $('#divQuiz');
    divQuiz.hide();
    var question = $('#question');
    var btnAnswer1 = $('#answer1');
    var btnAnswer2 = $('#answer2');
    var btnAnswer3 = $('#answer3');
    var btnAnswer4 = $('#answer4');

    var correct;

    // Login blogu icindeki textbox ve buttonlar
    var divLogin = $('#divLogin');
    var txtLoginUsername = $('#txtLoginUsername');
    var txtLoginPassword = $('#txtLoginPassword');
    var btnLogin = $('#btnLogin');

    // Score blogu icindekiler
    var divScore = $('#divScore');
    divScore.hide();
    var score=0;

    var questionState;

    function login(loginU, loginP){
        $.ajax({
            url:"http://localhost:3000/login",
            type: "POST",
            cache: false,
            async: false,
            data:{
                username: loginU,
                password: loginP
            },
            success: function(data){
                console.log(data);
                if(data == "Successfull"){
                    getQuestion();
                    divQuiz.show();
                    divLogin.hide();
                }
                else{
                    $('#dangerLogin').show();
                }
            } 
        })
    }

    function getQuestion(){
        question.empty();
        btnAnswer1.attr("disabled", false);
        btnAnswer2.attr("disabled", false);
        btnAnswer3.attr("disabled", false);
        btnAnswer4.attr("disabled", false);

        $.ajax({
            url:"http://localhost:3000/getQuestion",
            type: "GET",
            cache: false,
            async: false,
            success: function(data){
                if(data != "No Question" || data != "New Question"){
                    console.log(data);
                    correct = data[0].correct;
                    question.text(data[0].question);
                    btnAnswer1.text(data[0].answer1);
                    btnAnswer2.text(data[0].answer2);
                    btnAnswer3.text(data[0].answer3);
                    btnAnswer4.text(data[0].answer4);
                }
                else if(data == "New Question"){
                    getQuestion();
                }
                else if(data == "No Question"){
                    questionState = "No Question";
                }          
            }
        })
    }

    // Tiklanan Button Dogru Cevap Mı?
    function check(obj){
        // console.log(obj.text());
        if(obj.text() == correct){
            score++;
            $('#success').show();
            $('#btnNewQuestion').show();
            btnAnswer1.attr("disabled", true);
            btnAnswer2.attr("disabled", true);
            btnAnswer3.attr("disabled", true);
            btnAnswer4.attr("disabled", true);
        }
        else{
            $('#danger').show();
            $('#btnNewQuestion').show();
            btnAnswer1.attr("disabled", true);
            btnAnswer2.attr("disabled", true);
            btnAnswer3.attr("disabled", true);
            btnAnswer4.attr("disabled", true);
        }
    }

    btnAnswer1.click(function(){
        check($(this));
    })
    btnAnswer2.click(function(){
        check($(this));
    })
    btnAnswer3.click(function(){
        check($(this));
    })
    btnAnswer4.click(function(){
        check($(this));
    })

    $('#btnNewQuestion').click(function(){
        console.log(questionState);
        getQuestion();
        $('#success').hide();
        $('#danger').hide();
        $(this).hide();
    })

    btnLogin.click(function(){
        login(txtLoginUsername.val(), txtLoginPassword.val());
    })

})