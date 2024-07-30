document.addEventListener('DOMContentLoaded', function() {
    const toggleButtons = document.querySelectorAll('.overlay-button');
    const toggleImage = document.getElementById('toggleImage');

    // Imágenes específicas para cada botón
    const images = {
        'toggleButton1': '1_Habitacion_4.jpg',
        'toggleButton2': '2_Habitacion_4.jpg',
        'toggleButton3': '3_Habitacion_4.jpg',
        'toggleButton4': '4_Habitacion_4.jpg',
        'toggleButton5': '5_Habitacion_4.jpg'
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