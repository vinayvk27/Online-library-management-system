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

const closeIcon = document.querySelector('.closeIcon');
const closeIcon1 = document.querySelector('.closeIcon1');

function hideLoginPage() {
    loginPage.style.display = 'none';
}
function hideregisterPage() {
    registerPage.style.display = 'none';
}

closeIcon.addEventListener('click', hideLoginPage);
closeIcon1.addEventListener('click',hideregisterPage );

