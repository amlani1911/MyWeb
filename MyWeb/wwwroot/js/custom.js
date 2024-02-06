$(document).ready(function () {
    ShowCategoryData();
});

function closeModal() {
    $("#categoryModal").modal('hide');
}

function ShowCategoryData() {
    $("#categoryModal").modal('hide');
    $.ajax({
        url: '/Ajax/Categories',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8;',
        success: function (result, status, xhr) {
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' +item.id+ '</td>';
                object += '<td>' +item.categoryName+ '</td>';
                object += '<td><img src="' + item.categoryImageUrl + '" width = "150px"></td>';
                object += '<td><a class="btn btn-outline-primary" onclick="Edit(' + item.id +')"><i class="bi bi-pencil-square"></i>Edit</a> || <a class="btn btn-outline-info"><i class="bi bi-eye"></i>Details</a> <a class="btn btn-danger" onclick="Delete(' +item.id+ ')" ><i class="bi bi-trash"></i>Delete</a></td>'
                object+= '</tr>';
            });
            $("#table_data").html(object);
        },
        error: function () {
            alert("Data can't get");
        }
    })
};

$("#btnAddCategory").click(function () {
    ClearModal();
    $("#categoryModal").modal('show');
    $("#catId").hide();
    $("#addCategory").css('display', 'block');
    $("#updateCategory").css('display', 'none');
    $("#CategoryHeading").text("Add a new Category");
})

function AddCategory() {
    var objData = {
        CategoryName: $("#Name").val(),
        CategoryImageUrl: $("#Imageurl").val()
    }
    $.ajax({
        url: '/Ajax/AddCategory',
        type: 'POST',
        data: JSON.stringify(objData),
        contentType: 'application/json',
        dataType: 'json',
        success: function () {
            //alert("Data Saved");
            ClearModal();
            ShowCategoryData();
            hideModal();
            //console.log(result);
        },
        error: function () {
            alert("Data can't saved");
        }
    });
}
function Delete(id) {
    if (confirm("Are you really want to delete the record of Id: "+id+"?")) {
        $.ajax({
            url: '/Ajax/Delete?id=' + id,
            success: function () {
                //alert('Record Deleted');
                ShowCategoryData();
            },
            error: function () {
                alert("Record Can't be deleted");
            }
        })
    }
}

function Edit(id) {
    $.ajax({
        url: '/Ajax/Edit?id=' + id,
        type: 'GET',
        contentType: 'application/json',
        dataType: 'json',
        cache: false,
        success: function (response) {
            $("#categoryModal").modal('show');
            $("#catId").show();
            $("#CategoryId").val(response.id);
            $("#Imageurl").val(response.categoryImageUrl);
            $("#Name").val(response.categoryName);
            $("#addCategory").css('display', 'none');
            $("#updateCategory").css('display', 'block');
            $("#CategoryHeading").text("Update a Category");
        },
        error: function () {
            alert("Data not found");
        }
    })
}
function UpdateCategory() {
    var objData = {
        Id: $("#CategoryId").val(),
        CategoryName: $("#Name").val(),
        CategoryImageUrl: $("#Imageurl").val()
    }
    $.ajax({
        url: '/Ajax/Update',
        type: 'POST',
        data: JSON.stringify(objData),
        contentType: 'application/json',
        dataType: 'json',
        success: function () {
            //alert("Data Saved");
            ClearModal();
            ShowCategoryData();
            hideModal();
            //console.log(result);
        },
        error: function () {
            alert("Data can't saved");
        }
    });
}
    function hideModal() {
        $("#categoryModal").modal('hide');
    }

    function ClearModal() {
        $("#Name").val('');
        $("#Imageurl").val('');
        $("#CategoryImagePreview").val('');
        $("#CategoryId").val('');
    }
