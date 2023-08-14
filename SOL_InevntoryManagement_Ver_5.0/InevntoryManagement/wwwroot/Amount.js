
$("#PaymentOnCash").change(function () {
    let amountbill = amountclass()
    $("#Dues").val((amountbill.TotalAmount - amountbill.PaymentOnCash))



});
$("#Discount").change(function () {
    let amountbill = amountclass()
    $("#NetAmount").val((amountbill.GrossAmount - amountbill.Discount))


})

$("#Transport").change(function () {
    let amountbill = amountclass()
    let totalbill = 0

    totalbill = parseInt((parseInt(amountbill.TotalAmount) + parseInt(amountbill.Transport) + parseInt(amountbill.Others)))
    $("#GrossAmount").val(totalbill)
    $("#NetAmount").val(totalbill)
})

$("#Others").change(function () {
    let amountbill = amountclass()
    let totalbill = 0

    totalbill = parseInt((parseInt(amountbill.TotalAmount) + parseInt(amountbill.Transport) + parseInt(amountbill.Others)))
    $("#GrossAmount").val(totalbill)
    $("#NetAmount").val(totalbill)

})


function amountclass() {
    let _amount = {
        TotalAmount: $("#TotalAmount").val(),
        PaymentOnCash: $("#PaymentOnCash").val(),
        Dues: $("#Dues").val(),
        Transport: $("#Transport").val(),
        Others: $("#Others").val(),
        GrossAmount: $("#GrossAmount").val(),
        Discount: $("#Discount").val(),
        NetAmount: $("#NetAmount").val(),
        PaymentTypeId: $("#PaymentTypeId").val(),


    }

    return _amount
}


//calculate total product purchage price amount
function calculatePurchageProduct() {
    let tr = $("#productlist tr")
    $("#TotalAmount").val('0')
    if ($(tr).length > 0) {
        var amount = 0;
        $(tr).each(function (i, item) {
            amount = (amount + parseInt($(this).find("td:last").prev().text()));
        })

        $("#TotalAmount").val(amount) //product cost


        //Call amountclass To Get Update Total AMount After Adding New Product   
        let _amountclass = amountclass();

        let grossamount = (parseInt(_amountclass.TotalAmount) + parseInt(_amountclass.Transport) + parseInt(_amountclass.Others))
        let netamount = (grossamount - parseInt(_amountclass.Discount))
        $("#GrossAmount").val(grossamount)
        $("#NetAmount").val(netamount)
        $("#Dues").val(parseInt(_amountclass.TotalAmount) - parseInt(_amountclass.PaymentOnCash))
    }


}