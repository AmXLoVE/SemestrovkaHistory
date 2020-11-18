window.onload = function () {

    const allInputs = document.querySelectorAll('input[type="text"]');
    for (let inp of allInputs){
        inp.value = "";
    }

    document.getElementsByClassName('filter')[0].value = "disabled";

    const table = document.querySelector('table');
    let search = document.getElementById('search-text');

    search.addEventListener('keyup', function () {
        
        let filter = document.getElementsByClassName('filter')[0].value.toUpperCase();
        let phrase = search.value.toUpperCase();
        
        let cellIndex = 0;
        for (let i = 0; i < table.rows[0].cells.length; i++){
            if (table.rows[0].cells[i].innerHTML.toUpperCase().startsWith(filter)) {
                cellIndex = i;
                break;
            }
        }
    
        for (var i = 1; i < table.rows.length; i++) {
            if (table.rows[i].cells[cellIndex].innerHTML.toUpperCase().indexOf(phrase) > -1) {
                table.rows[i].style.display = "";
            } else {
                table.rows[i].style.display = "none";
            }
        }
    
    });

    let d = 1;
    let pointedIndex = -1;

    table.addEventListener('click', (e) => {
        const tb = e.target;
        if (tb.nodeName !== 'TH') return;
        const index = tb.cellIndex;
        const type = tb.getAttribute('type');
        if (pointedIndex === index) {
            d *= -1;
        }
        else {
            pointedIndex = index;
            d = 1;
        }
        sortTable(index, type);
    });
    
    function sortTable (index, type) {
    
        function compare (row1, row2) {
            const data1 = row1.cells[index].innerHTML;
            const data2 = row2.cells[index].innerHTML;
        
            switch (type) {
                case 'number':
                    return (data1 - data2) * d;
                    break;
                case 'text':
                    if (data1 > data2) return 1 * d;
                    if (data1 < data2) return -1 * d;
                    return 0;
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