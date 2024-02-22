toastr.options = { "positionClass": "toast-bottom-right" };
function clearCart() {

    Swal.fire({
        title: "Are you sure?",
        text: "You have items from another Restaurant\nIf you confirm it will be cleared.",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Clear Cart"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax
                (
                    {
                        url: '/Cart/ClearCart',
                        type: "Delete",
                        success: function (data) {
                            toastr.success(data.message);
                        }
                    }
                )

        }
    });
}


    $(document).ready(function () {
        $('.addToCartBtn').click(function () {
            var id = $(this).data('id');

            $.ajax({
                url: '/Cart/Add',
                type: 'POST',
                data: {
                    id: id,
                },
                success: function (response) {
                    if (response.success) {
                        toastr.success(response.message);
                    } else {
                            clearCart();
                    }
                },
                error: function () {
                    alert('An error occurred while processing your request.');
                }
            });
        });
    });

