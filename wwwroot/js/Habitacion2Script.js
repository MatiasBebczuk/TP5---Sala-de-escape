document.addEventListener('DOMContentLoaded', function() {
    const toggleButtons = document.querySelectorAll('.overlay-button');
    const toggleImage = document.getElementById('toggleImage');

    // Imágenes específicas para cada botón
    const images = {
        'toggleButton1': '../imgs/Habitacion_2/A_Habitacion_2.png',
        'toggleButton2': '../imgs/Habitacion_2/E_Habitacion_2.png',
        'toggleButton3': '../imgs/Habitacion_2/K_Habitacion_2.png',
        'toggleButton4': '../imgs/Habitacion_2/Q_Habitacion_2.png',
        'toggleButton5': '../imgs/Habitacion_2/U_Habitacion_2.png'
    };

    toggleButtons.forEach(button => {
        button.addEventListener('click', function() {
            const buttonId = button.id;
            const imageSrc = images[buttonId];
            
            if (toggleImage.style.display === 'none' || toggleImage.style.display === '') {
                toggleImage.src = imageSrc; // Cambiar la imagen
                toggleImage.style.display = 'block';
                toggleButtons.forEach(btn => btn.style.display = 'none');
            }
        });
    });

    toggleImage.addEventListener('click', function() {
        toggleImage.style.display = 'none';
        toggleButtons.forEach(btn => btn.style.display = 'block');
    });
});