// Variável que define a idade humana desejada a ser convertida em anos de Cachorro
const myAge = 15;

// Variável criada para calcular a velhice nos anos iniciais dos Cachorros
let earlyYears = 2;
earlyYears *= 10.5;
console.log(`Idade do cachorro nos anos iniciais é ${earlyYears}`);

// Variável criada para calcular a velhice nos anos finais dos Cachorros
let laterYears = myAge - 2;
laterYears *= 4;
console.log(`Idade do cachorro nos anos finais é ${laterYears}`);

// Variável criada para definir uma idade de humano em anos de Cachorro, sem considerar as variações temporais
let myAgeInDogYears = 73;

// Variável para definir o nome do Cachorro
const myName = 'Anakin'

// Impressão na tela do usuário do código final, usando uma frase com concatenação
// A idade final do cachorro refelte a soma dos anos iniciais com os anos finais
console.log(`Meu nome é ${myName}. Eu tenho ${myAge} anos de idade em tempo humano, o que corresponde a ${myAgeInDogYears} anos de idade no tempo de cachorro.`);