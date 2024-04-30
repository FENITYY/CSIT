const http = require('http');
const url = require('url');

http.createServer(function (req, res) {
  // Set the response status code and content type
    res.writeHead(200, {'Content-Type': 'text/html'});

  // Parse the request URL query parameters
    var query = url.parse(req.url, true).query;

  // Check if the required query parameters are present
    

  // Create a text string using the query parameters
    var txt = query.year + " " + query.month;

  // Send the response body
    res.end(txt);
}).listen(8080);