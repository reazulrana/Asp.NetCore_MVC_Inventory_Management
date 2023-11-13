


$('button[name="btnSave"]').click(function (e) {

    let amount = amountclass();

    let dues = parseInt(amount.Dues);
    let payemntoncash = parseInt(amount.PaymentOnCash);
    let paymenttype = $("#PaymentTypeId").find("option:selected").text();


    //if payment type is cash and duse greater than 0 stop submitting form
    //check for Due payment
    if (dues > 0 && paymenttype.toLowerCase() == "cash".toLowerCase()) {
        alert("You have not paid full payment. you have due amount is (" + dues + ") Please Pay full payment Payment Type from Payment Type List and save Record");

        e.preventDefault();

    }
    //if payment type is due and and due is 0 or less than 0  stop submitting form
    //check for full payment

    else if (dues <= 0 && (paymenttype.toLowerCase() == "dues".toLowerCase() || paymenttype.toLowerCase() == "due".toLowerCase()))
    {
        alert("You have paid full payment. you have due amount is (" + dues + ")  Please Select 'cash' Payment Type from Payment Type List and save Record");

        e.preventDefault();

    }

    else if (payemntoncash <= 0)
    {
        alert("Payment on Cash is 0");
        e.preventDefault();

    }






})






//$("#PaymentTypeId").change(function () {

//    let option = $(this).find('option:selected').text();
//    alert(option);
//})

$("#PaymentOnCash").change(function () {
    let amountbill = amountclass()
    $("#Dues").val((amountbill.NetAmount - amountbill.PaymentOnCash))



});
$("#Discount").change(function () {
    let amountbill = amountclass()
    $("#NetAmount").val((amountbill.GrossAmount - amountbill.Discount))
    amountbill = amountclass() //after update "#NetAmount" field get update instace of  amountclass()
    $("#Dues").val((amountbill.NetAmount - amountbill.PaymentOnCash))

})

$("#Transport").change(function () {
    let amountbill = amountclass()
    let totalbill = 0

    totalbill = parseInt((parseInt(amountbill.TotalAmount) + parseInt(amountbill.Transport) + parseInt(amountbill.Others)))
    let netamount = totalbill;
    $("#GrossAmount").val(totalbill)
    $("#NetAmount").val(netamount)
    $("#Dues").val((netamount - amountbill.PaymentOnCash))
})

$("#Others").change(function () {
    let amountbill = amountclass()
    let totalbill = 0

    totalbill = parseInt((parseInt(amountbill.TotalAmount) + parseInt(amountbill.Transport) + parseInt(amountbill.Others)))
    let netamount = totalbill;

    $("#GrossAmount").val(totalbill)
    $("#NetAmount").val(netamount)

    $("#Dues").val((netamount - amountbill.PaymentOnCash))


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
function calculateSaleProduct() {
    let tr = $("#productlist tr")
    
    $("#Dues").val("0");
    $("#GrossAmount").val("0");
    $("#NetAmount").val("0");
    

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
        $("#Dues").val(parseInt(netamount) - parseInt(_amountclass.PaymentOnCash))
    }
    else {
        // if no tr found in table body and  afete update amount cost bill
        //let amounts = amountclass();
        $("#GrossAmount").val(parseInt($("#Transport").val()) + parseInt($("#Others").val()))

        $("#NetAmount").val(parseInt($("#GrossAmount").val()) - parseInt($("#Discount").val()))

    }


}


//btnAddPaymentType
$("#btnAddPaymentType").click(function () {
    $("#divPaymentType").toggle()

})