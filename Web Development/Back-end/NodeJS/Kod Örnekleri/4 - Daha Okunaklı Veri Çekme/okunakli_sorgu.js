var http = require('http');
var url = require('url'); // URL isimli modülü aktifleştirir.

http.createServer(function (req, res) {
    res.writeHead(200, {'Content-Type': 'text/html'});
    var q = url.parse(req.url, true).query; 
    // Sorgu parametreleri ayrıştırılarak 
    // JS nesnesi olarak saklanır
    var txt = q.year + " " + q.month; 
    // Sorguda ayrıştırılan year ve month 
    // özelliklerini içeren q nesnesi 
    // kullanarak bir metin oluşturulur.
    res.end(txt);
}).listen(8080);