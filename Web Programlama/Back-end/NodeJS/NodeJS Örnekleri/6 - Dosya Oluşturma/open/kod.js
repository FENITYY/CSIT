var fs = require('fs');

fs.open('metin.txt', 'w', function (err, file) {
    if (err) throw err;
    console.log('Kaydedildi!');
}); 