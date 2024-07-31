document.addEventListener('DOMContentLoaded', function() {
    const buttons = document.querySelectorAll('.overlay-button');
    const overlays = document.querySelectorAll('.image-overlay');

    buttons.forEach((button, index) => {
        button.addEventListener('click', function(){
            const currentOverlay = overlays[index];
            const isVisible = currentOverlay.style.display === 'block';

            // Ocultar todas las imágenes
            overlays.forEach(overlay => overlay.style.display = 'none');
            
            // Mostrar u ocultar la imagen correspondiente
            currentOverlay.style.display = isVisible ? 'none' : 'block';
        });
    });
});

document.addEventListener('DOMContentLoaded', function() {
    const toggleButtons = document.querySelectorAll('.overlay-button');
    const toggleImage = document.getElementById('toggleImage');

    toggleButtons.forEach(button => {
        button.addEventListener('click', function() {
            if (toggleImage.style.display === 'none' || toggleImage.style.display === '') {
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