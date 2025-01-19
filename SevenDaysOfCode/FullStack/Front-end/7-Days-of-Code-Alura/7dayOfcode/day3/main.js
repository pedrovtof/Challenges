const choiceButtons = document.querySelectorAll('.card')
const question = document.querySelector('#question')
const main = document.querySelector('.main')
const _form = document.forms[0]
const askTechContainer = document.querySelector('.askTech-container')


var choices = []

function changeImg(language, id,id2,id3,id4){
    if(id3 == '' && id4 == ''){
        choices.push(language)
        choiceButtons[id].classList.add('ghost')
        choiceButtons[id2].classList.add('ghost')
    }
    else{
        choices.push(language)
        choiceButtons[id].classList.add('ghost')
        choiceButtons[id2].classList.add('ghost')
        choiceButtons[id3].classList.remove('ghost')
        choiceButtons[id4].classList.remove('ghost')
    }
}

function game(e){
    option = e

    if(option == 1){
        choiceButtons[0].onclick = function(){
            changeImg('Front-end',0,1,4,5)
            question.innerHTML = ''
            question.innerHTML = 'Qual seria sua preferencia de framework?'
        }
    }

    else if(option == 2){
        choiceButtons[1].onclick = function(){
            changeImg('Backend-end',0,1,2,3)
            question.innerHTML = ''
            question.innerHTML = 'Qual seria sua preferencia de lingaguem?'
        }
    }

    else if(option == 3){
        choiceButtons[2].onclick = function(){
            changeImg('C#',2,3,7,8)
            question.innerHTML = ''
            question.innerHTML = 'Qual seria sua preferencia de carreira?'
        }
    }

    else if(option == 4){
        choiceButtons[3].onclick = function(){
            changeImg('Java',2,3,7,8)
            question.innerHTML = ''
            question.innerHTML = 'Qual seria sua preferencia de carreira?'
        }
    }

    else if(option == 5){
        choiceButtons[4].onclick = function(){
            changeImg('React',4,5,6,8)
            question.innerHTML = ''
            question.innerHTML = 'Qual seria sua preferencia de carreira?'
        }
    }

    else if(option == 6){
        choiceButtons[5].onclick = function(){
            changeImg('Vue',4,5,6,8)
            question.innerHTML = ''
            question.innerHTML = 'Qual seria sua preferencia de carreira?'
        }
    }

    else if(option == 7){
        choiceButtons[6].onclick = function(){
            changeImg('Front-end-developer',6,8,'','')
            question.innerHTML = ''
        }
        main.classList.add('ghost')
        askTechContainer.classList.remove('ghost')
    }

    else if(option == 8){
        choiceButtons[7].onclick = function(){
            changeImg('Backend-end-developer',7,8,'','')
            question.innerHTML = ''
        }
        main.classList.add('ghost')
        askTechContainer.classList.remove('ghost')
    }

    else if(option == 9){
        choiceButtons[8].onclick = function(){
            choiceButtons[7].classList.add('ghost')
            changeImg('Fullstack-developer',6,8,'','')
            question.innerHTML = ''
        }
        main.classList.add('ghost')
        askTechContainer.classList.remove('ghost')
    }

    else{
        return
    }

}

_form[1].onclick = ((e)=>{
    e.preventDefault
    if(_form[0].value == '' || !_form[0].value){
        alert('OPS! Preencha o campo')
    } else{
        choices.push(_form[0].value)
        _form[0].value = ''
    }
})

_form[2].onclick = ((e)=>{
    askTechContainer.classList.add('ghost')
    main.classList.remove('ghost')
    alert(`Obrigado !! \n suas respostas: \n ${choices} \n fim!`)
})



