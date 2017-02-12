$(function () {
    var dropDown = $("#GameType"),
        playerTwo = $("#PlayerTwo"),
        secondPlayer = $("#secondPlayer");

    if (dropDown.val() === "1") {
        playerTwo.val("Computer");
        secondPlayer.hide();
    }

    dropDown.change(function () {
        if (dropDown.val() === "1") {
            playerTwo.val("Computer");
            secondPlayer.hide();
        }
        else {
            playerTwo.val("");
            secondPlayer.show();
        }

        
    });
});