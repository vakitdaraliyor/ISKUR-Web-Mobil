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

app.get('/getQuestion', function(req, res){
    query = "SELECT * FROM questions ORDER BY RAND() LIMIT 1"; 
    con.query(query, function(err, result){
    console.log(result);
    console.log(err);
    res.send(result);
})
})