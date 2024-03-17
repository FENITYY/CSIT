var http = require('http');

http.createServer(function (req, res) {
    res.writeHead(200, {'Content-Type': 'text/html'});
    res.write(req.url); // URL domain sonrası okuma bu satırda gerçekleşir.
    res.end();
}).listen(8080);