document.addEventListener('DOMContentLoaded', function() {
    const toggleButtons = document.querySelectorAll('.overlay-button');
    const toggleImage = document.getElementById('toggleImage');

    // Imágenes específicas para cada botón
    const images = {
        'toggleButton1': '../imgs/Habitacion_4/1_Habitacion_4.png',
        'toggleButton2': '../imgs/Habitacion_4/2_Habitacion_4.png',
        'toggleButton3': '../imgs/Habitacion_4/3_Habitacion_4.png',
        'toggleButton4': '../imgs/Habitacion_4/4_Habitacion_4.png',
        'toggleButton5': '../imgs/Habitacion_4/5_Habitacion_4.png'
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