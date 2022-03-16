$(document).ready(function(){
    // responsiveMenu
    $('.dropdown-toggle').on('click', function(e) {
        e.stopPropagation();
        e.preventDefault();
  
        var self = $(this);
    if (self.is('.disabled, :disabled')) {
          return false;
        }
        self.parent().toggleClass("open");
    });
  
    $(document).on('click', function(e) {
        if ($('.dropdown').hasClass('open')) {
          $('.dropdown').removeClass('open');
        }
    });
  
      $('.nav-btn.nav-slider').on('click', function() {
        $('.overlay').show();
        $('nav').toggleClass("open");
      });
  
      $('.overlay').on('click', function() {
        if ($('nav').hasClass('open')) {
          $('nav').removeClass('open');
        }
        $(this).hide();
    });
    // responsiveMenu
    // slider-product
    if ($('.swiper-container-product').length) {
      var swiper = new Swiper('.swiper-container-product', {
        slidesPerView: 4,
        centeredSlides: true,
        loop: true,
        autoplay: {
          delay: 5000,
          disableOnInteraction: false,
        },
        navigation: {
          nextEl: '.swiper-button-next',
          prevEl: '.swiper-button-prev',
        },
        keyboard: {
          enabled: true,
        },
        breakpoints: {
          300: {
            slidesPerView: 1,
            spaceBetween: 1,
            allowSlidePrev: true,
            allowSlideNext: true,
            mousewheel: true,
            keyboard: true
          },
          470: {
            slidesPerView: 1,
            spaceBetween: 5,
            allowSlidePrev: true,
            allowSlideNext: true,
            mousewheel: true,
            keyboard: true
          },
          640: {
            slidesPerView: 2,
            spaceBetween: 10,
            allowSlidePrev: true,
            allowSlideNext: true,
            mousewheel: true,
            keyboard: true
          },
          768: {
            slidesPerView: 3,
            spaceBetween: 3,
            allowSlidePrev: true,
            allowSlideNext: true,
            mousewheel: true,
            keyboard: true
          },
          1024: {
            slidesPerView: 4,
            spaceBetween: 4,
            allowSlidePrev: true,
            allowSlideNext: true,
            mousewheel: true,
            keyboard: true
          },
          1400: {
            slidesPerView: 5,
            spaceBetween: 5,
            allowSlidePrev: true,
            allowSlideNext: true,
            mousewheel: true,
            keyboard: true
          },
        }
      });
    }
    // slider-product
    // sidebar-sticky
    if ($('.sticky-sidebar').length) {
      $('.sticky-sidebar').theiaStickySidebar();
    }
    // scrolltop
    $(document).on("scroll",function(){
      var st=$(this).scrollTop();
      if(st>200){
          $(".scrolltop").fadeIn(300,"swing");
      }
      else if(st<200){
          $(".scrolltop").fadeOut(300,"swing");
      }
    });
    $(".scrolltop").on("click",function(){
      $("html,body").animate({scrollTop:"0px"},1000,"swing");
    });
});