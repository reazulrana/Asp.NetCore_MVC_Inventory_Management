//product add to prodcut list tabel
$("#btnAddProduct").click(function () {

    var _product = product();
    if (_product.TotalAmount == "" || _product.TotalAmount == "0" || _product.TotalAmount == isNaN) {
        alert("Total Price is '0'");
        return;
    }
    append_New_Row();
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
    var price = $('#txtProductPurchasePrice').val()

    var totalprice = qty * price;
    if (isNaN(totalprice)) {
        alert("Qty Is Not Number Please Type Number")
        $(this).focus();
    }

    $('#txtProductTotalAmount').val(qty * price);
})

//calculate Total Price with price change
$("#txtProductPurchasePrice").focus(function () {
    var val = $(this).val();
    if (isNaN(val)) {
        $(this).val('0');
    }



})

$("#txtProductPurchasePrice").focusout(function () {
    var qty = $(this).val()
    var price = $('#txtProductQty').val()

    var totalprice = qty * price;
    if (isNaN(totalprice)) {
        alert("Purchase Is Not Number Please Type Number")
        $(this).focus();
    }

    $('#txtProductTotalAmount').val(qty * price);
})



function product() {
    var _product = {
        ProductId: $("#txtProductId").val(),
        Image: $("#txtImage").val(),
        Code: $("#txtProductCode").val(),
        Description: $("#txtProductDescription").val(),
        Model: $("#txtProductModel").val(),
        Size: $("#txtProductSize").val(),
        Color: $("#txtProductColor").val(),
        Qty: $("#txtProductQty").val(),
        PurchasePrice: $("#txtProductPurchasePrice").val(),
        TotalAmount: $("#txtProductTotalAmount").val(),
    }
    return _product
}




//tr Remove from product table By Delete Button click
$("#productlist").on("click", "button", function () {

    if (confirm("Do You Want to Remove Row")) {
        $(this).closest("tr").remove();
        calculatePurchageProduct();
    }
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
    calculatePurchageProduct();
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
    $("#txtProductPurchasePrice").val('0')
    $("#txtProductTotalAmount").val('0')
}