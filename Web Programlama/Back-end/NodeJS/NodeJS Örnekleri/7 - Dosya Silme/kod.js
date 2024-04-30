var fs = require('fs');

fs.unlink('metin.txt', function (err) {
    if (err) throw err;
    console.log('File deleted!');
}); 