window.onload = function () {

    const form = document.getElementsByClassName('form-add')[0];
    const inputs = document.querySelectorAll('input[data-rule]');

    for (let inp of inputs){
        inp.value = "";
    }

    let loginIsCorrect = false;
    let parolIsCorrect = false;
    let parolsAreEqual = false;
    let parol1;
    let parol2;

    function validate () {
        let rule = this.dataset.rule;
        let value = this.value;
        let check;
    
        switch (rule) {

            case 'login':
                check = /^[a-zA-Zа-яёА-ЯЁ]{3,20}$/.test(value);
                loginIsCorrect = check;
                break;
            case 'parol1':
                check = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}$/.test(value);
                parolIsCorrect = check;
                parol1 = value;
                if (parol2 !== parol1 && value.length > 0) {
                    parolsAreEqual = false;
                    document.querySelector('input[data-rule=parol2]').classList.remove('valid');
                    document.querySelector('input[data-rule=parol2]').classList.add('invalid');
                }
                if (parol2 === parol1 && value.length > 0) {
                    parolsAreEqual = true;
                    document.querySelector('input[data-rule=parol2]').classList.remove('invalid');
                    document.querySelector('input[data-rule=parol2]').classList.add('valid');
                }
                break;
            case 'parol2':
                check = (parol1 === value) && (value.length > 0);
                parolsAreEqual = check;
                parol2 = value
                break;
        }
    
        this.classList.remove('valid');
        this.classList.remove('invalid');
        if (check) {
            this.classList.add('valid');
        } else {
            this.classList.add('invalid');
        }
    }
    
    for (let input of inputs) {
        input.addEventListener('keyup', validate);
        input.addEventListener('blur', validate);
    }
    
    form.addEventListener('submit', (e) => {
        let check = true;
        for (let inp of inputs) {
            if (inp.value.length < 1) {
                check = false;
                inp.classList.add('invalid');
            }
        }
        if (!check) {
            alert ('Заполните все поля!');
            return false;
        }
        if (!loginIsCorrect) {
            alert ('Логин должен сожержать минимум 3 символа и состоять только из букв!');
            return false;
        }
        if (!parolIsCorrect) {
            alert ('Пароль слишком пройстой!\nОн должен состоять минимум из 6 символов\nи содержать минимум одну цифру, одну заглавную и одну строчную буквы.');
            return false;
        }
        if (!parolsAreEqual) {
            alert ('Пароли не совпадают!');
            return false;
        }

        /* проверка на бэке */

        /* signup */
        return true;
    });
}