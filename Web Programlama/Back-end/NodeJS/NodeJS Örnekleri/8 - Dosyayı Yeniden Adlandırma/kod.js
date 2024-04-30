var fs = require('fs');

fs.rename('metin.txt', 'yazı.txt', function (err) {
    if (err) throw err;
    console.log('File Renamed!');
}); 