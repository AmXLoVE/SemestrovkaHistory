window.onload = function () {
    const table = document.querySelector('table');
    const search = document.getElementsByClassName('form-search')[0];
    const inputs = document.querySelectorAll('input[data-rule]');

    const allInputs = document.querySelectorAll('input[type="text"]');
    for (let inp of allInputs){
        inp.value = "";
    }

    search.addEventListener('keyup', function () {
        let filter = document.getElementsByClassName('filter')[0].value.toUpperCase();
        let phrase = document.getElementsByClassName('search-text')[0].value.toUpperCase();
        
        let cellIndex = 0;
        for (let i = 0; i < table.rows[0].cells.length; i++){
            let flagInd = false;
            if (table.rows[0].cells[i].innerHTML.toUpperCase().startsWith(filter)) {
                cellIndex = i;
            }
            if (flagInd) break;
        }

        let flag = false;
        for (var i = 1; i < table.rows.length; i++) {
            flag = false;
            flag = table.rows[i].cells[cellIndex].innerHTML.toUpperCase().indexOf(phrase) > -1;
            if (flag) {
                table.rows[i].style.display = "";
            } else {
                table.rows[i].style.display = "none";
            }

        }

    });

    table.addEventListener('click', (e) => {
        const tb = e.target;
        if (tb.nodeName !== 'TH') return;
        const index = tb.cellIndex;
        const type = tb.getAttribute('type');
        sortTable(index, type);
    });

    function sortTable (index, type) {

        function compare (row1, row2) {
            const data1 = row1.cells[index].innerHTML;
            const data2 = row2.cells[index].innerHTML;
        
            switch (type) {
                case 'number':
                    return +data1 - +data2;
                    break;
                case 'text':
                    if (data1 > data2) return 1;
                    if (data1 < data2) return -1;
                    return 0;
                    break;
                case 'date':
                    const date1 = new Date(data1.split('.').reverse().join('-'));
                    const date2 = new Date(data2.split('.').reverse().join('-'));
                    return date1.getTime() - date2.getTime();
                    break;
                case 'group':
                    const group1 = data1.split('-');
                    const group2 = data2.split('-');
                    if (+group1[0] < +group2[0]) return -1;
                    if (+group1[0] > +group2[0]) return 1;
                    return +group1[1] - +group2[1];
                    break;
                case 'email':
                    const email1 = data1.split('@');
                    const email2 = data2.split('@');
                    if (email1[0] < email2[0]) return -1;
                    else if (email1[0] > email2[0]) return 1;
                    else {
                        if (email1[1] < email2[1]) return -1;
                        if (email1[1] > email2[1]) return 1;
                        return 0;
                    }
                    break;
            }
        }

        const tbody = table.querySelector('tbody');
        let rows = Array.prototype.slice.call(tbody.rows);
        rows.sort(compare);
        table.removeChild(tbody);
        for (let i=0; i < rows.length; i++) {
            tbody.appendChild(rows[i]);
        }
        table.appendChild(tbody);
    }
}