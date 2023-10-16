
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
  var hh =  $(this).height();
  $( this ).css({height: hh});
});

$('.child-trigger').click(function(){
$( ".submenu-wrap .menu-text").each(function() {
  var hh =  $(this).outerHeight(true);
  $( this ).css({height: hh});
});
});

});








