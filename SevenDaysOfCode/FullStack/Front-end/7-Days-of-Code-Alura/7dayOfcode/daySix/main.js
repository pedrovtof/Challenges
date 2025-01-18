const _form = document.forms[0]
const list = {
    laticinios: [],
    congelados:[],
    doces:[]
}
let indice = 1
let table = document.querySelector('#table')

function spliceArray(array,item){
    let remove = list[array].indexOf(item)
    list[array].splice(remove, 1)
    remove = null
}

function deleteItem(id,item,category){
    let element = document.querySelectorAll(`.item_${id}`)
    element.forEach((elemento)=>{
        elemento.remove()
    })
    list.laticinios.includes(item)?spliceArray('laticinios',item): null
    list.congelados.includes(item)?spliceArray('congelados',item): null
    list.doces.includes(item)?spliceArray('doces',item): null
}

function organizeArray(item,category){
    item.forEach(element => {
        table.innerHTML += `<td>${element}</td>
            <td>${category}</td>
            <td> <button type="button">Excluir</button> 
        </td>`
    })
    indice = 1
}

_form[1].onclick = ((e)=>{
    table.innerHTML = ``
    organizeArray(list.laticinios,'Laticinios')
    organizeArray(list.congelados,'Congelados')
    organizeArray(list.doces,'Doces')
    list.laticinios = []
    list.congelados = []
    list.doces = []
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
        category == 'laticinios'? list.laticinios.push(product): null
        category == 'congelados'? list.congelados.push(product): null
        category == 'doces'? list.doces.push(product): null
        table.innerHTML += `<td class="item_${indice}">${product}</td>
            <td class="item_${indice}">${category}</td> 
            <td class="item_${indice}">
                <button class="item_${indice}" onclick="deleteItem(${indice},'${product}','${category}')" type="button">Excluir</button>
            </td>`
        indice += 1
    }
})


