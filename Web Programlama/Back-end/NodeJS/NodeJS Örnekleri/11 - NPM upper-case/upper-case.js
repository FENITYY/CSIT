var http = require('http');

// Use dynamic import instead of require
import('upper-case').then(uc => {
    http.createServer(function (req, res) {
    res.writeHead(200, {'Content-Type': 'text/html'});
    res.write(uc.upperCase("Hello World!"));
    res.end();
    }).listen(8080);
}).catch(error => {
    console.error('Error loading upper-case module:', error);
});
