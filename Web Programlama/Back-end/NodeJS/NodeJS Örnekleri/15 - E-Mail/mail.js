var nodemailer = require('nodemailer');

var transporter = nodemailer.createTransport({
    service: 'gmail',
    auth: {
    user: 'ekarsterrk@gmail.com',
    pass: 'yok şifre falan'
    }
});

var mailOptions = {
    from: 'ekarsterrk@gmail.com',
    to: 'efecan_kara@tuta.io',
    subject: 'Sending Email using Node.js',
    text: 'That was easy!'
};

transporter.sendMail(mailOptions, function(error, info){
    if (error) {
    console.log(error);
    } else {
    console.log('Email sent: ' + info.response);
    }
}); 