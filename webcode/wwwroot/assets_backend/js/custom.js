
$('.child-trigger').click(function () {
    $(this).parent().siblings(".dash-menu-itm").removeClass("open-child");
    $(this).parent().siblings(".dash-menu-itm").find(".submenu-wrap").slideUp(250);
    $(this).parent().toggleClass("open-child");
    $(this).next().slideToggle(250);
    return false;
});

$('.toggle-other').click(function () {
    $(this).parent().siblings().find(".cm-dropdown").slideUp(250);
    $(this).next().slideToggle(250);
    return false;
});


$('.dashtrigger-in').click(function(){
    $('body').toggleClass('mobile-open');
});
$('.add-link-btn').click(function () {
    $('.main-popup').css('display', 'flex');
    var a = SetFunction1();
    function SetFunction1() {
        setTimeout(function () {
            $('.popup-header h5 span.close-btn-popup').css('display', 'inline-block');
        }, 10000);
    }
});

$('.popup-header h5 span.close-btn-popup').click(function () {
    $('.main-popup').css('display', 'none');
    $(this).css('display', 'none');
});
$('.popup-header h5 span.close-btn-popup1').click(function () {
    $('.main-popup').css('display', 'none');
});


function copy() {
  var copyText = document.getElementById("custom_Clipboard");
  copyText.select();
  copyText.setSelectionRange(0, 99999);
  document.execCommand("copy");
  $('#copied-success').fadeIn(800);
  $('#copied-success').fadeOut(800);
}

function dhanucopyQR() {
    var copyText = document.getElementById("dhanu_QRClipboard");
    copyText.select();
    copyText.setSelectionRange(0, 99999);
    document.execCommand("copy");
    $('#dhanucopiedsuccess').fadeIn(800);
    $('#dhanucopiedsuccess').fadeOut(800);
}
function usdtcopyQR() {
    var copyText = document.getElementById("usdt_QRClipboard");
    copyText.select();
    copyText.setSelectionRange(0, 99999);
    document.execCommand("copy");
    $('#usdt-copied-success').fadeIn(800);
    $('#usdt-copied-success').fadeOut(800);
}


$('.wthdrebtn').click(function () {
    var tab_idel = $(this).attr('data-elgible');

    $('.wthdrebtn').removeClass('current');
    $('.tableTabStyle').removeClass('current');

    $(this).addClass('current');
    $("#" + tab_idel).addClass('current');
})


$('.u_notific_close').click(function(){
$(this).parent().parent().remove();
});

$('.upload-file').change(function() {
  $(this).addClass('uploded_main')
  var filename = $(this).val();
  var m = filename.match(/([^\/\\]+)$/);
  var filename_mn = m[1];
  $(this).next('.file-upload-name').html(filename_mn);
});

$( document ).ready(function() {
$( ".dash-menu-itm > a > .menu-text").each(function() {
  var hh =  $(this).outerHeight(true);
  $( this ).css({height: hh});
});

$('.child-trigger').click(function(){
$( ".submenu-wrap .menu-text").each(function() {
  var hh =  $(this).outerHeight(true);
  $( this ).css({height: hh});
});
});

});


$('#test').change(function () {
    if ($(this).is(":checked")) {
        $('.dss-right-section').addClass('new-Add-btnclass');
        $('.dss-right-section').addClass('noside-right-full');
        $('#dhanuPool').text("Trading Pool");
    } else {
        $('.dss-right-section').removeClass('new-Add-btnclass');
        $('.dss-right-section').removeClass('noside-right-full');
        $('#dhanuPool').text("Dhanu Pool");
    }
});
$('.dassboardPop').click(function () {
    $('.dassboardPop-section').addClass('Dasspopup-active')
})

$('.dass-off-icon-main').click(function () {
    $('.dassboardPop-section').removeClass('Dasspopup-active')
})

/*timer js*/
function makeTimer() {	
    //var registrationDate = new Date("23 November 2023 24:00:00 GMT+01:00");
    var registrationDate = $("#registration-date-time").text();
    var newDate = new Date(registrationDate);
    newDate = (Date.parse(newDate) / 1000);
    var now = new Date();
    var endDate = 30 * 86400;
    var NewDateTime = endDate + newDate;
    now = (Date.parse(now) / 1000);

    var timeLeft = NewDateTime - now;

    var days = Math.floor(timeLeft / 86400);
    var hours = Math.floor((timeLeft - (days * 86400)) / 3600);
    var minutes = Math.floor((timeLeft - (days * 86400) - (hours * 3600)) / 60);
    var seconds = Math.floor((timeLeft - (days * 86400) - (hours * 3600) - (minutes * 60)));

    if (days < "10") { days = "0" + days; }
    if (hours < "10") { hours = "0" + hours; }
    if (minutes < "10") { minutes = "0" + minutes; }
    if (seconds < "10") { seconds = "0" + seconds; }

    $("#days").html(days);
    $("#hours").html(hours);
    $("#minutes").html(minutes);
    $("#seconds").html(seconds);

}

setInterval(function () { makeTimer(); }, 500);


