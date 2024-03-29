var fs = require('fs');

fs.writeFile('metin.txt', 'Merhaba!', function (err) {
    if (err) throw err;
    console.log('Saved!');
}); 