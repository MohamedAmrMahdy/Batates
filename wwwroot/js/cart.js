
    $(document).ready(function () {
        $('.addToCartBtn').click(function () {
            var id = $(this).data('id');
            var restid = $(this).data('restid');

            $.ajax({
                url: '/Cart/Add',
                type: 'POST',
                data: {
                    id: id,
                    restid: restid
                },
                success: function (response) {
                    if (response.success) {
                        alert("Hello" + response.message);
                    } else {
                        alert('Error: ' + response.message);
                    }
                },
                error: function () {
                    alert('An error occurred while processing your request.');
                }
            });
        });
    });

