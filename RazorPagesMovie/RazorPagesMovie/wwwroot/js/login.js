window.onload = function () {

    const form = document.getElementsByClassName('form-add')[0];
    const inputs = document.querySelectorAll('input[data-rule]');

    form.addEventListener('submit', (e) => {
        let check = true;
        for (let inp of inputs) {
            if (inp.value.length < 1) {
                check = false;
                break;
            }
        }
        if (!check) {
            alert('Заполните все поля!');
            return false;
        }
        return true;
    });
}