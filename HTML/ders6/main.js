$(document).ready(function(){

    form = $('#form');
    txtName = $('#txtName');
    txtSurname = $('#txtSurname');
    txtPassword = $('#txtPassword');
    txtEmail = $('#txtEmail');
    txtOccupation = $('#txtOccupation');
    selCountry = $('#selSection');
    btnSend = $('#btnSend');
    btnSend.attr("disabled", false);

    var eMails=[];
    
    function isEmptyAll(){
        if(Boolean(txtName.val() != "") == false){
            return false;
        }
        else if(Boolean(txtSurname.val() != "") == false){
            return false;
        }
        else if(Boolean(txtPassword.val() != "") == false){
            return false;
        }
        else if(Boolean(txtEmail.val() != "") == false){
            return false;
        }
        else if(Boolean(txtOccupation.val() != "") == false){
            return false;
        }
        else if(Boolean(selCountry.val() != "") == false){
            return false;
        }
        else{
            return true;
        }
    }

    // Form içinde boş alan varsa button u aktif etme
    /*form.focusout(function(){
        if(isEmptyAll() == true){
            btnSend.attr("disabled", false);
        }
        else{
            btnSend.attr("disabled", true);
        }
    })*/

    // Hangi alanı doldurduysak ondan bir sonraki alanı açar
    function check(){
        if($(this).val() != "" && $(this).attr('id') == "txtName"){
            $('#divSurname').show();
        }
        if($(this).val() != "" && $(this).attr('id') == "txtSurname"){
            $('#divPassword').show();
        }
        else if($(this).val() != "" && $(this).attr('id') == "txtPassword"){
            $('#divEmail').show();
        }
        else if($(this).val() != "" && $(this).attr('id') == "txtEmail"){
            $('#divOccupation').show();
        }
        else if($(this).val() != "" && $(this).attr('id') == "txtOccupation"){
            $('#divSelCountry').show();
        }
    }

    // Alan dolduktan sonra bir sonraki alanı açar
    txtName.focusout(check);
    txtSurname.focusout(check);
    txtPassword.focusout(check);
    txtEmail.focusout(check);
    txtOccupation.focusout(check);

    btnSend.click(function(){
        $('#userInfos').empty();

        if(isEmptyAll() == true){
            if(eMails.length == 0){
                $('#userInfos').append("<p>Name: " + txtName.val() + "</p>" + 
                                       "<p>Surname: " + txtSurname.val() + "</p>" + 
                                       "<p>Email: " + txtEmail.val() + "</p>" + 
                                       "<p>Occupation: " + txtOccupation.val() + "</p>" + 
                                       "<p> Country: " + selCountry.val() + "</p><hr>")
                eMails.push(txtEmail.val());
            }
            else if(eMails.includes(txtEmail.val()) == false){
                $('#userInfos').append("<p>Name: " + txtName.val() + "</p>" + 
                                       "<p>Surname: " + txtSurname.val() + "</p>" + 
                                       "<p>Email: " + txtEmail.val() + "</p>" + 
                                       "<p>Occupation: " + txtOccupation.val() + "</p>" + 
                                       "<p> Country: " + selCountry.val() + "</p><hr>")
                eMails.push(txtEmail.val());
            }
            else{
                $('#userInfos').append("<p>Email already exist!</p>")
            }            
        }
        else{            
            $('#userInfos').append("<p>Eksik Girdiniz!</p>")
        }   
               
    })

})