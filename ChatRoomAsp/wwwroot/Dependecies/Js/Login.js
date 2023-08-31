document.getElementById("loginForm").addEventListener("submit", function (event) {
    event.preventDefault(); // Prevent form submission
    var phone = document.getElementById("phone").value;
    var username = document.getElementById("username").value;

    // Perform further actions with the phone and username
    console.log("Phone: " + phone);
    console.log("Username: " + username);
});