using System.IO.Pipes;
// 1:
int idade = 35;
Console.WriteLine(idade);
// 2:
string nome = "Maria";
Console.WriteLine(nome);

// 3:
double altura = 3.45;
// 4:
const int ano = 12;
// 5:
double? nota = 7.80;
Console.WriteLine("Valor da variável 'nota':"+ nota);
// 6:
// Tipos por Valor:

// Armazenamento direto: Eles armazenam diretamente seus próprios valores na memória.
// Armazenamento: Geralmente, são armazenados na pilha.
// Cópia: Quando passados como argumentos ou atribuídos a outras variáveis, o valor real é copiado.
// Nulabilidade: Não podem ser nulos, a menos que sejam tipos nullable.
// Exemplos: Inteiros, doubles, chars, structs.
// Tipos por Referência:

// Armazenamento de referência: Armazenam referências a objetos na memória.
// Armazenamento: Geralmente, são armazenados no heap.
// Cópia: São copiados por referência, o que significa que apenas a referência ao objeto é copiada, não os próprios dados.
//  Nulabilidade: Podem ser nulos, indicando que não apontam para nenhum objeto.
// Exemplos: Strings, arrays, classes, interfaces.

// 7:

// Um nullable type em C# é um tipo que pode armazenar tanto valores do seu 
// tipo base quanto o valor null, indicando a ausência de um valor válido. 
// Isso é útil em cenários onde é necessário representar a falta de um valor,
//  como em campos de banco de dados opcionais ou entradas de usuário. 
//  A adição do ponto de interrogação (?) ao final do tipo de dados torna-o nullable.

// 8:

// O Camel Case é uma maneira de nomear coisas, como variáveis, funções ou propriedades, 
// em que cada palavra na identificação começa com uma letra minúscula, exceto a primeira,
// que é escrita em minúscula ou maiúscula. A ideia é que as letras maiúsculas 
// no meio da palavra se assemelhem às corcovas de um camelo.

// Por exemplo, em Camel Case:

// 'nomeDaVariavel'
// Um exemplo de aplicação do Camel Case em C# seria a declaração de uma variável:

// int minhaVariavelInteira = 10;
// Neste exemplo acima, minhaVariavelInteira é um identificador usando a convenção Camel Case para representar uma variável do tipo inteiro.

// int MinhaVariavelInteira = 10;

int x = 77;
int y = 66;
Console.WriteLine("A soma de x e y é: " + (x + y));
