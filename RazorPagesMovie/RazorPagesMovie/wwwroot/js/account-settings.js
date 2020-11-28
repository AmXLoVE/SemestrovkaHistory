function changeParol() {

    let newParolInputs = document.querySelectorAll('input[for="changeParol"]');
    let oldParol = newParolInputs[0].value;
    let newParol1 = newParolInputs[1].value;
    let newParol2 = newParolInputs[2].value;

    let newParolIsCorrect = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}$/.test(newParol1);
    let newParolsAreEqual = newParol2 === newParol1 && newParol2.length > 0;

    let check = true;
    for (let inp of newParolInputs) {
        if (inp.value.length < 1) {
            check = false;
            break;
        }
    }
    if (!check) {
        alert ('Заполните все поля!');
        return;
    }
    /*
    на бэке 

    if (oldParolIsCorrect) {
        alert ('Неверный пароль');
        return;
    }
    */
    if (!newParolIsCorrect) {
        alert ('Пароль слишком пройстой!\nОн должен состоять минимум из 6 символов\nи содержать минимум одну цифру, одну заглавную и одну строчную буквы.');
        return;
    }
    if (!newParolsAreEqual) {
        alert ('Пароли не совпадают!');
        return;
    }

    /* изненение пароля */

    document.location.href = 'account.html'

}

function changeLogin() {

    let newLoginInputs = document.querySelectorAll('input[for="changeLogin"]');
    let newLogin = newLoginInputs[0].value;
    let oldParol = newLoginInputs[1].value;

    let newLoginIsCorrect = /^[a-zA-Zа-яёА-ЯЁ]{3,20}$/.test(newLogin);

    let check = true;
    for (let inp of newLoginInputs) {
        if (inp.value.length < 1) {
            check = false;
            break;
        }
    }
    if (!check) {
        alert ('Заполните все поля!');
        return;
    }
    /*
    на бэке 

    if (oldParolIsCorrect) {
        alert ('Неверный пароль');
        return;
    }
    */
    if (!newLoginIsCorrect) {
        alert ('Логин должен сожержать минимум 3 символа и состоять только из букв!');
        return;
    }

    /* изненение логина */

    document.location.href = 'account.html'

}