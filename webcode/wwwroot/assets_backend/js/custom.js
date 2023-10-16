
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




