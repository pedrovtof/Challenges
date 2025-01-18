const button = document.querySelector('#button')
const buttonOP = document.querySelector('#buttonOP')

const form = document.forms[0]

function secondForm(msg, languageValue){
    let msgAbove = document.querySelector('#msgAbove')
    let containerGhost = document.querySelector('.ghost')
    let askLanguage = document.querySelector('#askLanguage')

    button.classList.add('ghost')
    containerGhost.classList.remove('ghost') 

    msgAbove.innerHTML = ''
    msgAbove.innerHTML = `${msg}`

    askLanguageText = `Você gosta de estudar ${languageValue}?`
    askLanguage.innerHTML = ''
    askLanguage.innerHTML = `${askLanguageText}`

    buttonOP.onclick = function(e){
        e.preventDefault()
        let ask = document.querySelector('input[name="ask"]:checked')
        const msgCheck = document.querySelector('#msgCheck')
        let msgCheckText = ''

        msgCheck.innerHTML = ''

        if(ask){
            if(ask.value == 'true'){
                msgCheck.innerHTML='Muito bom! Continue estudando e você terá muito sucesso.'
            }else if(ask.value == 'false'){
                msgCheck.innerHTML='Ahh que pena... Já tentou aprender outras linguagens?'
            }else{alert('OPS! Ocorreu um erro, tente novamente mais tarde')}
        }else{
            alert('OPS! Ocorreu um erro, Valide os campos')
        }
        
    }

}

button.onclick = function(e) {
    e.preventDefault()

    let inputs = {
        nameValue : form.name.value,
        ageValue: form.age.value,
        languageValue: form.language.value
    }

    if(inputs.nameValue.length > 2 && inputs.ageValue > 0 && inputs.languageValue.length > 1){
        let msg = `Olá ${inputs.nameValue}, você tem ${inputs.ageValue} anos e já está aprendendo ${inputs.languageValue}!`
        secondForm(msg, inputs.languageValue)
    } else if (!inputs.nameValue || !inputs.ageValue || !inputs.languageValue){
        alert('OPS! Ocorreu um erro, Valide os campos')
    } else{ alert('OPS! Ocorreu um erro, tente novamente mais tarde')}
    
}