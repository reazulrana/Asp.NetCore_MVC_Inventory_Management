

$(".searchcustomer").change(function () {


    let id = $(this).find("option:selected").val();
    let url = $(this).data("customerfindurl")
    $.ajax({
        url: url,
        method: "GET",
        data: { id: id },
        dataType: "Json",
        success: function (data) {

            
            if (data.blnmessage == true)
            {
                $(".txtcustomerid").val(data.output.id);
                $(".txtcustname").val(data.output.custName);
                $(".txtcontact").val(data.output.contact);
                $(".txtaddress").val(data.output.address);
            }

        },
        error: function (err)
        {
            alert("There Somthing Wrong on Searchg Customer");
        }



    }) //end of ajax

})

