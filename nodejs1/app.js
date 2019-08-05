/*console.log("I am working.");

 x = 5;
 y = 10;

 console.log(x+y);*/

/**
 * CORS Hatası: Chrome bilmediğim bir servere istekte bulunmamı istiyorsun
 * adamın headerı yok güvenliği hiç bir şeyi yok o yüzden sana CORS hatası dönüyorum
 * CORS Hatası Çözümü: Server tarafında server ı durdurup terminal açıp npm install cors yüklüyoruz 
 */

 var express = require('express'); 
 var cors = require('cors');
 var mysql = require('mysql');
 var app = express();

 app.use(cors());

 var con = mysql.createConnection({
     host:"localhost",
     user:"root",
     password:"1234",
     database:"sakila"
 })

 con.connect(function(err){
     if(err)
     console.log(err);
     console.log("Connected!");
 })

 app.get('/actors', function(req, res){
     query = "SELECT * FROM ACTOR"
     con.query(query, function(err, result){
         res.send(result);
     });
 })

 app.get('/kategori', function(req, res){
     query = "SELECT * FROM CATEGORY"
     con.query(query, function(err, result){
         res.send(result);
     })
 })

 app.get('/actor', function(req, res){
    var user_id = req.query.id;
    query = "SELECT * FROM ACTOR WHERE actor_id="+user_id;
    con.query(query, function(err, result){
        res.send(result);
    })
 })

 // ------------------------------------------------------------------------------
 //                                 NODE JS GIRIS
 // ------------------------------------------------------------------------------
 // Dışardan gelen get isteğine reponse olarak response döner.localhost:3000/home
 // Bir sorgunun tek response u olur.Tek cevap!
 app.get('/home', function(req, res){
     // res.send('<html><body><h1>Hello World</h1></body></html>');
     res.json({"name":"osman"});
     // res.send("Respond");
 });

 // Server açılır kapanmaz.3000 portunu dinliyor.localhost:3000
 var server = app.listen(3000, function(){
     console.log('Node server is running...');
 })
