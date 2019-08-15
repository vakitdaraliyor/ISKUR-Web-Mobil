$(document).ready(function(){

    // --------------------------------------------------------------------
    // Quiz blogu icindeki textbox ve buttonlar
    // --------------------------------------------------------------------
    var divQuiz = $('#divQuiz');
    divQuiz.hide();
    var question = $('#question');
    var btnAnswer1 = $('#answer1');
    var btnAnswer2 = $('#answer2');
    var btnAnswer3 = $('#answer3');
    var btnAnswer4 = $('#answer4');

    var correct; // Dogru cevap icin tanimlanmis degisken

    // --------------------------------------------------------------------
    // Login blogu icindeki textbox ve buttonlar
    // --------------------------------------------------------------------
    var divLogin = $('#divLogin');
    var txtLoginUsername = $('#txtLoginUsername');
    var txtLoginPassword = $('#txtLoginPassword');
    var btnLogin = $('#btnLogin');

    // Score blogu icindekiler
    var divScore = $('#divScore');
    var scoreAlert = $('#score');
    divScore.hide();
    var score=0; // Score icin tanimlanmis degisken. Her dogru cevapta 1 artar

    // --------------------------------------------------------------------
    // Kullanici adi ve sifre dogru ise soru getirir.
    // Kullanicinin kim oldugunu sakla(degiskene ata).Score u kaydetmek icin
    // --------------------------------------------------------------------
    var loginedUser;
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
                    loginedUser = loginU;
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

    // --------------------------------------------------------------------
    // Login butonuna tiklandiginda login methodu cagrilarak giris yapilir
    // --------------------------------------------------------------------
    btnLogin.click(function(){
        login(txtLoginUsername.val(), txtLoginPassword.val());
    })

    var askedQuestion = 0;
    var numberOfQuestion;
    $.ajax({
        url:"http://localhost:3000/numberOfQuestion",
        type: "GET",
        cache: false,
        async: false,
        success: function(data){
            numberOfQuestion = data[0].C;
            console.log(numberOfQuestion);
        }
    })
    

    // --------------------------------------------------------------------
    // Server dan soru getirir ve ilgili alanlari gelen veri ile doldurur
    // --------------------------------------------------------------------
    function getQuestion(){
        askedQuestion++;
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
                console.log(data);
                correct = data[0].correct;
                question.text(data[0].question);
                btnAnswer1.text(data[0].answer1);
                btnAnswer2.text(data[0].answer2);
                btnAnswer3.text(data[0].answer3);
                btnAnswer4.text(data[0].answer4);                         
            }
        })
    }

    // --------------------------------------------------------------------
    // Tiklanan Button Dogru Cevap Mı?
    // --------------------------------------------------------------------
    function check(obj){
        // console.log(obj.text());
        if(obj.text() == correct){
            score++;            
            if(askedQuestion != numberOfQuestion){
                $('#success').show();
                btnAnswer1.attr("disabled", true);
                btnAnswer2.attr("disabled", true);
                btnAnswer3.attr("disabled", true);
                btnAnswer4.attr("disabled", true);
                $('#btnNewQuestion').show();
            }
            else{
                quizFinished();
            }
        }
        else{
            if(askedQuestion != numberOfQuestion){
                $('#danger').show();
                btnAnswer1.attr("disabled", true);
                btnAnswer2.attr("disabled", true);
                btnAnswer3.attr("disabled", true);
                btnAnswer4.attr("disabled", true);
                $('#btnNewQuestion').show();
            }
            else{
                quizFinished();
            }
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
        getQuestion();
        $('#success').hide();
        $('#danger').hide();
        $(this).hide();
    })
    
    function quizFinished(){
        divQuiz.hide();
        btnAnswer1.hide();
        btnAnswer2.hide();
        btnAnswer3.hide();
        btnAnswer4.hide();
        scoreAlert.append("Quiz Finished! Your Score is: " + score);
        divScore.show();
        scoreAlert.show();
        sendScore(loginedUser, score);
    }

    function sendScore(userN, scr){
        $.ajax({
            url:"http://localhost:3000/sendScore",
            type: "POST",
            cache: false,
            async: false,
            data:{
                username: userN,
                score: scr
            },
            success: function(data){
                window.alert(data);
            }
        })
    }

})