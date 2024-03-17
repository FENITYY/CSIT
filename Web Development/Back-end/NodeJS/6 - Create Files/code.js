var fs = require('fs');

fs.appendFile('text.txt', 'NodeJS is awesome!', function (err) {
    if (err) throw err;
    console.log('Saved!');
}); 