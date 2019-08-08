$(document).ready(function(){

    $('#btnCalc').click(function(){
        var num1 = parseInt($('#number1').val());
        var num2 = parseInt($('#number2').val());
        var result=0;
        var option = $('#selSection').val();
        console.log(option);

        if(option == 1){
            result = num1+num2;
        }
        else if(option == 2){
            result = num1-num2;
        }
        else if(option == 3){
            result = num1*num2;
        }
        else if(option == 4){
            result = num1/num2;
        }
        $('#result').val(result);
    })

})