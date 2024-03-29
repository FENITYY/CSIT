var fs = require('fs');

var rs = fs.createReadStream('./metin.txt');
rs.on('open', function () {
    console.log('Dosya Açık');
}); 