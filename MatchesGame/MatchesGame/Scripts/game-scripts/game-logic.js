$(function () {
    var firstPlayer = $("#FirstPlayer").text(),
        secondPlayer = $("#SecondPlayer").text(),
        take1 = $("#Take1"),
        take2 = $("#Take2"),
        take3 = $("#Take3"),
        matches = $("#Matches"),
        turn = $("#Turn"),
        matchesCount,
        currentPlayer;

    init();

    function init() {
        matchesCount = 21;
        currentPlayer = firstPlayer;
        turn.text(currentPlayer + " Turn");

        drawBoard();
    };

    function drawBoard() {
        matches.empty();
        for (var i = 1; i <= matchesCount; i++) {
            matches.append("<span><img src='/Content/images/match.png' width='35' /></span> ");
        }
    };

    function updateGame(matchesTaken) {
        updateMatches(matchesTaken);
        updateButtons();
        updatePlayer();
        drawBoard();

        function updateButtons() {
            updateButton(take1, 1);
            updateButton(take2, 2);
            updateButton(take3, 3);

            function updateButton(button, count) {
                if (matchesCount < count) {
                    button.hide();
                }
                else {
                    button.show();
                }
            };
        };

        function updatePlayer() {
            if (matchesCount < 1) {
                turn.text("Winner is: " + currentPlayer);
            }
            else {
                if (currentPlayer === firstPlayer) {
                    currentPlayer = secondPlayer;
                }
                else {
                    currentPlayer = firstPlayer;
                }
                turn.text(currentPlayer + " Turn");
            }
        };

        function updateMatches(takenMatches) {
            matchesCount = matchesCount - takenMatches;
        };
    };

    $("#Reset").click(function () {
        init();
        take1.show();
        take2.show();
        take3.show();
    });

    take1.click(function () {
        updateGame(1);
    });

    take2.click(function () {
        updateGame(2);
    });

    take3.click(function () {
        updateGame(3);
    });


    function getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;

    }

    
});