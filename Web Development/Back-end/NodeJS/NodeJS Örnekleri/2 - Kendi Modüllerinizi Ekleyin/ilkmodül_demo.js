var http = require('http');
var dt = require('./ilkmodül');

http.createServer(function (req, res) {
  res.writeHead(200, {'Content-Type': 'text/html'});
  res.write("Tarih ve saat bilgisi: " + dt.currentDateTime());
  res.end();
}).listen(8080); 