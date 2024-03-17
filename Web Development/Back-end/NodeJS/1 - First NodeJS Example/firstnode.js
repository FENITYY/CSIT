var http = require('http'); // NodeJS icin http modülünü çağırır

// HTTP server oluşturur ve istek işlevini belirler
http.createServer(function (req, res) {
  res.writeHead(200, {'Content-Type': 'text/html'}); // İsteğin başarılı bir şekilde işlendiğini belirtit
  res.end('Web dersinde NodeJS ogreniyoruz!'); // Gelen isteğe yanıt gönderir
}).listen(8080); // 8080 portunu dinler