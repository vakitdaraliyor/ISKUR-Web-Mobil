$(document).ready(function(){

    var question = $('#question');
    var btnAnswer1 = $('#answer1');
    var btnAnswer2 = $('#answer2');
    var btnAnswer3 = $('#answer3');
    var btnAnswer4 = $('#answer4');

    var correct;

    getQuestion();

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

    // Tiklanan Button Dogru Cevap Mı?
    function check(obj){
        // console.log(obj.text());
        if(obj.text() == correct){
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
        getQuestion();
        $('#success').hide();
        $('#danger').hide();
        $(this).hide();
    })

})