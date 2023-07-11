

function Create_record_with_ajax(url, method, data, dataType, appendElement, dropdownName) {

    $.ajax({
        url: url,
        method: method,
        data: data,
        dataType: dataType,
        success: function (data) {


            
         

            console.log(data);

            if (data.success == true) {

                    
                    if (dropdownName.toLocaleLowerCase() == "category".toLocaleLowerCase()) {
                        var option = '<option value="' + data.output.id + '" selected="selected">' + data.output.cType + '</option>'
                        $(appendElement).append(option);

                    }

                    else if (dropdownName.toLocaleLowerCase() == "brand".toLocaleLowerCase()) {
                        var option = '<option value="' + item.id + '" selected="selected">' + item.brandName + '</option>'
                        $(appendElement).append(option);
                    }

                    else if (dropdownName.toLocaleLowerCase() == "model".toLocaleLowerCase()) {
                        var option = '<option value="' + item.id + '" selected="selected">' + item.modelName + '</option>'

                        $(appendElement).append(option);
                    }

                    else if (dropdownName.toLocaleLowerCase() == "Size".toLocaleLowerCase()) {
                        var option = '<option value="' + item.id + '" selected="selected">' + item.productSize + '</option>'

                        $(appendElement).append(option);
                    }

            }
            else {
                alert("Data Not Found In Database")

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
