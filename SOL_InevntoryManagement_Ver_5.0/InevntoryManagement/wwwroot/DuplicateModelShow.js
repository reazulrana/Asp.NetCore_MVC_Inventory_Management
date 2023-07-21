

function Create_record_with_ajax(url, method, data, dataType, appendElement, dropdownName, fieldNamtToEmpty, hideElement) {

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
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.productSize + '</option>'

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



                alert(data.msg);

                $(fieldNamtToEmpty).val('')
                $(hideElement).hide();

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
