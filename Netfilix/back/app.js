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
    database:"netfilix"
})

con.connect(function(err){
    if(err)
    console.log(err);
    console.log("Connected");
})

var numberOfPictures;
query = "SELECT COUNT(picture_id) as C FROM pictures";
con.query(query, function(err, result){
    console.log(result[0].C)
    numberOfPictures = result[0].C
})

app.get('/getFilmInfos', function(req, res){
    query = "SELECT * FROM pictures";
    con.query(query, function(err, result){
        console.log(result);
        result.forEach(function(data){
            data.picture_name = "C:\\Users\\AYBU\\Documents\\GitHub\\ISKUR-Web-Mobil\\Netfilix\\back\\posters\\" + data.picture_name;
            console.log(data.picture_name);
        })           
        res.json(result);
    })
})

app.get('/getDescription', function(req, res){
    var picture_id = req.query.picture_id;
    query = "SELECT description FROM pictures WHERE picture_id=?";
    con.query(query, [picture_id], function(err, result){
        console.log(result);          
        res.send(result);
    })
})