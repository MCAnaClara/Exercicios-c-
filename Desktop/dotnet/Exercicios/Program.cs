// exercicio 1 -----------------------------------------------------------------------------------------------

// Console.Write("Digite seu nome: ");
// String? nome = Console.ReadLine();

// Console.Write("Digite sua idade: ");
// int idade = int.Parse(Console.ReadLine()!);

// Console.Write("Digite sua cidade: ");
// String? cidade = Console.ReadLine();

// Console.WriteLine($"Seu nome é {nome}, sua idade é {idade}, e você mora em {cidade}");

// exercicio 2 -----------------------------------------------------------------------------------------------

// Console.Write("Digite o nome do produto: ");
// String? nomeProduto = Console.ReadLine();

// Console.Write("Digite a quantidade comprada: ");
// int quantidade = int.Parse(Console.ReadLine()!);

// Console.Write("Digite o valor do produto: ");
// decimal preco = decimal.Parse(Console.ReadLine()!);

// decimal precoTotal = quantidade * preco;

// Console.WriteLine($"Produto: {nomeProduto}, quantidade comprada: {quantidade}, valor unitário: {preco:F2}, valor total {precoTotal:F2}");

// exercicio 3 -----------------------------------------------------------------------------------------------

// Console.Write("Digite seu nome: ");
// String? nome = Console.ReadLine();

// Console.Write("Digite sua nota: ");
// int nota = int.Parse(Console.ReadLine()!);

// if (nota >= 7){
//     Console.WriteLine($"O aluno {nome} está aprovado");
// } 
//else if (nota >= 5){
//     Console.WriteLine($"O aluno {nome} está de recuperação");
// } 
//else if (nota >= 0) {
//     Console.WriteLine($"O aluno {nome} está reprovado");
// }
// else{
//     Console.WriteLine("Sua nota é inválida");
// }

// exercicio 4 -----------------------------------------------------------------------------------------------

// Console.Write("Digite um número: ");
// int numero = int.Parse(Console.ReadLine()!);

// for (int i = 0; i <= 10 ; i++)
// {
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
// }

// exercicio 5 -----------------------------------------------------------------------------------------------

// int secreto = 6767;

// Console.Write("Chute o número secreto: ");
// int palpite = int.Parse(Console.ReadLine()!);

// int tentativa = 1;

// while (secreto != palpite)
// {
//     if (secreto > palpite)
//     {
//         Console.WriteLine("O número secreto é maior.\n");
//     } 
//     else {
//         Console.WriteLine("O número secreto é menor.\n");
//     }
//     Console.Write("Chute o número secreto: ");
//     palpite = int.Parse(Console.ReadLine()!);
//     tentativa++;
// }

// Console.WriteLine($"Você acertou, o número secreto era {palpite} \nNúmero de tentativas: {tentativa}");

// exercicio 6 -----------------------------------------------------------------------------------------------

// Console.Write("Digite o primeiro número: ");
// int numeroUm = int.Parse(Console.ReadLine()!);

// Console.Write("Digite o sesgundo número: ");
// int numeroDois = int.Parse(Console.ReadLine()!);

// int Soma(){
//     int soma = numeroUm + numeroDois;
//     return soma;
// }

// int Multiplicar()
// {
//     int multiplicacao = numeroUm * numeroDois;
//     return multiplicacao;
// }

// Console.WriteLine($"A soma dos números é {Soma()} e a multiplicação é {Multiplicar()}.");

// exercicio 7 -----------------------------------------------------------------------------------------------

// decimal[] notas = new decimal[3];

// Console.WriteLine("Insira a primeira nota: ");
// decimal n1 = decimal.Parse(Console.ReadLine()!);

// Console.WriteLine("Insira a segunda nota: ");
// decimal n2 = decimal.Parse(Console.ReadLine()!);

// Console.WriteLine("Insira a terceira nota: ");
// decimal n3 = decimal.Parse(Console.ReadLine()!);

// notas[0] = n1;
// notas[1] = n2;
// notas[2] = n3;


// exercicio 8 -----------------------------------------------------------------------------------------------

int[] numeros = new int[3];

Console.WriteLine("Insira o primeiro número: ");
int n1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Insira o segundo número: ");
int n2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Insira o terceiro número: ");
int n3 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Insira o quarto número: ");
int n4 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Insira o quinto número: ");
int n5 = int.Parse(Console.ReadLine()!);

numeros[0] = n1;
numeros[1] = n2;
numeros[2] = n3;
numeros[3] = n4;
numeros[4] = n5;