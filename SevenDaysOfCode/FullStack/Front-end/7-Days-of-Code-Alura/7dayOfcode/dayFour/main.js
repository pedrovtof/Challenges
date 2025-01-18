const readline = require('readline')
const numberMax = 10
const numberMin = 1
let tentativa = 3


const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
})

function randomNumber(){
    return Math.floor(Math.random() * (numberMax - numberMin + 1) + numberMin)
}

function game(answer){

    if(parseInt(answer) === number){
        printf('Parabens!! \n Venceu')
        return rl.close()
    }

    if(tentativa == 0){
        printf(`Fim de jogo! \n Perdeu :) \n O correto era ${number}`)
        rl.close()
    }

    else if(isNaN(answer)){
        printf(`Ops!! \n Precisa inserir um numero, restam ${tentativa}`)
        tentativa -= 1
        inputValue()
    }

    else{
        printf(`Ops!! \n Tente novamente, restam ${tentativa}`)
        tentativa -= 1
        inputValue()
    }
}

function inputValue(){
    rl.question("Qual o valor que você deseja chutar? ", (answer) => {
        game(answer)
    })
}

function printf(e){
    console.log(e)
}

printf("Olá! \n Bem-vindo, iremos jogar um jogo, voce deverá adivinhar o numero que estou pensando (1 até 10)...\n Voce tem 3 chances! \n Então pense bem :)")

let number = randomNumber()

//printf(number) NUMERO CORRETO

inputValue()