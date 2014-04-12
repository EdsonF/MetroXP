
$(function () {

    var contentShell = $('#bodyContent');

    var History = window.History, State = History.getState();

    function flipView() {
        $('#bodyContent').rotate3Di('360', 250);               
    }

    function refreshWindow() {
        $.ajax({
            url: "",
            context: document.body,
            success: function (s, x) {
                $(this).html(s);
            }
        });
    }
    
    $(".ajaxLink").on('click', function (e) {        
        e.preventDefault();        
        var url = $(this).data('href');
        var title = $(this).data('title');
        History.pushState(null, title, url);
    });

    History.Adapter.bind(window, 'statechange', function () {
        State = History.getState();
        if (State.url === '') {
            return;
        }
        navigateToURL(State.url);
    });

    function navigateToURL(url) {        
        $('#bodyContent').showLoading();
        $.ajax({
            type: "GET",
            url: url,
            dataType: "html",
            success: function (data, status, xhr) {
                contentShell.hideLoading();
                $('#bodyContent').hide();
                contentShell.html(data);                
                $('#bodyContent').fadeIn(1000);
                //flipView();
            },
            error: function (xhr, status, error) {
                contentShell.hideLoading();
                alert("Error loading Page.");
            }
        });
    }

    window.prettyPrint && prettyPrint();

    if ($('nav > .side-menu').length > 0) {
        var side_menu = $('nav > .side-menu');
        var fixblock_pos = side_menu.position().top;
        $(window).scroll(function () {
            if ($(window).scrollTop() > fixblock_pos) {
                side_menu.css({ 'position': 'fixed', 'top': '65px', 'z-index': '1000' });
            } else {
                side_menu.css({ 'position': 'static' });
            }
        })
    }

});

function headerPosition() {
    if ($(window).scrollTop() > $('header').height()) {
        $("header .navigation-bar")
            .addClass("fixed-top")
            .addClass(" shadow")
        ;
    } else {
        $("header .navigation-bar")
            .removeClass("fixed-top")
            .removeClass(" shadow")
        ;
    }
}

$(function () {
    setTimeout(function () { headerPosition(); }, 100);
})

$(window).scroll(function () {
    headerPosition();
});

METRO_AUTO_REINIT = true;