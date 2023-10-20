
$('.trigger-in').click(function(){
  $('body').toggleClass('mobile-open');
  $('.custom-menu-wrap').slideToggle(250);
});

$(window).scroll(function(){
  if ($(this).scrollTop() >= 1) {
      $('body').addClass('fixed-header');
  }
  else {
      $('body').removeClass('fixed-header');
  }
});

$('.card-header').click(function(){
  $(this).parent().siblings().find('.card-header').removeClass('active');
  $(this).parent().siblings().find('.faq-collapse').slideUp(250);
  $(this).toggleClass('active');
  $(this).next().slideToggle(250);
});

$('.menu-item a').click(function(){
var link = $(this).attr('href');
var posi = $(link).offset().top-82;
$('body,html').animate({scrollTop:posi},800);
});

$('.faq-sec .card-header').click(function () {
    $(this).parent().siblings().find('.card-body-text').slideUp(300)
});

$('.slick-sliderItem-wrap').slick({
    dots: false,
    arrow: true,
    infinite: false,
    speed: 300,
    slidesToShow: 5,
    slidesToScroll: 1,
    responsive: [
      {
        breakpoint: 1024,
        settings: {
          slidesToShow: 3
        }
      },
      {
        breakpoint: 500,
        settings: {
          slidesToShow: 2
        }
      }
    ]
  });

  $('.traders-sec').slick({
    dots: false,
    arrow: true,
    infinite: true,
    speed: 300,
    slidesToShow: 3,
    slidesToScroll: 1,
    responsive: [
      {
        breakpoint: 767,
        settings: {
          slidesToShow: 2
        }
      },
      {
        breakpoint: 600,
        settings: {
          slidesToShow: 1
        }
      }
    ]
  });

  $('.team-section').slick({
    dots: false,
    arrow: true,
    infinite: true,
    speed: 300,
    slidesToShow: 3,
    slidesToScroll: 1,
    responsive: [
      {
        breakpoint: 767,
        settings: {
          slidesToShow: 2
        }
      },
      {
        breakpoint: 600,
        settings: {
          slidesToShow: 1
        }
      }
    ]
  });

  $('.newer-post-all').slick({
    dots: false,
    arrow: true,
    infinite: true,
    speed: 300,
    slidesToShow: 5,
    slidesToScroll: 1,
    responsive: [
      {
        breakpoint: 992,
        settings: {
          slidesToShow: 4
        }
      },
      {
        breakpoint: 767,
        settings: {
          slidesToShow: 3
        }
      },
      {
        breakpoint: 600,
        settings: {
          slidesToShow: 2
        }
      },
      {
        breakpoint: 400,
        settings: {
          slidesToShow: 1
        }
      }
    ]
  });

  



var a = 0;
$(window).scroll(function () {
    var oTop = $(".section-cprogress").offset().top - window.innerHeight;
    if (a == 0 && $(window).scrollTop() > oTop) {
        $(".counte").each(function () {
            var $this = $(this),
                countTo = $this.attr("data-number");
            $({
                countNum: $this.text()
            }).animate(
                {
                    countNum: countTo
                },
                {
                    duration: 3000,
                    easing: "swing",
                    step: function () {
                        $this.text(
                            Math.ceil(this.countNum).toLocaleString("en")
                        );
                    },
                    complete: function () {
                        $this.text(
                            Math.ceil(this.countNum).toLocaleString("en")
                        );
                    }
                }
            );
        });
        a = 1;
    }
});



  // $(window).on('load', function() { 
  //   $(".loader").delay(9000).fadeOut(900);
  //   $("#overlayer").delay(9000).fadeOut(1000);
  // })


$('.blogSlider').slick({
    dots: true,
    arrows: false,
    infinite: false,
    autoplay: true,
    autoplaySpeed: 5000,
    fade: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
});

$('.blogSliderPost').slick({
    dots: true,
    arrows: false,
    infinite: false,
    autoplay: true,
    autoplaySpeed: 5000,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
});



//const modalBox = document.querySelector(".modal-container");
//const modalBtn = document.querySelector(".modal-btn");
//const closeBtn = document.querySelector(".close-btn");
//const openSecMod = document.querySelector(".openModel");
//const secondModel = document.querySelector(".modal-content.secondModel");
//const firstModel = document.querySelector(".modal-content.firstModel");

//modalBtn.addEventListener("click", () => {
//    modalBox.style = "display: block;";
//});
//openSecMod.addEventListener("click", () => {
//    secondModel.style = "display: block;";
//    firstModel.style = "display: none;";
//});

//closeBtn.addEventListener("click", () => {
//    modalBox.style = "display: none;";
//});

//window.addEventListener("click", (e) => {
//    if (e.target == modalBox) {
//        modalBox.style = "display: none;";
//    }
//});


//$('.modal-btn').click(function () {
//    $('.modal-container').addClass('popup-active')
//})

// $('.close-btn, .closeBtnNew').click(function(){
//   // $('.modal-container').removeClass('popup-active')
//   // $('.modal-container').removeClass('secondry-popup-active')
// })

$('.openModel').click(function () {
    $('.modal-container').addClass('secondry-popup-active')
})



