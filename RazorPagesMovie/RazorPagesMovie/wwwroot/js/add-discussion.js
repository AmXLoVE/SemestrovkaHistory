window.onload = function () {

    const form = document.querySelector('form');

    form.addEventListener('submit', function() {
        let label = document.querySelector('input');
        let text = document.querySelector('textarea');
    
        if (label.value.length < 1 || text.value.length < 1) {
            alert('Заполните все поля!');
            return;
        }
    })
}