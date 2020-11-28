window.onload = function() {

    let contacts = document.getElementsByClassName('contact-copy');
    for (let contact of contacts) {
        contact.addEventListener('click', function() {
            let data = contact.innerHTML;
            copyToClipboard(data);
            alert('Cкопировано: ' + data);
        })
    }

    function copyToClipboard(str) {
        var fakeArea = document.createElement('textarea');
        document.body.appendChild(fakeArea);  
          fakeArea.value = str;
          fakeArea.select();
          document.execCommand("copy");
        document.body.removeChild(fakeArea);  
      }

}