$(document).ready(function(){

    txtUsername = $('#txtUsername');
    txtPassword = $('#txtPassword');
    btnAddUser = $('#btnAddUser');
    
    function addUser(u, p){
        $.ajax({
            url: "http://localhost:3000/addUser",
            type: "POST",
            cache: false,
            async: false,
            data: {
                username: u,
                password: p
            },
            success: function(data){
                console.log(data);
            }
        })
    }

    btnAddUser.click(function(){
        addUser(txtUsername.val(), txtPassword.val());
    })
})