var connection = new signalR.HubConnectionBuilder()
    .withUrl("/" + "Students")
    .configureLogging(signalR.LogLevel.Information)
    .build();
try {
    connection.start();
    console.log("SignalR Connected.");
} catch (err) {
    console.log(err);
    setTimeout(start, 5000);
}


connection.on("RecieveMessage", renderMessage);

function renderMessage(textMessage) {

    var ul = document.getElementById("list_conversation");
    ul.innerHTML +=
        "<li class='clearfix odd'>" +
        "<div class='chat-avatar'>" +
        "<img src='~/Template/images/avatar-1.jpg' alt='male'>" +
        "<i>10:00</i>" +
        "</div>" +
        "<div class='conversation-text'>" +
        "<div class='ctext-wrap'>" +
        "<i>smith</i>" +
        "<p>" + textMessage + "</p>" +
        "</div>" +
        "</div>" +
        "</li>";
}

async function sendText() {
    var elem = document.getElementById('messageText');
    await connection.invoke("SendMessageAsync", elem.value);
}