var dataTable;
$(document).ready(function () {
    loadDataTable();
});
function loadDataTable() {
    dataTable = $('#restaurantTable').DataTable({
        "ajax": { url: '/restaurant/gettallrestaurants' },
        "columns": [
            { data: 'name', "width": "20%" },
            { data: 'state', "width": "20%" },
            { data: 'contactNo', "width": "20%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-100 btn-group" role="group">
                     <a href="/restaurant/Edit?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                     <a href="/restaurant/Details?id=${data}" class="btn btn-secondary mx-2"> <i class="bi bi-zoom-in"></i> Details</a>               
                     <a onClick=Delete('/restaurant/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
                },
                //"width": "25%"
            }
        ]
    }

    )
};
function Delete(url) {

    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax
                (
                    {
                        url: url,
                        type: "Delete",
                        success: function (data) {
                            dataTable.ajax.reload()
                            toastr.success(data.message);
                        }


                    }
                )

        }
    });
}