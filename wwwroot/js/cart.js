toastr.options = { "positionClass": "toast-bottom-right" };
function clearCart() {
    Swal.fire({
        title: "Are you sure?",
        text: "If you confirm, your cart will be cleared.",
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
                            const myTimeout = setTimeout(()=>location.reload(), 3000);
                        }
                    }
                )

        }
    });
}

//function removeItem(id) {
//    $.ajax({
//        url: '/Cart/RemoveItem',
//        type: 'DELETE',
//        data: {
//            id:id
//        },
//        success: function (response) {
//            if (response.success) {
//                location.reload();
//            }
//        }
//    })
//}


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



$('#typeName').on('input', function () {
    const virtualCardName = document.getElementById("virtualCardName");
    virtualCardName.innerHTML = $('#typeName').val();
});
$('#typeText').on('input', function () {
    const virtualCardNumber = document.getElementById("virtualCardNumber");
    virtualCardNumber.innerHTML = $('#typeText').val();
});
$('#typeExp').on('input', function () {
    const virtualCardEXP = document.getElementById("virtualCardEXP");
    virtualCardEXP.innerHTML = $('#typeExp').val();
}); 

$('input[type=radio][name=paymentType]').change(function () {
    console.log(this.id)
    if (this.id == "paymentTypeCard") {
        $("#cardInfoBox").slideDown(500);
    } else {
        $("#cardInfoBox").slideUp(500);
    }
});