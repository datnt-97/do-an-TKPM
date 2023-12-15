var nodemailer = require('nodemailer');
import config from "../config/init";

var transporter = nodemailer.createTransport({
    service: 'gmail',
    auth: {
        user: config.mail.user,
        pass: config.mail.password,
    },

});

export const sendMail = (to, subject, html) => {
    var mailOptions = {
        from: "HỆ THỐNG ALOXE",
        sender: config.mail.user,
        to: to,
        subject: subject,
        html: html
    };
    transporter.sendMail(mailOptions, function (error, info) {
        if (error) {
            console.log(error);
            return false;
        } else {
            console.log('Email sent: ' + info.response);
            return true;
        }
    });
}