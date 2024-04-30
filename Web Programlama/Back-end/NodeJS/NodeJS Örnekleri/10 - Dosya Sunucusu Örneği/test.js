var http = require('http');
var url = require('url');
var fs = require('fs');
var path = require('path');

http.createServer(function (req, res) {
    var q = url.parse(req.url, true);
    var filename = "." + q.pathname;
    var ext = path.extname(filename);
    var contentType = 'text/plain';

    if (ext === '.html') {
        contentType = 'text/html';
    }
    else if (ext === '.css') {
        contentType = 'text/css';
    }
    else if (ext === '.js') {
        contentType = 'application/javascript';
    }

    fs.readFile(filename, function(err, data) {
        if (err) {
            res.writeHead(404, {'Content-Type': 'text/html'});
            return res.end("404 Bulunamadi");
        }

        res.writeHead(200, {'Content-Type': contentType});
        res.write(data);
        return res.end();
    });
}).listen(8080);