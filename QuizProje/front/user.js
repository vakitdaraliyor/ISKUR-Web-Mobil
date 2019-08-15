$(document).ready(function(){

    txtUsername = $('#txtUsername');
    txtPassword = $('#txtPassword');
    btnAddUser = $('#btnAddUser');
    tblUserScore = $('#tblUserScore');
    
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

    $.ajax({
        url: "http://localhost:3000/userScore",
        type: "GET",
        cache: false,
        async: false,
        success: function(data){
            console.log(data);
            tblUserScore.append("<thead><tr>" +
                                "<th>#</th>" + 
                                "<th>Username</th>" + 
                                "<th>Score</th>" +
                                "</tr></thead><tbody id=\"tBody\">"
                                )

            $.each(data, function(key, value){
                tblUserScore.append("<tr><td>" + value.user_id + "</td>" +
                                    "<td>" + value.username + "</td>" +
                                    "<td>" + value.score + "</td></tr>")
            })

            tblUserScore.append("</tbody>")
        }
    })
})