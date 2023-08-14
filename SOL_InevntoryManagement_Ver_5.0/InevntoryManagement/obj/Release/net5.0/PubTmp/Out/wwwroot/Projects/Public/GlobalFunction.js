function pass_modal_value(object,inputname1, inputname2)
{
    var id = $(object).attr("data-id");
    var name = $(object).attr("data-ctype");
    var ele = {
        'id': $(this).attr("data-id"),
        'name': $(this).attr("data-ctype")
    }


    $(".deleteManufactureName").val(ele.name);
    $(".deleteManufactureid").val(ele.id);

    $(inputname1).val(id);
    $(inputname2).val(name);


}


//sweetaler

function sweetalert(message)
{
    sweetAlert("Oops...", "You Enter ( " + message.toUpperCase() + " ) Model Is Dulicate", "error")
}


//toastr

function toastrdanger(message) {
    toastr.error(message, "Top Right", {
        positionClass: "toast-top-right",
        timeOut: 5e3,
        closeButton: !0,
        debug: !1,
        newestOnTop: !0,
        progressBar: !0,
        preventDuplicates: !0,
        onclick: null,
        showDuration: "300",
        hideDuration: "1000",
        extendedTimeOut: "1000",
        showEasing: "swing",
        hideEasing: "linear",
        showMethod: "fadeIn",
        hideMethod: "fadeOut",
        tapToDismiss: !1
    })
}
