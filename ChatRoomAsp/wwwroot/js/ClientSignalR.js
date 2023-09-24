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
    const li = document.createElement("li");
    li.textContent = `${textMessage}`;
    document.getElementById("messageList").appendChild(li);
}

async function sendText() {
    var elem = document.getElementById('input');
    await connection.invoke("SendMessageAsync", elem.value);
}