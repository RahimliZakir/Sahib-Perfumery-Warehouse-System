$(document).ready(function () {

    let reloadBtn = $('.add-admin-reload-btn');

    $(reloadBtn).click(function (e) {
        e.preventDefault();
        window.location.reload();
    });

    let productTd = $('.product-td');

    $(productTd).on('mouseenter', function () {
        let productTdImgContainer = $(this).find('.table-img-div-container');
        if ($(productTdImgContainer).hasClass('table-img-container-hidden')) {
            $(productTdImgContainer).removeClass('table-img-container-hidden');
            $(productTdImgContainer).addClass('table-img-container-visible');
        }
    });

    $(productTd).on('mouseleave', function () {
        let productTdImgContainer = $(this).find('.table-img-div-container');
        if ($(productTdImgContainer).hasClass('table-img-container-visible')) {
            $(productTdImgContainer).removeClass('table-img-container-visible');
            $(productTdImgContainer).addClass('table-img-container-hidden');
        }
    });
});