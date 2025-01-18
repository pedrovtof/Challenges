const display = document.querySelector('#display')

function clearDisplay(){
    display.innerHTML = `0`
}

function insertDisplay(number){
    display.innerHTML += `${number}`
}


function execute(formula){
    let res = null
    let operator = null
    
    formula.forEach(element => {
        if (!isNaN(element)){
            element = parseFloat(element)
            if (res === null){
                res = element
            } 
            else {
                if (operator === '+' ){
                    res += element
                } 
                else if (operator === '-' ){
                    res -= element
                } 
                else if (operator === '*' ){
                    res *= element
                }
                else if (operator === '/' ){
                    res /= element
                }
            }
        } else{ operator = element }
    })
    display.innerHTML = res
}

function calculate(){
    let formula = new Array()
    formula = display.innerHTML.match(/(\d+(\.\d+)?|\S)/g);
    execute(formula)
}