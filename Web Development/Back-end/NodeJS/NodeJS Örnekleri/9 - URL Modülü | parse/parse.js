var url = require('url');
var adr = 'http://localhost:8080/bilisim.html?month=april&exam=web';
var q = url.parse(adr, true);

console.log(q.host); // Domain
console.log(q.pathname); // default.htm
console.log(q.search); // ?year=2024&month=mart'

var qdata = q.query; // { year: 2024, month: 'mart' }
console.log(qdata.month); // mart