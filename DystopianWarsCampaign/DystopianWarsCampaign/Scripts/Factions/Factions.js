$(function () {
    function tally(selector) {
        $(selector).each(function () {
            var total = 0,
                column = $(this).siblings(selector).andSelf().index(this);
            $(this).parents().prevUntil(':has(' + selector + ')').each(function () {
                total += parseFloat($('td.sum:eq(' + column + ')', this).html()) || 0;
            })
            $(this).html(total);
        });
    }
    tally('td.subtotal');
});