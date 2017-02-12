$(function () {
    var matchesCount = 21;

    $("#Take1").click(function () {
        updateMatches(1);
        updateButtons();
    });

    $("#Take2").click(function () {
        updateMatches(2);
        updateButtons();
    });

    $("#Take3").click(function () {
        updateMatches(3);
        updateButtons();
    });

    function updateMatches(takenMatches) {
        matchesCount = matchesCount - takenMatches;
        $("#Matches").empty();
        for (var i = 1; i <= matchesCount; i++) {
            $("#Matches").append("<span><img src='/Content/images/match.png' width='35' /></span> ");
        }
    };
    
    function updateButtons() {
        if (matchesCount < 3) {
            $("#Take3").hide();
        }

        if (matchesCount < 2) {
            $("#Take2").hide();
        }

    }
});