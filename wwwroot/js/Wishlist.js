toastr.options = { "positionClass": "toast-bottom-right" };


function clearCart() {

    Swal.fire({
        title: "Are you sure?",
        text: "If you confirm, your Wishlist will be cleared.",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Clear Wishlist"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax
                (
                    {
                        url: '/Wishlist/ClearWish',
                        type: "Delete",
                        success: function (data) {
                            toastr.success(data.message);
                            const myTimeout = setTimeout(() => location.reload(), 3000);
                        }
                    }
                )

        }
    });
}
$(document).ready(function () {
    $('.addToWishlistBtn').click(function () {
            var id = $(this).data('id');

            $.ajax({
                url: '/Wishlist/Add',
                type: 'POST',
                data: {
                    id: id,
                },
                success: function (response) {
                    if (response.success) {
                        toastr.success(response.message);
                    } else {
                       // clearCart();
                    }
                },
                error: function () {
                    alert('An error occurred while processing your request.');
                }
            });
        });
    });