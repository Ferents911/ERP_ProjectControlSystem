
$("#projectTypeSelect").change(function () {
    var selectedType = $("#projectTypeSelect").val();
    $("#selectedType").val(selectedType);
});

$(function () {
    $("#startDatePicker").datepicker();
});

$(function () {
    $("#endDatePicker").datepicker();
});

$(function () {
    $("#datepicker").datepicker();
});
    
