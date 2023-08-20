

function Create_record_with_ajax(url, method, data, dataType, appendElement, dropdownName, fieldNamtToEmpty=null, hideElement=null) {

    $.ajax({
        url: url,
        method: method,
        data: data,
        dataType: dataType,
        success: function (data) {

            if (data.success == true) {
                    
                    if (dropdownName.toLocaleLowerCase() == "category".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.cType + '</option>'
                        $(appendElement).append(option);

                    }

                    else if (dropdownName.toLocaleLowerCase() == "brand".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.brandName + '</option>'
                        $(appendElement).append(option);
                    }

                    else if (dropdownName.toLocaleLowerCase() == "model".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.modelName + '</option>'

                        $(appendElement).append(option);
                    }

                    else if (dropdownName.toLocaleLowerCase() == "Size".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.productSize + '" selected="selected">' + data.output.productSize + '</option>'

                        $(appendElement).append(option);
                }

                    else if (dropdownName.toLocaleLowerCase() == "Vendor".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.vendorName + '</option>'

                        $(appendElement).append(option);
                }

                    else if (dropdownName.toLocaleLowerCase() == "Manufacture".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.manufactureName + '</option>'

                        $(appendElement).append(option);
                }
                else if (dropdownName.toLocaleLowerCase() == "Bin".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.binNo + '</option>'

                    $(appendElement).append(option);
                }
                else if (dropdownName.toLocaleLowerCase() == "Color".toLocaleLowerCase()) {
                    var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.colorName + '</option>'

                    $(appendElement).append(option);
                }

                    else if (dropdownName.toLocaleLowerCase() == "Measurement".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.measurements + '</option>'

                        $(appendElement).append(option);
                }
                    else if (dropdownName.toLocaleLowerCase() == "Source".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.sourceName + '</option>'

                        $(appendElement).append(option);
                }
                else if (dropdownName.toLocaleLowerCase() == "Branch".toLocaleLowerCase()) {
                    var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.name + '</option>'

                    $(appendElement).append(option);
                }
                    else if (dropdownName.toLocaleLowerCase() == "PaymentType".toLocaleLowerCase())
                    {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.payments + '</option>'

                        $(appendElement).append(option);
                }
                    else if (dropdownName.toLocaleLowerCase() == "SaleFrom".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.saleFrom + '</option>'

                        $(appendElement).append(option);
                    }
                    else if (dropdownName.toLocaleLowerCase() == "SaleType".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.types + '</option>'

                        $(appendElement).append(option);
                    }



                alert(data.msg);
                if (fieldNamtToEmpty != null)
                {
                    $(fieldNamtToEmpty).val('')
                }

                if (hideElement != null)
                {
                    $(hideElement).hide();
                }

            }
            else {
                alert(data.msg);

            }
        },
        error: function (err) {
            alert("You Call Error Functioon");
            return false
        }
    })

    return true

}
            //end of axaj call function Name: Create_record_with_ajax






//Branch Create function
//Create Branch show hide
$("#btnAddBranch").click(function () {

    $("#divBranch").toggle();

})


//function createBranch(branch, contact, incharge)
//{
   

//}

$("#btnSaveBranch").click(function () {

    var branch = $("#txtSaveBranch").val();
    var contact = $("#txtSaveContact").val();
    var incharge = $("#txtSaveBranchIncharge").val();
    var url = $(this).data("request-url");

    if (branch == "" || branch == null || branch == undefined) {
        alert("Branch Field is empty")
        $("#txtSaveBranch").focus();
        return;
    }

    var data = {
        branch: branch,
        contact: contact,
        incharge: incharge
    }

        
    Create_record_with_ajax(url = url, method = "POST", data = data, dataType = "JSON", appendElement = ".find_Branch", dropdownName = "Branch", fieldNamtToEmpty = "#txtSaveBranch", hideElement = "#divBranch")

    $("#txtSaveContact").val('');
    $("#txtSaveBranchIncharge").val('');

})




/*create vendor*/


//Vendor show hide section
$("#btnAddVendor").click(function () {
    $("#divVendor").toggle();

})

$("#btnSaveVendor").click(function () {
    var vendor = $("#txtSaveVendor").val();
    var vendoraddress = $("#txtSaveVendorAddress").val();
    var vendorcontact = $("#txtSaveVendorContact").val();
    var url = $(this).data("request-url");

    if (IsEmptyInputField(vendor) == true) {
        sweetalert("Vendor Is Empty")
        $(vendor).focus();
    }

    var data = {
        vendor: vendor,
        vendoraddress: vendoraddress,
        vendorcontact: vendorcontact
    }


    Create_record_with_ajax(url = url, method = "Post", data = data, dataType = "JSON", appendElement = ".find_Vendor", dropdownName = "Vendor", "#txtSaveVendor", "#divVendor")
    $("#txtSaveVendorAddress").val('');
    $("#txtSaveVendorContact").val('');



})




//validate input field

//checl if input text field is empty
function IsEmptyInputField(field) {
    var val = field
    var blnflag = false
    if (val == "" || val === undefined || val == null) {
        blnflag = true

    }
    return blnflag
}





//Source section
//show div for create Source
$("#btnAddSource").click(function () {
    $("#divSource").toggle();

})

//create Source
$('#btnSaveSource').click(function () {
    var val = $("#txtSaveSource").val();
    var url=$(this).data("request-url")
    if (val === undefined || val == "" || val == null) {
        //alert("Enter Source First");
        sweetAlert("Source Field is Blank Please Enter Source First");
        $("#txtSaveSource").focus();
        return;
    }

    var data = {
        source: val
    }

    Create_record_with_ajax(url = url, method = "POST", data = data, dataType = "JSON", appendElement = ".find_Source", dropdownName = "Source", fieldNamtToEmpty = "#txtSaveSource", hideElement = "#divSource")
})





//create Source
$('#btnSavePaymentType').click(function () {
    var val = $("#txtSavePaymentType").val();
    var url = $(this).data("request-url")
    if (val === undefined || val == "" || val == null) {
        //alert("Enter Source First");
        sweetAlert("Payment Type Field is Blank Please Enter Source First");
        $("#txtSavePaymentType").focus();
        return;
    }

    var data = {
        paymenttype: val
    }

    Create_record_with_ajax(url = url, method = "POST", data = data, dataType = "JSON", appendElement = ".find_PaymentType", dropdownName = "PaymentType", fieldNamtToEmpty = "#txtSavePaymentType", hideElement = "#divPaymentType")
})




//btn add salefrom
$("#btnAddSaleFrom").click(function () {
    $("#divSaleFrom").toggle();

})




//create SaleFrom
$('#btnSaveSaleFrom').click(function () {
    var val = $("#txtSaveSaleFrom").val();
    var url = $(this).data("request-url")
    if (val === undefined || val == "" || val == null) {
        //alert("Enter Source First");
        sweetAlert("Sale From Field is Blank Please Enter Source First");
        $("#txtSaveSaleFrom").focus();
        return;
    }

    var data = {
        SaleFrom: val
    }

    Create_record_with_ajax(url = url, method = "POST", data = data, dataType = "JSON", appendElement = ".find_Salefrom", dropdownName = "SaleFrom", fieldNamtToEmpty = "#txtSaveSaleFrom", hideElement = "#divSaleFrom")
})




//btn add salefrom
$("#btnAddSaleType").click(function () {
    $("#divSaleType").toggle();

})




//create SaleFrom
$('#btnSaveSaleType').click(function () {
    var val = $("#txtSaveSaleType").val();
    var url = $(this).data("request-url")
    if (val === undefined || val == "" || val == null) {
        //alert("Enter Source First");
        sweetAlert("Sale Type Field is Blank Please Enter Source First");
        $("#txtSaveSaleType").focus();
        return;
    }

    var data = {
        SaleType: val
    }

    Create_record_with_ajax(url = url, method = "POST", data = data, dataType = "JSON", appendElement = ".find_SaleType", dropdownName = "SaleType", fieldNamtToEmpty = "#txtSaveSaleType", hideElement = "#divSaleType")
})
