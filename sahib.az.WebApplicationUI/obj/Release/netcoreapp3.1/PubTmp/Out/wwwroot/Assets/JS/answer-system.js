$(document).ready(function () {

    let reloadBtn = $('.add-admin-reload-btn');

    $(reloadBtn).click(function (e) {
        e.preventDefault();
        window.location.reload();
    });

    // $(window).on('scroll', function () {
    //     let bodyScroll = $(document).scrollTop();
    //     let theadNavOffset = $('thead').offset().top;
    //     let theadNav = $('thead');

    //     if (bodyScroll >= theadNavOffset) {
    //         $('thead>tr').addClass('thead-active');
    //     }
    //     else if(bodyScroll < theadNavOffset){
    //         $(theadNav).removeClass('thead-active');
    //     }
    // });

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

    let addPerfume = $('.add-admin-add-btn');
    $(addPerfume).on('click', function () {
        let addPerfumeContainer = $('.add-perfume-container');

        if ($(addPerfumeContainer).hasClass('add-perfume-none')) {
            $(addPerfumeContainer).removeClass('add-perfume-none');
            $(addPerfumeContainer).addClass('add-perfume-block');
        }
    });

    let addPerfumeExtBtn = $('.add-perfume-ext-btn');

    $(addPerfumeExtBtn).on('click', function () {
        let addPerfumeContainer = $('.add-perfume-container');

        if ($(addPerfumeContainer).hasClass('add-perfume-block')) {
            $(addPerfumeContainer).removeClass('add-perfume-block');
            $(addPerfumeContainer).addClass('add-perfume-none');
        }
    });
});