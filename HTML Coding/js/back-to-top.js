let goTopBtn = document.querySelector('.rollover');

window.addEventListener('scroll', trackScroll);
goTopBtn.addEventListener('click', backToTop);

function trackScroll() {
    var scrolled = window.pageYOffset;
    if (scrolled > 250) {
        goTopBtn.classList.add('show');
    } else {
        goTopBtn.classList.remove('show');
    }
}

function backToTop() {
    if (window.pageYOffset > 0) {
        window.scrollBy(0, -60);
        setTimeout(backToTop, 0);
    }
}