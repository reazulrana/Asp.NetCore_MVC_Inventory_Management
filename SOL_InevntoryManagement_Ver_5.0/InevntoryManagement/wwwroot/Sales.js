

let url = "";
geturl();
function geturl() {
    url = $("#txtsearchfield").data("url");
}
//Autocomplete Section
$.ui.autocomplete.prototype._renderMenu = function (ul, items) {
    var self = this;
    //table definitions

    ul.append("<div class='divAutocomplete' style='height:200px; overflow-y:scroll; z-index:10000'><table class='prodcutAutocomplete table table-border'><thead class='bg-secondary text-white'><tr> <th>Sl</th> <th>Code</th> <th>Description</th> <th>Category</th> <th>Model</th> <th>Size</th> <th>Color</th> </tr></thead><tbody></tbody></table></div>");
    $.each(items, function (index, item) {
        self._renderItemData(ul, ul.find("table tbody"), item);
    });
};
$.ui.autocomplete.prototype._renderItemData = function (ul, table, item) {
    return this._renderItem(table, item).data("ui-autocomplete-item", item);
};
$.ui.autocomplete.prototype._renderItem = function (table, item) {

    //var items = JSON.stringify(item)
    return $("<tr class='ui-menu-item' role='presentation'></tr>")
        .attr("data-val", item.id) //this line for passing item to focus object and select object
        //.data("item.autocomplete", item)
        //item.length == isNaN ? 1 : (item.length + 1)
        //<tr> <th>Sl</th> <th>Code</th> <th>Description</th> <th>Category</th> <th>Model</th> <th>Size</th> <th>Color</th> </tr >
        .append("<td>" + ($(".prodcutAutocomplete tbody tr").length + 1) + "</td> <td>" + item.code + "</td> <td>" + item.description + "</td> <td>" + item.category + "</td> <td>" + item.model + "</td> <td>" + item.size + "</td> <td>" + item.color + "</td>")
        .appendTo(table);
};

//radion Button Code Description Model Change event

var searchfield = "model" // this parameter is used for search code description model autocomplete globally
$(".searchField").change(function () {
    searchfield = $(this).val();
    $("#txtsearchfield").focus();


})

$("#txtsearchfield").autocomplete({
    minLength: 1,
    focus: function (event, ui) {
        if (ui.item != undefined) {
            var photopath = "/Projects/Images/Product/";
            photopath = ui.item.photopath == null ? "/Projects/Images/DefaultImage/No_Image_Available.jpg" : photopath + ui.item.photopath

            // $("#txtImage").val(ui.item.photopath),
            $("#txtProductId").val(ui.item.value)

            $("#txtProductCode").val(ui.item.code)
            $("#txtProductDescription").val(ui.item.description)

            $("#txtProductModel").val(ui.item.model)
            $("#txtProductSize").val(ui.item.size)
            $("#txtProductColor").val(ui.item.color)
            $(".pimage").attr("src", photopath)
            $("#txtImage").val(ui.item.photopath)

        }
        return false;
    }, // end of focuas
    //you can write for select too
    select: function (event, ui) {
        var photopath = "/Projects/Images/Product/";
        photopath = ui.item.photopath == null ? "/Projects/Images/DefaultImage/No_Image_Available.jpg" : photopath + ui.item.photopath
        $("#txtProductCode").val(ui.item.code),
            $("#txtProductId").val(ui.item.value),
            $("#txtProductDescription").val(ui.item.description),
            $("#txtProductModel").val(ui.item.model),
            $("#txtProductSize").val(ui.item.size),
            $("#txtProductColor").val(ui.item.color),
            $(".pimage").attr("src", photopath)
        $("#txtImage").val(ui.item.photopath)
        //searchfield = "";
        return false
    },
    //source: projects,
    source: function (request, response) {
        $.ajax({
            url: url,
            method: "Get",
            data: { term: request.term, searchField: searchfield },
            dataType: "JSON",
            success: function (data) {
                var starttable = '<table>'
                var endtable = '</table>'
                var td = '<td> Rana </td>';
                var tr = '<tr>' + td + '</tr>'
                var table = starttable + tr + endtable
                response(data.output)
            },
            error: function (err) {

            }
        }) //end of ajax

    } // end of source bracket


})