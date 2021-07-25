var contact = {
    init: function () {
        contact.registerEvents();

    },
    
    registerEvents: function () {
        $('#form-submit').off('click').on('click', function () {
            var name = $('#txtname').val();
            var phoneNumber = $('#txtphoneNumber').val();
            var email = $('#txtemail').val();
            var address = $('#txtaddress').val();
            var content = $('#txtcontent').val();

            $.ajax({
                url: '/Contact/contact/Submit',
                type: 'POST',
                dataType: 'json',
                data: {
                    name: name,
                    phoneNumber: phoneNumber,
                    email: email,
                    address: address,
                    content: content
                },
            
                success: function (res) {
                    if (res.status == true)
                    {
                        
                        window.alert('Gửi Thành Công !');
                        contact.resetForm();
                    }
                }
            });
        });
    },
    resetForm: function () {
        $('#txtname').val('');
        $('#txtphoneNumber').val('');
        $('#txtemail').val('');
        $('#txtaddress').val('');
        $('#txtcontent').val('');
    }
}
contact.init();