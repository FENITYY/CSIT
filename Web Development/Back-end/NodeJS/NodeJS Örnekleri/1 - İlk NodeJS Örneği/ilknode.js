//var http = require('http'); // NodeJS icin http modülünü çağırır

// HTTP server oluşturur ve istek işlevini belirler
//http.createServer(function (req, res) {
  //res.writeHead(200, {'Content-Type': 'text/html'}); // İsteğin başarılı bir şekilde işlendiğini belirtit
  //res.end('Web dersinde NodeJS ogreniyoruz!'); // Gelen isteğe yanıt gönderir
//}).listen(8080); // 8080 portunu dinler

const http = require('http');

const hostname = '127.0.0.1';
const port = 5050;

const server = http.createServer((req, res) => {
  res.statusCode = 200;
  res.setHeader('Content-Type', 'text/plain');
  res.end('Hello World\n');
}).listen(port);