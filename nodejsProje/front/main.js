$( document ).ready(function(){

    $('#actors').click(function(){

        $('#divBeginning').show();
        $('#divPagination').show();
        $('#divAdd').show();

        $.ajax({
            url: "http://localhost:3000/actors",
            type: "GET",
            cache: false,
            async: false,
            success: function(data){
                
                console.log(data[0]);
                console.log(Object.keys(data[0]).length);

                $('#putTable').append("<thead><tr>" + 
                                      "<th>" + "#" + "</th>" + 
                                      "<th>" + "First Name" + "</th>" +
                                      "<th>" + "Last Name" + "</th>" +
                                      "<th>" + "Last Update" + "</th>"
                )

                $('#putTable').append("</tr></thead><tbody id=\"tBody\">")

                $.each(data, function(key, value){
                    $('#putTable').append("<tr><td>" + value.actor_id + "</td>" +
                                          "<td>" + value.first_name + "</td>" +
                                          "<td>" + value.last_name + "</td>" + 
                                          "<td>" + value.last_update + "</td></tr>" 
                    )
                })

                $('#putTable').append("</tbody>")

            }
        })
    })

    var table = '#putTable'
    $('#maxRows').on('change', function(){
        $('.pagination').html('')
        var trnum=0;
        var maxRows = parseInt($(this).val())
        var totalRows = $(table + ' tbody tr').length
        $(table+' tr:gt(0)').each(function(){
            trnum++
            if(trnum > maxRows){
                $(this).hide();
            }
            if(trnum <= maxRows){
                $(this).show();
            }
        })
        if(totalRows > maxRows){
            var pagernum = Math.ceil(totalRows/maxRows)
            for(var i=1; i<=pagernum;){
                $('.pagination').append('<li data-page="' + i + '"><span class="btn btn-link">' + i++ + '</span>\</li>').show()

            }
        }
        $('.pagination li:first-child').addClass('active')
        $('.pagination li').on('click', function(){
            var pageNum = $(this).attr('data-page')
            var trIndex = 0;
            $('.pagination li').removeClass('active')
            $(this).addClass('active')
            $(table+' tr:gt(0)').each(function(){
                trIndex++
                if(trIndex > (maxRows*pageNum) || trIndex <= ((maxRows*pageNum) - maxRows)){
                    $(this).hide();
                }
                else{
                    $(this).show();
                }
            })
        })

    })

    $(function(){
        $('table tr:eq(0)').prepend('<th>ID</th>')
        var id = 0;
        $('table tr:gt(0)').each(function(){
            id++
            $(this).prepend('<td>' +id+ '</td>')
        })
    })

    // --------------------- Add Actor ---------------------
    $('#btnAdd').click(function(){
        var first_name = $('#txtFirstName').val();
        var last_name = $('#txtLastName').val();
        var last_update = $('#txtLastUpdate').val();
        $.ajax({
            url:"http://localhost:3000/actor?first_name="+first_name+"&last_name="+last_name,
            type:"GET",
            cache: false,
            async: false,
            success: function(data){
                console.log(data);
            }
        })
    })

    // --------------------- Live Search ---------------------
    $("#txtSearch").on("keyup", function(){
        var value = $(this).val().toLowerCase();
        $("#tBody tr").filter(function(){
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        })
    });

})

/* $.each(data,function(key,value){
    console.log(value.id + value.first_name)
})*/