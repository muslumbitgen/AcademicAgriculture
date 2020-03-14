$(document).ready(function () {
    window.onload = function () {
        $('button').on('click', function () {
            var val = $(this).val();
            var id = val.split('??')[0];
            var controller = val.split('??')[1];
            var action = val.split('??')[2];
            $.ajax({
                url: "/" + controller + "/" + action + "",
                type: 'post',
                data: { id: id },
                dataType: 'json',
                success: function (r) {
                    location.reload();
                }
            });
        });
    };
    $('.btndel').on('click', function () {

        var id = $(this).data("id");
        var controller = $(this).data("controller");
        var message = $(this).data("message");

        Swal.fire({
            title: message + ' Silinecek!',
            text: "Silmek istediğinize emin misiniz?",
            type: 'warning',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet, sil!',
            cancelButtonText: 'İptal!',
            closeOnConfirm: false
        }).then(function (isConfirm) {
            if (isConfirm.value == true) {
                $.ajax({
                    type: 'post',
                    url: '/' + controller + '/Delete?Id=' + id,
                    success: function (data) {
                        if (data) {
                            alert(message + ' silindi.', 'success');
                            setTimeout(function () { location.reload(); }, 1550);
                        }
                        else {
                            alert('İşlem sırasında hata oluştu?', 'warning');
                            return false;
                        }
                    }
                });

            }
        });
    });
    var alert = function (message, type) {
        Swal.fire({
            position: 'top-end',
            icon: type,
            title: message,
            showConfirmButton: false,
            timer: 1500
        })
    }
});