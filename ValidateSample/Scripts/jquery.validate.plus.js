$.validator.addMethod("banword", function (value, element, param) {
    if (value === false) {
        return true;
    }
    if (value.indexOf(param) !== -1) {
        return false;
    } else {
        return true;
    }
});
$.validator.unobtrusive.adapters.addSingleVal("banword", "input");