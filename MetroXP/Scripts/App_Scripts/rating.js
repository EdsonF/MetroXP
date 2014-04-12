$(function () {  
    config = {
        score: 2,
        stars: 5,
        showHint: true,
        showScore: true,
        click: function (value, rating) {
            //alert("Rating clicked with value " + value);
            rating.rate(value);
        }
    };

    $(".rating").rating(config);    

})