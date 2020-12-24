(function ($) {
    let scripts = document.getElementsByTagName('script');
    debugger;
    for (let i = 0, len = scripts.length; i < len; i++) {
        let src = scripts[i].getAttribute('src').split('?');
        let url = src[0];
        let args = src[1]?.split('&'||'&&');

        if (!args) {
            continue;
        }
    }
    let script = scripts[scripts.length - 1];

    function Index() {
        var $this = this;
        function initialize() {
            $(".popup").on('click', function (e) {
                modelPopup(this);
            });
            function modelPopup(reff) {
                var url = $(reff).data('url');

                $.get(url).done(function (data) {

                    $('#modal-create-edit').find(".modal-dialog").html(data);
                    $('#modal-create-edit > .modal', data).modal("show");
                });
            }
        }

        $this.init = function () {
            initialize();
        };
    }
    $(function () {
        var self = new Index();
        self.init();
    });
}(jQuery));  