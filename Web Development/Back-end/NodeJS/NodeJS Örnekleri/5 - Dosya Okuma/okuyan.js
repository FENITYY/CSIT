var http = require('http');
var fs = require('fs');
var url = require('url');

http.createServer(function (req, res) {
    if (req.url == "/contact"){
        fs.readFile('contact.html', function(err, data) {
            res.writeHead(200, {'Content-Type': 'text/html'});
            res.write(data);
            return res.end();
        });
    }
    else if (req.url == "/hakkinda"){
        fs.readFile('hakkinda.html', function(err, data) {
            res.writeHead(200, {'Content-Type': 'text/html'});
            res.write(data);
            return res.end();
        });
    }
}).listen(8080);