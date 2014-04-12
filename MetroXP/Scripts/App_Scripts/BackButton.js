
$(function () {
    $('.history-back').on('click', function (e) {        
        e.preventDefault();
        History.back();
        //if (History.getCurrentIndex() == 0) {
        //    History.pushState(null, null, "/Home/Index");
        //}
        //else {
        //    History.back();
        //}                
    })   
});
