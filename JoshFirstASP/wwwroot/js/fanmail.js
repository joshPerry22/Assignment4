/* $. is same as jQuery */

$("#submitButton").click( function (){
    alert("From: " + $('#from').val() + '\n' +
        "Email: " + $('#email').val() + '\n' +
        "Subject: " + $('#subject').val() + '\n' +
        "Message: " + $('#message').val());
});