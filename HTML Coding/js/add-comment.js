window.onload = function () {

    const form = document.querySelector('form');

    form.addEventListener('submit', function() {
        let comment = document.querySelector('textarea');
    
        if (comment.value.length < 1) {
            alert('Комментарий не может быть пустым!');
            return;
        }    
    })

}