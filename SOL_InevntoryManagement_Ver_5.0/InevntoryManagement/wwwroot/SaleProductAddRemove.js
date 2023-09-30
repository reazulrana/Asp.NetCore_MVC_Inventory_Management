
function sweetalert(message) {

    sweetAlert("Oops...", "'" + message.toUpperCase() + "'", "warning")
}


//product add to prodcut list tabel


$("#btnAddProduct").click(function () {

    let uripath = $(this).data("url")
    var _product = product();
    //var pid = _product.ProductId;

    //if (pid == null || pid == undefined || pid=="") {
    //    alert("Product Not Selected From Search Table. Search The Product First")
    //    $("#txtsearchfield").focus();
    //    return;
    //}

    //$.ajax({
    //    url: uripath,
    //    method: 'POST',
    //    data: { productid: pid },
    //    dataType: "Json",
    //    success: function (data)
    //    {

    //        if (data.success == true)
    //        {
    //            alert(data.success);



    //            append_New_Row();
    //            return;
    //        }

    //    }


    //})

    //$("#txtTotalSell").val(ui.item.saleQty)
    //$("#txtTotalBalance").val(ui.item.balance)

    

   


    if (_product.TotalAmount == "" || _product.TotalAmount == "0" || _product.TotalAmount == isNaN) {
        alert("Total Price is '0'");
        return;
    }


    let balanceqty = parseInt(_product.balance)
    //let ttlsell = parseInt(_product.saleQty)
    let qty = parseInt(_product.Qty)
    let cumalitiveQty = (balanceqty - qty);
    if (cumalitiveQty < 0)
    {
        sweetalert("Your Selling Qty (" + qty + ") is larger Balance Qty (" + balanceqty + ") Exceed Qty (" + (qty - balanceqty) + ")")

        //alert()
        return
    }


    //check for duplicate row by ProductId
    // if product is Already Exist New Row Will Not Append To Product Table
    // if Product Not Found by ProductId Then Add New Row To The Product Table
    let table = $('#productlist');

    let tablerow = $('#productlist tr').length;
    let blnDuplicateRowCheck = false;
    if (tablerow > 0)
    {
        //alert(table.children("tr").length)
        $(table).children("tr").each(function (index, element)
        {
            
            let _tableproductid = $(this).children("td").eq(0).find("input").val();
            if (_product.ProductId == _tableproductid)
            {
                sweetalert("Your Selling Qty (" + qty + ") is larger Balance Qty (" + balanceqty + ") Exceed Qty (" + (qty - balanceqty) + ")")

                alert();
                blnDuplicateRowCheck = true;
                return
            }
           
        })
    }
    if (blnDuplicateRowCheck == false)
    {
        append_New_Row();
    }


  

 
})

//calculate Total Price with qty change
$("#txtProductQty").focus(function () {
    var val = $(this).val();
    if (isNaN(val)) {
        $(this).val('0');
    }



})

$("#txtProductQty").focusout(function () {
    var qty = $(this).val()
    var price = $('#txtProductSalePrice').val()

    var totalprice = qty * price;
    if (isNaN(totalprice)) {
        alert("Qty Is Not Number Please Type Number")
        $(this).focus();
    }

    $('#txtProductTotalAmount').val(qty * price);
})

//calculate Total Price with price change
$("#txtProductSalePrice").focus(function () {
    var val = $(this).val();
    if (isNaN(val)) {
        $(this).val('0');
    }



})

$("#txtProductSalePrice").focusout(function () {
    var qty = $(this).val()
    var price = $('#txtProductQty').val()

    var totalprice = qty * price;
    if (isNaN(totalprice)) {
        alert("Purchase Is Not Number Please Type Number")
        $(this).focus();
    }

    $('#txtProductTotalAmount').val(qty * price);
})


function ClearField()
{

    $("#txtsearchfield").val('')
    $("#txtProductId").val('')
    $("#txtProductCode").val('')
    $("#txtProductDescription").val('')

    $("#txtProductModel").val('')
    $("#txtProductSize").val('')
    $("#txtProductColor").val('')
    $(".pimage").attr("src", '')
    $("#txtImage").val('')
    $("#txtProductQty").val('0')
    $("#txtProductSalePrice").val('0')
    $("#txtProductTotalAmount").val('0')
}


function product() {
    var _product = {
        ProductId: $("#txtProductId").val(),
        Image: $("#txtImage").val(),
        Code: $("#txtProductCode").val(),
        Description: $("#txtProductDescription").val(),
        Model: $("#txtProductModel").val(),
        saleQty: $("#txtTotalSell").val(),
        balance: $("#txtTotalBalance").val(),

        Size: $("#txtProductSize").val(),
        Color: $("#txtProductColor").val(),
        Qty: $("#txtProductQty").val(),
        PurchasePrice: $("#txtProductSalePrice").val(),
        TotalAmount: $("#txtProductTotalAmount").val(),
    }
    return _product
}




//tr Remove from product table By Delete Button click
$("#productlist").on("click", "button", function () {


    //if Cashonpayment is larger Then Total Amout Of Product you will fail 
    //to remove product from Table
    //check the product you want to delete the Totalamount of 
    //the product is lower than cashonpayment amount 
        let amount = amountclass();
        let totalpartsamount = parseInt($(this).closest("tr").find("td:last").prev().text())

        let substractamount = (parseInt(amount.TotalAmount) - parseInt(totalpartsamount))
        let paymentoncash = parseInt(amount.PaymentOnCash);
        let result = (substractamount >= paymentoncash) ? true : false;
    if (result)
        {
        if (confirm("Do You Want to Remove Row")) {

            $(this).closest("tr").remove();
        }

        }
        else
        {
        //if (confirm("Row Can Not Remove Because PaymentOnCase Is Higer Than ProductCost (  Product Cost Is " + substractamount + " and CashOnPayment Is " + paymentoncash + "). Do You Wanto Delete Product By Force")) {

        //    $(this).closest("tr").remove();
        //}
        alert("Row Can Not Remove Because PaymentOnCase Is Higer Than ProductCost (  Product Cost Is " + substractamount + " and CashOnPayment Is " + paymentoncash + "). Do You Wanto Delete Product By Force")
            
    }
    //after remove row It will re calculate the products Total Amount
   //the function is Exist in saleAmount.js file
    calculateSaleProduct();
})

function append_New_Row() {
    let LastSl = $('#productlist tr').length + 1;
    let p = product();

    let _photopath = (p.Image == "" || p.Image == null) ? "/Projects/Images/DefaultImage/No_Image_Available.jpg" : "/Projects/Images/Product/" + p.Image


    
    let sl = '<td><input hidden name="ProductIds" type="text" value="' + p.ProductId + '"/>' + LastSl + '</td>';
    let Image = '<td> <input hidden name="Images" value="' + p.Image + '" />  <img src = "' + _photopath + '" height = 90 width = 90 /> </td > ';
    let Code = '<td> <input hidden name="Codes" value="' + p.Code + '" />' + p.Code + '</td>';
    let Description = '<td><input hidden name="Descriptions" value="' + p.Description + '" />' + p.Description + '</td>';
    let Model = '<td><input hidden name="Models" value="' + p.Model + '" />' + p.Model + '</td>';
    let Size = '<td><input hidden name="Sizes" value="' + p.Size + '" />' + p.Size + '</td>';
    let Color = '<td><input hidden name="Colors" value="' + p.Color + '" />' + p.Color + '</td>';
    let Qty = '<td> <input hidden name="Qtys" type="text" value="' + p.Qty + '"/>' + p.Qty + '</td>';
    let PurchasePrice = '<td> <input hidden name="Prices" type="text" value="' + p.PurchasePrice + '"/>' + p.PurchasePrice + '</td>';
    let TotalAmount = '<td>' + (p.Qty * p.PurchasePrice) + '</td>';
    let action = '<td><button type="button" class="btn btn-xs btn-danger delete_Product"><span><i class="mdi mdi-delete"></i></span></button></td>';



    var tr = '<tr id="' + sl + '">' + sl + Image + Code + Description + Model + Size + Color + Qty + PurchasePrice + TotalAmount + action + '</tr>'

    $('#productlist').append(tr);
    calculateSaleProduct();
    ClearField()


}


function ClearField() {
    $("#txtsearchfield").val('')
    $("#txtProductId").val('')
    $("#txtProductCode").val('')
    $("#txtProductDescription").val('')

    $("#txtProductModel").val('')
    $("#txtProductSize").val('')
    $("#txtProductColor").val('')
    $(".pimage").attr("src", '')
    $("#txtImage").val('')
    $("#txtProductQty").val('0')
    $("#txtProductSalePrice").val('0')
    $("#txtProductTotalAmount").val('0')
}