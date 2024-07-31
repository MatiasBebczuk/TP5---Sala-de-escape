let tiempo = parseInt(localStorage.getItem('tiempo')) || localStorage.getItem('tiemp');
    
let timer = setInterval(function() {
    let minutes = Math.floor(tiempo / 60);
    let seconds = tiempo % 60;
    document.getElementById('tiempo').innerText = `${minutes}:${seconds < 10 ? '0' : ''}${seconds}`;


    localStorage.setItem('tiempo', tiempo);

    if (tiempo <= 0) {
        clearInterval(timer);
        window.location.href = "Derrota";
        
        localStorage.removeItem('tiempo');
    }
    tiempo--;
}, 1000);