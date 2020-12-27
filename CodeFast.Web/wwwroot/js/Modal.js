(function ($) {
    let scripts = document.getElementsByTagName('script');
    var idValue = "";

    for (let i = 0, len = scripts.length; i < len; i++) {
        let src = scripts[i].getAttribute('src').split('?');
        let url = src[0];
        let args = src[1]?.split('&' || '&&');
        if (typeof args !== 'undefined') {
            idValue = args[0].split('=')[1].replace(/'/g, '');
        } 
        if (!args) {
            continue;
        }
    }

    var id = '#' + idValue;
    var idModel = '#' + idValue + '>.model';

    function Index() {
        var $this = this;
        function initialize() {
            $(".popup").on('click', function (e) {
                modelPopup(this);
            });
            function modelPopup(reff) {
                var url = $(reff).data('url');

                $.get(url).done(function (data) {

                    $(id).find(".modal-dialog").html(data);
                    $(idModel, data).modal("show");
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