$(document).ready(function () {

    let passwordInput = $('#password-input');
    let passwordVisibilityEye = $('.password-eye');

    $(passwordVisibilityEye).on('click', function (e) {
        if ($(passwordVisibilityEye).hasClass('fa-eye')) {
            $(passwordVisibilityEye).removeClass('fa-eye');
            $(passwordVisibilityEye).addClass('fa-eye-slash');
            $(passwordInput).attr('type', 'text');
        }
        else {
            $(passwordVisibilityEye).removeClass('fa-eye-slash');
            $(passwordVisibilityEye).addClass('fa-eye');
            $(passwordInput).attr('type', 'password');
        }
    });

});