//set up string array with 10 problems, both sides 0-9, multiply

//each question has a list of 4 possible answers

//highest possible answer is 81

//arrays
const questionArray = ['4*3', '5*7', '9*2', '5*5', '6*9', '7*6', '1*1', '0*9', '8*8', '2*5'];
const answersArray = ['12', '35', '18', '25', '54', '42', '1', '0', '64', '10'];

//start button


//functions



 function getRandomNumber(max) {
    return Math.floor(Math.random() * Math.floor(9));

    }

function shuffleArray(arr) {
    return arr.sort(function (a, b) { return Math.random() - 0.5 })
    }




//DOM LOADED W/ EVENT LISTENERS
document.addEventListener('DOMContentLoaded', () => {
getRandomNumber();
shuffleArray();



const startBtn = document.getElementById('btnStartOver');
startBtn.addEventListener('click', (event) => {

});


//end of DOM LOADED
});