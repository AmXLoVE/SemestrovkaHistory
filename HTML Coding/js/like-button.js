window.onload = function () {
    let like = document.getElementById('like');
    like.addEventListener('click', function () {
        this.classList.toggle('active');
    })
};