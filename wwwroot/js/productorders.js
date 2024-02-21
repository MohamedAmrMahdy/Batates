
$(document).ready(function () {
    loadDataTable();
});
function loadDataTable() {
    dataTable = $('#productorderTable').DataTable({
        "ajax": { url: '/product/GettAllProductOrders' },
        "columns": [
            { data: 'id', "width":"20%" },
            { data: 'orderDate', "width": "20%" },
            { data: 'quantity', "width": "20%" },
            { data: 'quantity', "width": "20%" },
            { data: 'fullname', "width": "20%" },
            {
               
           
            }
        ]
    }

    )
};
