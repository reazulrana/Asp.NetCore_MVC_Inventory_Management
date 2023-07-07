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