$(function () {
    alert('settings up date pickers');
    $.validator.addMethod('date',
    function (value, element) {
        if (this.optional(element)) {
            return true;
        }
        var ok = true;
        try {
            $.datepicker.parseDate('yyyy/mm/dd', value);
        }
        catch (err) {
            ok = false;
        }
        return ok;
    });
    $(".datefield").datepicker({ dateFormat: 'yyyy/mm/dd', changeYear: true });
});