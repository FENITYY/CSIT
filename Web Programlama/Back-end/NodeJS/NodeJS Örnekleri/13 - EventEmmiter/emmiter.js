var events = require('events');
var eventEmitter = new events.EventEmitter();

//Create an event handler:
var myEventHandler = function () {
    console.log('Çığlık duyuyorum!');
}
eventEmitter.on('scream', myEventHandler);
eventEmitter.emit('scream');