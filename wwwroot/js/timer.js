let tiempo = parseInt(localStorage.getItem('tiempo')) || 300;
    
let timer = setInterval(function() {
    let minutes = Math.floor(tiempo / 60);
    let seconds = tiempo % 60;
    document.getElementById('tiempo').innerText = `${minutes}:${seconds < 10 ? '0' : ''}${seconds}`;


    localStorage.setItem('tiempo', tiempo);

    if (tiempo <= 0) {
        clearInterval(timer);
        alert("¡Se acabó el tiempo!");
        
        localStorage.removeItem('tiempo');
    }
    tiempo--;
}, 1000);