var fs = require('fs');

fs.appendFile('metin.txt', 'Hello content!', function (err) {
    if (err) throw err;
    console.log('Saved!');
}); 