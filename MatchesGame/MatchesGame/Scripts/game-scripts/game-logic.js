$(function () {
    var matchesCount = 21,
        firstPlayer = $("#FirstPlayer").text(),
        secondPlayer = $("#SecondPlayer").text(),
        currentPlayer = firstPlayer;

    $("#Take1").click(function () {
        updateMatches(1);
        updateButtons();
        updatePlayer();
    });

    $("#Take2").click(function () {
        updateMatches(2);
        updateButtons();
        updatePlayer();
    });

    $("#Take3").click(function () {
        updateMatches(3);
        updateButtons();
        updatePlayer();
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

        if (matchesCount < 1) {
            $("#Take1").hide();
        }
    };

    function updatePlayer() {
        if (matchesCount < 1) {
            $("#CurrentPlayer").text("Winner is: " + currentPlayer);
        }
        else {
            if (currentPlayer === firstPlayer) {
                currentPlayer = secondPlayer;
            }
            else {
                currentPlayer = firstPlayer;
            }
            $("#CurrentPlayer").text(currentPlayer + " Turn");
        }
    };
});