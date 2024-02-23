toastr.options = { "positionClass": "toast-bottom-right" };

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
                error: function (response) {
                    console.log(response);
                    //alert('An error occurred while processing your request.');
                }
            });
        });
    });