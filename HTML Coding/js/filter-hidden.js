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
    search.value = "";
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

    dataFilterNew.addEventListener('change', function() {
        var i = divs.length - 1;
        for (; i--;) {
            main.appendChild(divs[i]);
        }
    });

    dataFilterOld.addEventListener('change', function() {
        var i = divs.length - 1;
        for (; i--;) {
            main.appendChild(divs[i]);
        }
    });


    let checkboxes = document.querySelectorAll('input[type=checkbox');
    for (let checkbox of checkboxes){
        checkbox.checked = false;
    }
    
    let checked = new Set();
    for (let i=0; i<checkboxes.length; i++) {
        checkboxes[i].addEventListener('change', function() {
            if (checkboxes[i].checked) {
                checked.add(checkboxes[i].value);
            } else {
                checked.delete(checkboxes[i].value);
            }
            let noneCount = 0;
            let notation = document.getElementsByClassName('main-notation')[0];
            if (typeof notation !== "undefined") {
                notation.remove();
            }
            for (let j=0; j<divs.length; j++) {
                let keys = divs[j].getAttribute('keywords').split(';');
                if (contains(keys, Array.from(checked))) {
                    divs[j].style.display = "";
                } else {
                    divs[j].style.display = "none";
                    noneCount++;
                }
            }
            if (noneCount === divs.length) {
                let div = document.createElement('div');
                div.innerHTML = 'К сожалению, такой статьи пока нет!';
                div.classList.add('main-notation');
                main.appendChild(div);
            } 
        });
    }

    function contains(where, what){
        for(var i=0; i<what.length; i++){
            if(where.indexOf(what[i]) == -1) return false;
        }
        return true;
    }
}