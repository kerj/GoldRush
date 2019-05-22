function disable(i){
  $("button#"+i).on('click', function() {
    $(this).prop("disabled",true);

  });

}
var totalGold = $("#goldie").val();
var turnCounter = 1;
var goldCounter = 0;
$(document).ready(function() {
  console.log(totalGold);
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
      $("#turnCounter").html("<h1> Turn: " + turnCounter + "</h1>");


      $("#goldCounter").html("<h1> Players Gold: " + goldCounter + "</h1>");

      $("#goldie").html("<li>" + totalGold + "<li>");

    turnCounter++
    disable(0);
    //disables the button

  })




})
