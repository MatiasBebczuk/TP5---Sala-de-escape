document.addEventListener('DOMContentLoaded', function() {
    const buttons = document.querySelectorAll('.pista');
    let cantPistas = 0;

    buttons.forEach((button, index) => {
        button.addEventListener('alert', function(){
            cantPistas++;
            localStorage.setItem('cantPistasTotal', cantPistasTotal + cantPistas);
        });
    });
});