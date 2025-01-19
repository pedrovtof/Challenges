const _form = document.forms[0]
const list = {
    laticinios: [],
    congelados:[],
    doces:[]
}

let table = document.querySelector('#table')

function organizeArray(item,category){
    item.forEach(element => {
        table.innerHTML += `<td>${element}</td> <td>${category}</td>`
    })
}

_form[1].onclick = ((e)=>{
    table.innerHTML = ``
    organizeArray(list.laticinios,'Laticinios')
    organizeArray(list.congelados,'Congelados')
    organizeArray(list.doces,'Doces')
    print(table)
    table.innerHTML = ``
})

_form[3].onclick = ((e)=>{
    let category = _form[2].value
    let product = _form[0].value

    if(!product){
        alert('OPS! precisa preencher produto')
    }
    else if (product == ' '){
        alert('OPS! precisa preencher produto')
    } else{
        category == 'laticinios'? list.laticinios.push(product): null;
        category == 'congelados'? list.congelados.push(product): null;
        category == 'doces'? list.doces.push(product): null;
        table.innerHTML += `<td>${product}</td> <td>${category}</td>`
    }
})


