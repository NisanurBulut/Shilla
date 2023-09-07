/*!
 * AdminuxPRO script v1.0.0 (https://www.maxartkiller.com/)
 * Copyright 2019-2019 The Maxartkiller Authors
 * Copyright 2019-2019 Maxartkiller.com
 * Licensed: You must have a valid license purchased only from maxartkiller.com in order to legally use the theme for your project.
 */
'use strict'
$(document).ready(function () {

    /* background image to cover */
    $('.background').each(function () {
        var imagewrap = $(this);
        var imagecurrent = $(this).find('img').attr('src');
        imagewrap.css('background-image', 'url("' + imagecurrent + '")');
        $(this).find('img').remove();
    });

    /* select checkbox personalize change events */


    /* wrapper corner */
    $('#wrapperCorner').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("wrappercorner", 'wrapper-square', {
                expires: 7
            });

            $('body').addClass('wrapper-square');
            if ($('body').hasClass('header-fixed-top') == true) {
                var headerheight = $('.header-container').outerHeight();
                $('.wrapper').css('padding-top', headerheight);
            } else {
                $('.wrapper').css('padding-top', '0');
            }
        } else {
            $.removeCookie("wrappercorner", '');

            $('body').removeClass('wrapper-square');
            if ($('body').hasClass('header-fixed-top') == true) {
                var headerheight = $('.header-container').outerHeight() + 15;
                $('.wrapper').css('padding-top', headerheight);
            } else {
                $('.wrapper').css('padding-top', '15px');
            }
        }
    });


    /* container width */
    $('#contentWidth').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("contentWidth", 'container-fluid', {
                expires: 7
            });
           
        } else {
            $.removeCookie("contentWidth");
        }
    });

    /* header fixed position */
    $('#headerfixed').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("headerfixed", 'header-fixed-top', {
                expires: 7
            });
            $('body').addClass('header-fixed-top');
            $('.header-container').addClass('shadow-sm');

            if ($('body').hasClass('wrapper-square') == true) {
                var headerheight = $('.header-container').outerHeight();
                $('.wrapper').css('padding-top', headerheight);
            } else {
                var headerheight = $('.header-container').outerHeight() + 15;
                $('.wrapper').css('padding-top', headerheight);
            }
        } else {
            $.removeCookie("headerfixed");
            $('body').removeClass('header-fixed-top');
            $('.header-container').removeClass('shadow-sm');
            if ($('body').hasClass('wrapper-square') == true) {
                $('.wrapper').css('padding-top', '0');
            } else {
                $('.wrapper').css('padding-top', '15px');
            }
        }
    });

    /* header fixed width  */
    $('#headercontainer').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("headercontainer", 'container', {
                expires: 7
            });
            $('#header-container').addClass('container').removeClass('container-fluid');
            $('#submenu-container').addClass('container').removeClass('container-fluid');
        } else {
            $.removeCookie("headercontainer");
            $('#header-container').removeClass('container').addClass('container-fluid');
            $('#submenu-container').removeClass('container').addClass('container-fluid');
        }
    });


    /* header fill color */
    $('#headerfillcolor').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("headerfillcolor", 'header-fill', {
                expires: 7
            });
            $('body').addClass('header-fill');
        } else {
            $.removeCookie("headerfillcolor");
            $('body').removeClass('header-fill');
        }
    });



    /* sidebar compact */
    $('#sidebarCompact').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("sidebarsize", 'sidebar-compact', {
                expires: 7
            });
            $('body').addClass('sidebar-compact');
            $('body').removeClass('sidebar-icon');
            $('.sidebar').find('.dropdown').removeClass('show').find('.dropdown-toggle').next().hide();
        } else {
            $.removeCookie("sidebarsize");
            $('body').removeClass('sidebar-compact');
        }
    });

    /* sidebar icon */
    $('#sidebarIconic').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("sidebarsize", 'sidebar-icon', {
                expires: 7
            });
            $('body').addClass('sidebar-icon');
            $('body').removeClass('sidebar-compact');
            $('.sidebar').find('.dropdown').removeClass('show').find('.dropdown-toggle').next().hide();
        } else {
            $.removeCookie("sidebarsize");
            $('body').removeClass('sidebar-icon');
        }
    });

    /* sidebar full */
    $('#sidebarfull').on('click', function () {
        if ($(this).is(':checked')) {
            $.removeCookie("sidebarsize");
            $('body').removeClass('sidebar-icon');
            $('body').removeClass('sidebar-compact');
        }
    });

    /* sidebar fill color */
    $('#sidebarFill').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("sidebarFill", 'sidebar-fill', {
                expires: 7
            });
            $('body').addClass('sidebar-fill');
        } else {
            $.removeCookie("sidebarFill");
            $('body').removeClass('sidebar-fill');
        }
    });



    /* more specious */
    $('#moderntouch').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("moderntouch", 'modern-touch', {
                expires: 7
            });
            $('body').addClass('modern-touch');
            if ($('body').hasClass('header-fixed-top') == true) {
                var headerheight = $('.header-container').outerHeight() + 15;
                $('.wrapper').css('padding-top', headerheight);
            }


        } else {
            $.removeCookie("moderntouch");
            $('body').removeClass('modern-touch');
            if ($('body').hasClass('header-fixed-top') == true) {
                var headerheight = $('.header-container').outerHeight() + 15;
                $('.wrapper').css('padding-top', headerheight);
            } else if ($('body').hasClass('wrapper-square') == true) {
                $('.wrapper').css('padding-top', '0');
            } else {
                $('.wrapper').css('padding-top', '15px');
            }
        }
    });

 

    /* fontsize*/
    $('#xsmallfs').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("fontsize", '13px', {
                expires: 7
            });
            $('body').css('font-size', '13px');
        }
    });
    $('#smallfs').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("fontsize", '14px', {
                expires: 7
            });
            $('body').css('font-size', '14px');
        }
    });
    $('#mediumfs').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("fontsize", '15px', {
                expires: 7
            });
            $('body').css('font-size', '15px');
        }
    });
    $('#largefs').on('click', function () {
        if ($(this).is(':checked')) {
            $.cookie("fontsize", '16px', {
                expires: 7
            });
            $('body').css('font-size', '16px');
        }
    });


    /* style color  */
    $('.style-picker').on('click', function () {
        $('.style-picker').removeClass('active')
        $(this).addClass('active')
        var currentstyle = $('#stylelink');
        var applystyle = $(this).attr('data-target');
        

        $.cookie("styleselected", applystyle, {
            expires: 7
        });
    });


});
