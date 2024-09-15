const loginPage = document.getElementById('loginPage');
const registerPage = document.getElementById('registerPage');


const registerLinkInLogin = document.querySelector('.registration');
const loginLinkInRegister = document.querySelector('.registration1');

const loginBtn = document.getElementById('loginBtn');

function showLoginPage() {
    loginPage.style.display = 'block';
    registerPage.style.display = 'none';
}

function showRegisterPage() {
    registerPage.style.display = 'block';
    loginPage.style.display = 'none';
}

registerLinkInLogin.addEventListener('click', showRegisterPage);
loginLinkInRegister.addEventListener('click', showLoginPage);

loginBtn.addEventListener('click', showLoginPage);

const closeIcon = document.querySelector('.closeicon');

function hideLoginPage() {
    loginPage.style.display = 'none';
}

closeIcon.addEventListener('click', hideLoginPage);
