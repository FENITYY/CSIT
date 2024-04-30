var fs = require('fs');

fs.appendFile('metin.txt', 'Merhaba!', function (err) {
    if (err) throw err;
    console.log('Kaydedildi!');
}); 