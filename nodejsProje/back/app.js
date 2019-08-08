var express = require('express');
var cors = require('cors');
var mysql = require('mysql');
var app = express();

app.use(cors());

var server = app.listen(3000, function(){
    console.log("Node server is running....");
})

var con = mysql.createConnection({
    host:"localhost",
    user:"root",
    password:"1234",
    database:"sakila"
})

con.connect(function(err){
    if(err)
    console.log(err);
    console.log("Connected");
})

app.get('/actors', function(req, res){
    query = "SELECT * FROM ACTOR"
    con.query(query, function(err, result){
        res.send(result);
    })
})

app.get('/actor', function(req, res){
    var first_name = req.query.first_name;
    var last_name = req.query.last_name;
   // var last_update = req.query.last_update;
    query = "INSERT INTO ACTOR(first_name, last_name) VALUES(?,?)";
    con.query(query,[first_name,last_name], function(err, result){
        console.log(result);
    })
    res.send("Eklendi");
})