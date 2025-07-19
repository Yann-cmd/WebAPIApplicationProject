const LOGIN_API_URL = "api/Login";

function submitLoginForm(event) {
    event.preventDefault();

    const username = document.getElementById("username").value.trim();
    const email = document.getElementById("email").value.trim();
    const password = document.getElementById("password").value;

    const loginObject = { Email: email, Username: username, Password: password }

    fetch(LOGIN_API_URL, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(loginObject)
    })
    .then(response => {
        if (!response.ok) {
            throw new Error("Identifiant ou mot de passe incorrect.");
        }
        return response.json();
    })
    .then(data => {
        console.log("Connexion réussie!");
        localStorage.setItem("token", data.token);
        localStorage.setItem("username", data.username);
        window.location.href = "index.html";
    })
    .catch(error => console.error('Échec de la connexion', error));
}
function redirectToHome() { window.location.href = 'index.html'; }