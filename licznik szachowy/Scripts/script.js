let leftSeconds = 6;            // zmienna przechowująca liczbę sekund lewego licznika
let rightSeconds = 100;         // zmienna przechowująca liczbę sekund prawego licznika

let backupLeftSecond;           // zmienna przechowująca "kopię" liczby sekund lewego licznika
let backupRightSeconds;         // zmienna przechowująca "kopię" liczby sekund prawego licznika
let countdown;                  // zmienna przechowująca ID setTimeoutu 
let readyToRecount = false;     // zmienna używana do zresetowania licznika
let reset = false;              // zmienna używana do zresetowania licznika

//1 - lewy | 2 - prawy 
let player = 1; 
let pause = true;               // zmienna informująca czy jest pauza 


// Fukcja stopująca liczniki
function Stop(){

    clearInterval(countdown);
    
    document.getElementById("leftButton").innerHTML = "Od nowa";
    reset == true;
    pause == true;
    setTimeout(alert("Czas upłynął. \nGracz " + player + ". przerał!"), 1100);
    
}

// Funkcja zmniejszająca liczbę sekund lewego timera
function DecreaseLeft(){
    leftSeconds--;
}

// Funkcja zmniejszająca liczbę sekund prawego timera
function DecreaseRight(){
    rightSeconds--;
}

// Funkcja włączająca timera
function Timer(){
    backupLeftSecond = leftSeconds;
    backupRightSeconds = rightSeconds;
    
    countdown = setInterval(Decrease, 1000);     
}

// Funkcja obsługują timera
function Decrease(){
    
    if(pause == false){
       if(player == 1){
            DecreaseLeft();
            ShowLeft(leftSeconds);
            if( leftSeconds == 0){
               Stop();
            }       
        }
        else if(player == 2){
            DecreaseRight();
            ShowRight(rightSeconds);
            if( rightSeconds == 0){
               Stop();
            }   
        } 
    }
}

// Funkcja podmieniająca zawartość lewego timera
function ShowLeft( seconds ){
   let sec = seconds % 60;
   if(sec < 10)
        sec = "0" + sec;
    
    seconds -= sec;
    
    let minutes = seconds / 60;
    minutes = minutes % 60;
    if(minutes < 10)
        minutes = "0" +minutes;
    
    let hours = Math.floor(seconds / 3600);
    if(hours < 10)
        hours = "0" + hours;
        
    document.getElementById("leftTimer").innerHTML = hours + " : " + minutes + " : " + sec;
}

// Funkcja podmieniająca zawartość prawego timera
function ShowRight( seconds ){
   let sec = seconds % 60;
   if(sec < 10)
        sec = "0" + sec;
    
    seconds -= sec;
    
    let minutes = seconds / 60;
    minutes = minutes % 60;
    if(minutes < 10)
        minutes = "0" +minutes;
    
    let hours = Math.floor(seconds / 3600);
    if(hours < 10)
        hours = "0" + hours;
        

    document.getElementById("rightTimer").innerHTML = hours + " : " + minutes + " : " + sec;
}

// Funkcja obsługująca pauze
function Pause(){
    pause = !pause;
    if(pause)
        document.getElementById("leftButton").innerHTML = "Wznów";
    else
        document.getElementById("leftButton").innerHTML = "Pauza";
}

// Funkcja resetujaca wartości sekund
function ResetTimers(){
    leftSeconds = backupLeftSecond;
    rightSeconds = backupRightSeconds;
    
    ShowLeft(leftSeconds);
    ShowRight(rightSeconds);
}

// Funkcja obsługi lewego buttona
function LeftButtonClicked(){
    
    if( reset == false && readyToRecount == false ){
        Pause();
    }
    else if (reset == true) {
        setTimeout(alert("Zresetowano czasy"), 500);
        
        document.getElementById("leftButton").innerHTML = "Start";
        ResetTimers();        
        
        reset = false;
        readyToRecount = true;
    }
    else if( readyToRecount == true ){
        Timer();
        readyToRecount = false;
        document.getElementById("leftButton").innerHTML = "Pauza";
    }
} 
 
// Funkcja obsługi prawego buttona
function RightButtonClicked(){
    
    clearInterval(countdown);
    
    document.getElementById("leftButton").innerHTML = "Od nowa";
    pause = false;
    reset = true;
}

// Funkcja zmieniająca aktywnego zawodnika
function PlayerChange(){
    if(player == 1){
        player = 2;
        document.getElementById("rightTimer").style = "background-color: #ededed";
        document.getElementById("leftTimer").style = "background-color: #fff";
    }
    else if(player == 2){
        player = 1;
        document.getElementById("leftTimer").style = "background-color: #ededed";
        document.getElementById("rightTimer").style = "background-color: #fff";
    }       
}

// Listener kliknięć
document.addEventListener('keydown', (e) => {
    if(e.keyCode  == 32)
     {
        PlayerChange();
     }
     else if(e.key == 's' || e.key == 'S')
     {
         LeftButtonClicked();
     }
     else if(e.key == 'e' || e.key == 'E')
     {
        RightButtonClicked();
     }
});

//  Funkcja zapisująca dane do local storage
(function (global) {
    document.getElementById("inputButton").addEventListener("click", function () {
        global.localStorage.setItem("savedLeftSeconds", document.getElementById("leftInput").value);
    }, false);
        document.getElementById("inputButton").addEventListener("click", function () {
        global.localStorage.setItem("savedRightSeconds", document.getElementById("rightInput").value);
    }, false);
}(window));

// Funkcja pobierajaca dane z local storage
function GetValues(){
    (function (global) {
      leftSeconds = global.localStorage.getItem("savedLeftSeconds");
      rightSeconds = global.localStorage.getItem("savedRightSeconds");
    }(window));
}