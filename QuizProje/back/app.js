var express = require('express');
var cors = require('cors');
var mysql = require('mysql');
var app = express();
var bodyParser = require('body-parser');

app.use(cors());

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: true}));

var server = app.listen(3000, function(){
    console.log("Node server is running....");
})

var con = mysql.createConnection({
    host:"localhost",
    user:"root",
    password:"1234",
    database:"quiz"
})

con.connect(function(err){
    if(err)
    console.log(err);
    console.log("Connected");
})

// Ön taraftan gelen soruyu database e kaydeder
app.post('/sendQuestion', function(req, res){    
    console.log(req.body);
    var question = req.body.question;
    var answer1 = req.body.answer1;
    var answer2 = req.body.answer2;
    var answer3 = req.body.answer3;
    var answer4 = req.body.answer4;
    var correct = req.body.correct;
    query = "INSERT INTO questions(question, answer1, answer2, answer3, answer4, correct) VALUES(?,?,?,?,?,?)";
    con.query(query, [question, answer1, answer2, answer3, answer4, correct], function(err, result){
        console.log(result);
        console.log(err);
        res.end("Eklendi");
    })
})

// Son sorunun id sini bulur
var maxId;
query = "SELECT MAX(example_id) as C FROM questions";
con.query(query, function(err, result){
    maxId = parseInt(result[0].C);
    console.log("Max_id: " + typeof(maxId));
})

// id ye göre soru getirir ve ön tarafa gönderir
var id = 2;
app.get('/getQuestion', function(req, res){
    console.log(maxId);
    query = "SELECT * FROM questions WHERE example_id="+id;     
    con.query(query, function(err, result){ 
        if(id < maxId && result.length != 0){
            console.log(result);
            console.log(err);     
            res.send(result);            
            id++;
        }
        else if(id == maxId){
            id=2;
            res.send("No Question");
        }    
        else{
            id++;
            res.send("New Question");
        }    
    })
     
})

// Ön taraftan gelen verileri user tablosuna ekler
app.post('/addUser', function(req, res){
    console.log(req.body);
    var username = req.body.username;
    var password = req.body.password;
    query = "INSERT INTO users(username, password) VALUES(?,?)";
    con.query(query, [username, password], function(err, result){
        console.log(result);
        console.log(err);
        res.end("Eklendi");
    })
})

// Kullanici adi ve sifresi dogru mu kontrol eder
app.post('/login', function(req, res){
    console.log(req.body);
    var username = req.body.username;
    var password  = req.body.password;
    query = "SELECT * FROM users WHERE username=? AND password=?";
    con.query(query, [username, password], function(err, result){
        if(result.length != 0){
            res.end("Successfull");
            console.log(result);
        }
        else{
            console.log(result);
            console.log(err);
            res.end(err);
        }
    })
})