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

    let main = document.getElementsByClassName('main-block')[0];
    let divs = main.children;
    let dataFilterNew = document.getElementById('r1');
    let dataFilterOld = document.getElementById('r2');
    dataFilterNew.checked = true;
    dataFilterOld.checked = false;
    let newFirst = true;
    let oldFirst = false;

    dataFilterNew.addEventListener('click', function() {
        if (oldFirst) {
            var i = divs.length - 1;
            for (; i--;) {
                main.appendChild(divs[i]);
            }
            newFirst = true;
            oldFirst = false;
        }
    });

    dataFilterOld.addEventListener('click', function() {
        if (newFirst) {
            var i = divs.length - 1;
            for (; i--;) {
                main.appendChild(divs[i]);
            }
            newFirst = false;
            oldFirst = true;
        }
    });

}