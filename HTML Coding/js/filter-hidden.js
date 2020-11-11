window.onload = function () {

    let coll = document.getElementsByClassName('filter-button');
    for (let i=0; i<coll.length; i++) {
        coll[i].addEventListener('click', function() {
            let content = this.nextElementSibling;
            if (content.style.maxHeight) {
                content.style.maxHeight = null;
            } else {
                content.style.maxHeight = content.scrollHeight + 'px'
            }
        });
    }

    let search = document.getElementById('search-keyword');
    let keywords = document.getElementsByClassName('filter-keyword'); 
    search.addEventListener('keyup', function () {
        let phrase = search.value.toUpperCase();
        for (i=0; i<keywords.length; i++) {
            let key = keywords[i].getElementsByTagName('label')[0];
            if (key.innerHTML.toUpperCase().indexOf(phrase) > -1) {
                keywords[i].style.display = "";
            } else {
                keywords[i].style.display = "none";
            }
        }
    });

}