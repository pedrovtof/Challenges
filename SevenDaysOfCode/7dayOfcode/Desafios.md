

## Desafio 1 -->

### A sua tarefa de hoje é reescrever o código abaixo de maneira que ele imprima as informações de maneira correta, que faça sentido e sem erros:
### Your task for today is to rewrite the code below so that it prints the information correctly, makes sense, and has no errors:

  ```
  let numeroUm = 1
  let stringUm = '1'
  let numeroTrinta = 30
  let stringTrinta = '30'
  let numeroDez = 10
  let stringDez = '10'
  
  if (COMPARAR O numeroUm e a stringUm) {
    console.log('As variáveis numeroUm e stringUm tem o mesmo valor, mas tipos diferentes')
  } else {
    console.log('As variáveis numeroUm e stringUm não tem o mesmo valor')
  }
  
  if (COMPARAR O numeroTrinta e a stringTrinta) {
    console.log('As variáveis numeroTrinta e stringTrinta tem o mesmo valor e mesmo tipo')
  } else {
    console.log('As variáveis numeroTrinta e stringTrinta não tem o mesmo tipo')
  }
  
  if (COMPARAR O numeroDez e a stringDez) {
    console.log('As variáveis numeroDez e stringDez tem o mesmo valor, mas tipos diferentes')
  } else {
    console.log('As variáveis numeroDez e stringDez não tem o mesmo valor')
  }
```

## Desafio 2 -->

### O codigo deve pedir para o usuário responder 3 perguntas:
### The code must ask the user to answer three questions:

- Qual o seu nome?
- Quantos anos você tem?
- Qual linguagem de programação você está estudando?

À medida que as perguntas forem sendo feitas, a pessoa que estiver usando o programa deve responder cada uma delas.

No final, o sistema vai exibir a mensagem:
  ```
 - "Olá [nome], você tem [idade] anos e já está aprendendo [linguagem]!"
  ```

### OPCIONAL
### EXTRA

### Você vai complementar o código para que, depois de exibir a mensagem anterior, o programa pergunte:
### Enhance the previous code so that after displaying the message, the program asks another question:

Você gosta de estudar [linguagem]? Responda com o número 1 para SIM ou 2 para NÃO.

E aí, dependendo da resposta, ele deve mostrar uma das seguintes mensagens:

1 > Muito bom! Continue estudando e você terá muito sucesso.
2 > Ahh que pena... Já tentou aprender outras linguagens?



## Desafio 3 -->

### Seu desafio de hoje é criar os destinos possíveis de um jogo, em que o usuário consiga escolher:
### Your challenge for today is to create possible destinations in a game where the user can make choices:

1. Se quer seguir para área de Front-End ou seguir para a área de Back-End.

2. Caso esteja na área de Front-End, se quer aprender React ou aprender Vue. Caso esteja na área de Back-End, poderá aprender C# ou aprender Java.

3. Depois, independente das escolhas anteriores, o usuário poderá escolher entre seguir se especializando na área escolhida ou seguir se desenvolvendo para se tornar Fullstack. Você deve exibir na tela uma mensagem específica para cada escolha.

4. Por fim, pergunte quais são as tecnologias nas quais a pessoa gostaria de se especializar ou de conhecer. Aqui, a pessoa pode responder N tecnologias, uma de cada vez. Então, enquanto ela continuar respondendo ok para a pergunta: “Tem mais alguma tecnologia que você gostaria de aprender?”, continue apresentando para ela o Prompt, para que ela complete o nome da tecnologia em questão. E, logo depois, apresente uma mensagem comentando algo sobre a linguagem inserida.

O importante é que a pessoa que estiver jogando possa sempre escolher qual decisão tomar para conseguir aprender e se desenvolver na área de programação.

Além disso, também é essencial que, ao final do jogo, ela possa inserir quantas tecnologias quiser na lista de aprendizado.


## Desafio 4 -->

### Você já brincou de tentar adivinhar o número que seu amigo ou amiga estava pensando? Hoje você vai voltar na infância e fazer exatamente isso. Mas agora, o jogo vai ser contra o próprio computador!
### Have you ever played a game where you try to guess the number your friend is thinking? Today, you’ll go back to your childhood and do exactly that, but this time, the game will be against the computer!

Você deve criar um programinha que comece com um valor específico pré-definido entre 0 a 10 para o número que você vai adivinhar (7, por exemplo).

Em seguida, o programa vai perguntar para você qual o valor que você deseja chutar e, caso você acerte, ele irá te parabenizar. Caso erre, ele vai te dar mais 2 tentativas.

No fim, caso você não acerte nenhuma vez, ele vai imprimir qual era o número inicial.

Depois que o programinha estiver funcionando, tente usar um número randômico em vez de um número pré-definido.

### Resposta

! Usando Node.js !

Bibliotecas readline e math


## Desafio 5 -->

### Para facilitar a sua ida ao supermercado, você deve criar um programa em Javascript que perguntará se você deseja adicionar uma comida na sua lista de compras, e você deve poder responder com sim ou não.
### To make your supermarket trip easier, create a program in JavaScript that asks if you want to add food to your shopping list, allowing you to answer with yes or no.

Em seguida, ele perguntará qual comida você deseja inserir, e você digitará o nome dela, como por exemplo batata.

Depois, ele deverá perguntar em qual categoria essa comida se encaixa, com algumas opções já pré-definidas, como frutas, laticínios, congelados, doces e o que mais você achar interessante. Assim, você poderá separar tudo no seu devido grupo.

Por fim, caso você não queira mais adicionar nada na lista de compras e responder não na primeira pergunta, ele irá exibir uma lista com todos os itens agrupados, da seguinte forma:

Caso você adicione na sua lista:
```
  banana, leite em pó, tomate, leite vegetal, chiclete, bala de ursinho, maçã, uva, abacate e leite de vaca
```
O programa deverá imprimir, por exemplo:

Lista de compras:
```
  Frutas: banana, tomate, maçã, uva, abacate
  Laticínios: leite vegetal, leite de vaca, leite em pó
  Congelados:
  Doces: chiclete e bala de ursinho
```


## Desafio 6 -->

### Você deverá criar a opção de remover algum item da lista, que será exibida junto à pergunta de “você deseja adicionar uma comida na lista de compras”?
### You must add the option to remove an item from the list, displayed along with the question: “Do you want to add food to the shopping list?”

A partir daí, caso a pessoa escolha essa opção, o programa irá imprimir os elementos presentes na lista atual, e a pessoa deverá escrever qual deles deseja remover.

Depois disso, o programa irá remover o elemento da lista e imprimir a confirmação de que o item realmente não está mais lá.

Por fim, ele voltará para o ciclo inicial de perguntas.

Se, na hora de deletar o item, o mesmo não for encontrado na lista, você deverá exibir uma mensagem avisando isso.

Por exemplo: “Não foi possível encontrar o item dentro da lista!”

Lembre-se que a opção de remover um item só deverá estar disponível a partir do momento que existir ao menos um elemento dentro da lista de compras.



## Desafio 7 -->

### Para o exercício de hoje: você já parou para pensar como uma calculadora funciona?
### For today’s exercise: Have you ever wondered how a calculator works?

Ela pede para você digitar um número, depois você seleciona um tipo de operação, um outro número, e ela faz sozinha o cálculo para te mostrar o resultado! Incrível, né?

Neste último desafio, a minha proposta para você é: crie a sua própria calculadora, porém com um detalhe muito importante: cada operação deverá ser uma função diferente no seu código.

Primeiramente, a pessoa deverá escolher uma opção de operação impressa pelo programa na tela.

Depois, ela deverá inserir os dois valores que deseja utilizar, e o programa imprimirá o resultado da operação em questão.

As opções disponíveis deverão ser: soma, subtração, multiplicação, divisão, e sair. Nessa última, o programa deverá parar de ser executado, mostrando uma mensagem "Até a próxima".

