#pragma strict
 
var particle : GameObject;
function Update () {
    for (var touch : Touch in Input.touches) {
        if (touch.phase == TouchPhase.Began) {
           Application.LoadLevel ("juego" ) ; 
        }
    }
}