$(document).ready(function () {

    $('.selectpicker').selectpicker({
        size: 5,
        width: "auto"
    });

    if ($('select#StationChainId').length) {
        $.ajax({
            url: "/StationChain/GetStationChain",
            type: 'GET',
            success: function (stationChains) {
                // states is your JSON array
                var $select = $('select#StationChainId');
                $.each(stationChains, function (i, stationChain) {
                    $('<option>', {
                        value: stationChain.StationChainId
                    }).html(stationChain.StationChainName).appendTo($select);
                });
                $select.addClass("selectpicker").selectpicker({
                    size: 5,
                    width: "auto"
                });
            },
            error: function (xhr) { alert("Could not load Station Chains!"); }
        });
    }
    

});