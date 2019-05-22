function disable(i){
  $("button#"+i).on('click', function() {
    $(this).prop("disabled",true);

  });

}
var turnCounter = 1;
var goldCounter = 0;
$(document).ready(function() {
  var totalGold = $("#goldie").val();
  var initialGold = $("#goldie").val();
  $("button").on('click', function(){
    var buttonValue = $(this).val();
    //stores the button squaretype
    console.log(buttonValue);
    if(turnCounter >= 5){
      alert("The game is over");
    }else {
      if(buttonValue == 10) {
        alert("YOU STRUCK GOLD!!!")
        turnCounter--;
        goldCounter++;
        totalGold--;
      }else if(buttonValue == -1){
        alert("YOU BLEW UP!!!")
      }
    }
      $("#goldies").html("<h1> Number of Gold: " + totalGold + "</h1>");

      $("#turnCounter").html("<h1> Turn: " + turnCounter + "</h1>");


      $("#goldCounter").html("<h1> Players Gold: " + goldCounter + "</h1>");

      if(goldCounter == initialGold) {
        window.location.replace("/game/wongame");
      }
      if(turnCounter == 5) {
        window.location.replace("/game/lostgamemoves");
      }

    turnCounter++
    disable(0);
    //disables the button
  })
})
