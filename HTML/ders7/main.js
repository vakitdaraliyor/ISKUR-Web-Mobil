var i;
var table = document.getElementById("numbers");
table.innerHTML = "<thead><th>10*N</th><th>100*N</th><th>1000*N</th></thead><tbody>";

for(i=1; i<=10; i++){
    table.innerHTML += "<tr><td>"+(i*10)+"</td><td>"+i*100+"</td><td>"+(i*1000)+"</td></tr>";
}

table.innerHTML += "</tbody>";

function search(){
    // console.log(document.getElementById("string").value); undefined
    var string = document.getElementById("string").textContent;
    var input = document.getElementById("txtInput").value;
    document.getElementById("txtFirstOccurence").value = string.indexOf(input);
    document.getElementById("txtLastOccurence").value = string.lastIndexOf(input);
}

function split(){
    var input = document.getElementById("txtInput2").value;
    document.getElementById("txtArea").value = input.split(" ").join("\n");
    // split(" ") bosluga gore ayırdı
    // join("\n") ayrılan elemanları bosluga gore birlestirdi


    // ------------------------ Second Way ------------------------
    /*var words = [];
    words = input.split(" ");
    for(var i = 0; i<words.length; i++){
        document.getElementById("txtArea").value += words[i] + "\n";
    }*/
    
}

