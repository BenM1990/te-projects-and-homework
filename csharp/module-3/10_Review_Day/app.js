//grab the blue button
const blueBtn = document.getElementById('blueBtn');

//we want to clear the text out of the text area when we click the blue button

blueBtn.addEventListener('click', function() {
    const txtArea = document.getElementById('txtArea');
    txtArea.value = "";
    
});

//red button
const redBtn = document.getElementById('redBtn');

redBtn.addEventListener('click',
                        function(event) {
                        const txtArea = document.getElementById('txtArea');
                        txtArea.value = `The red button's event type was: ${event.type} and it happened at: ${event.timeStamp}`;
                        
                        });

//green button .. turn the text box green
//make a css class to do a green background

const greenBtn = document.getElementById('greenBtn');

greenBtn.addEventListener('click', () => {
    const txtArea = document.getElementById('txtArea');
    txtArea.classList.toggle('greenBackground');
    txtArea.value = "The green button was clicked!"
    const title = document.querySelector('h1');
    title.innerText = "Website with a green button";
});

//get the text input
const txtInput = document.getElementById('txtInput');
txtInput.addEventListener('keyup', (event) => {
    //I want to know if the key that came up is the enter key
    const para = document.getElementById('borderedPara');
    if(event.key === 'Enter') {
        //put the value of the text input in the paragraph tag
        para.innerText = txtInput.value;
    }
    if(event.key === '`'){
        displaySecretMessage(para);
    }
});

//a separate function that we will call from the event handler
function displaySecretMessage(element) {
    element.innerText = "Squirrel cigar party @ 7pm in the parking lot"

}