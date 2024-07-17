function setFollowInteraction() {
    $('.follow-user').off('click');
    $('.follow-user').click(function () {
        var user_name = $(this).data('username');
        var button = $(this);

        $.ajax({
            url: '/User/FriendRequest',
            type: 'POST',
            data: { username: user_name },
            success: function (response) {
                if (response.isSuccess) {
                    if (response.isWaiting) {
                        button.find('i').addClass('fa-envelope');
                        button.find('i').removeClass('fa-plus');
                        button.find('i').removeClass('fa-check');
                    }
                    else if (response.isAccepted) {
                        button.find('i').removeClass('fa-envelope');
                        button.find('i').removeClass('fa-plus');
                        button.find('i').addClass('fa-check');
                    } else {
                        button.find('i').removeClass('fa-envelope');
                        button.find('i').addClass('fa-plus');
                        button.find('i').removeClass('fa-check');
                    }
                }
                else {
                    button.find('i').removeClass('fa-envelope');
                    button.find('i').addClass('fa-plus');
                    button.find('i').removeClass('fa-check');
                }
            },
            error: function () {
                alert('There were some errors. Please try again after few minutes.');
            }
        });
    });
}