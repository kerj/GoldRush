function disable(i){
  $("button#"+i).on('click', function() {
    $(this).prop("disabled",true);
    var buttonValue = $(this).val();
    //sides of clicked button
  });
}
function disableSurrond(id){
  $("#"+id).prop("disabled",true);
}

function findSurrondedSquaretypes(id){
  var listOfSquares = [
    $("#"+(parseInt(id) + -1)), //up
    $("#"+(parseInt(id) + -11)), //upperLeft
    $("#"+(parseInt(id) + -10)), //left
    $("#"+(parseInt(id) + -9)), //lowerLeft
    $("#"+(parseInt(id) + 11)), //lowerRight
    $("#"+(parseInt(id) + 9)), //upperRight
    $("#"+(parseInt(id) + 10)), //right
    $("#"+(parseInt(id) + 1)), //down
  ];

  if(id % 10 == 0 && id != 0 && id != 90){
    listOfSquares.splice(0,2);
    listOfSquares.splice(3,1);
  }else if (id == 90 || id == 0){
    if(id == 90){
      listOfSquares.splice(0,2);
      listOfSquares.splice(2,3);
    }else{
      listOfSquares.splice(0,4);
      listOfSquares.splice(1,1);
    }
  }else if (id == 99 || id ==  9){
    if(id == 99){
      listOfSquares.splice(3,5);
    }else{
      listOfSquares.splice(1,4);
      listOfSquares.splice(3,1);
    }
  }else if(id > 89 && id != 90 && id != 99){
    listOfSquares.splice(4,3);
  }else if(id < 10 && id != 9 && id != 0){
    listOfSquares.splice(1,3);
    listOfSquares.splice(4,1)
  }else if(id % 10 - 9 == 0 && id != 9 && id != 99){
    listOfSquares.splice(3,2);
    listOfSquares.splice(5,1);
  }

    for(var i = 0; i <= listOfSquares.length-1; i++) {
      //listOfSquares is an array of objects with a single index array inside each object
      if(listOfSquares[i][0].value != '10' && listOfSquares[i][0].value != '-1') {
        disableSurrond(listOfSquares[i][0].id);
      }
    }
}

var turnCounter = 1;
var goldCounter = 0;
$(document).ready(function() {
  var totalGold = $("#goldie").val();
  var initialGold = $("#goldie").val();
  $("button.clicked").on('click', function(){
    findSurrondedSquaretypes(this.id);
    var buttonValue = $(this).val();
    //stores the button squaretype
    if(turnCounter >= 5){

    }else {
      if(buttonValue == 10) {
        turnCounter-= 2;
        goldCounter++;
        totalGold--;
        $(".hiddenGold").fadeIn(1000);


      }else if(buttonValue == -1){
        $(".hiddenTnt").fadeIn('1000', function(){
          $(".hiddenTnt").fadeOut('2000', function(){
            window.location.replace("/lose");

          })
        })

      }
    }
      $(".hiddenTnt").fadeOut(500);
    $("#goldies").html("<h1> Number of Gold: " + totalGold + "</h1>");

    $("#turnCounter").html("<h1> Turn: " + turnCounter + "</h1>");


    $("#goldCounter").html("<h1> Players Gold: " + goldCounter + "</h1>");

    if(goldCounter == initialGold) {
      window.location.replace("/game/wongame");
    }
    if(turnCounter > 5) {
      window.location.replace("/game/lostgamemoves");
    }

    turnCounter++
    disable(0);
    $(".hiddenGold").fadeOut(500);
    //disables the button
  })
})
