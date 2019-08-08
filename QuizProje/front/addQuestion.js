$(document).ready(function(){

    form = $('#form');
    question = $('#txtQuestion');
    answer1 = $('#txtAnswer1');
    answer2 = $('#txtAnswer2');
    answer3 = $('#txtAnswer3');
    answer4 = $('#txtAnswer4');
    lblCorrect = $('#lblCorrect');
    selSection = $('#selSection');
    btnSend = $('#btnSend');

    //  Bos Alan Var Mi Kontrol Eder 
    function isEmpty(){
        if(question.val() == "" || answer1.val() == "" || answer2.val() == "" || answer3.val() == "" || answer4.val() == ""){
            return false;
        }
        else{
            return true;
        }
    }

    // Verileri Yolladigimiz Fonksiyon
    function sendQuestion(q, ans1, ans2, ans3, ans4, corct){
        $.ajax({
            type: "POST",
            url: "http://localhost:3000/sendQuestion",
            data: {
                question: q,
                answer1: ans1,
                answer2: ans2,
                answer3: ans3,
                answer4: ans4,
                correct: corct
            },
            success: function(data){
                window.alert(data);
            }
        })
    }

    // Textbox lari ve Select Menusunu Bosaltir
    function setEmpty(){
        question.val("");
        answer1.val("");
        answer2.val("");
        answer3.val("");
        answer4.val("");
        selSection.val("");
    }

    // Button ve Select Menusunu Gorunur Hale Getirir
    function showAreas(){
        selSection.show();
        btnSend.show();
        lblCorrect.show();
    }

    // Buton ve Select Menusunu Gorunmez Hale Getırır
    function hideAreas(){
        selSection.hide();
        btnSend.hide();
        lblCorrect.hide();
    }

    // Form Icinde Bos Alan Var Mi Kontrol Eder 
    // Butun Alanlar Doluysa Button u ve Select Menusunu Aktif Eder
    form.focusout(function(){
        console.log(isEmpty())
        if(isEmpty() == true){
            selSection.empty();

            $('#selSection').append("<option>" + answer1.val() + "</option>" +
                                    "<option>" + answer2.val() + "</option>" +
                                    "<option>" + answer3.val() + "</option>" +
                                    "<option>" + answer4.val() + "</option>")

            showAreas();
        }
        else{
            hideAreas();
        }
    })
    
    // Button a Tiklandiginda Ilgili Parametreleri Server a POST eder
    $('#btnSend').click(function(){
        var q = question.val();
        var a1 = answer1.val();
        var a2 = answer2.val();
        var a3 = answer3.val();
        var a4 = answer4.val();
        var correct = selSection.val();

        sendQuestion(q, a1, a2, a3, a4, correct);
        setEmpty();

        if(isEmpty() == true){
            showAreas();
        }
        else{
            hideAreas();
        }        
    })

    // ------------ Ikinci Yol ------------
    /*$('#btnSend').click(function(){
        var q = question.val();
        var a1 = answer1.val();
        var a2 = answer2.val();
        var a3 = answer3.val();
        var a4 = answer4.val();
        var correct = selSection.val();
        console.log(q)
        $.ajax({
            url:"http://localhost:3000/question?question="+q+"&answer1="+a1+"&answer2="+a2+"&answer3="+a3+"&answer4="+a4+"&correct="+correct,
            type:"POST",
            cache:false,
            async:false,
            success: function(data){
                console.log(data)
            }
        })
        setEmpty();
        if(isEmpty() == true){
            showAreas();
        }
        else{
            hideAreas();
        }
    })*/

})