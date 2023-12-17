/*
  Uma classe no C# é uma estrutura que define o comportamento
e as propriedades de um objeto, servindo como um molde para criar
instâncias deste objeto. Ela agrupa dados (atributos) e comportamentos
(métodos) relacionados em uma única entidade, como ilustra o
código abaixo:

class EscolaDoRock
{
    public string Titulo;
    public int AnoLancamento;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
    }
}

 */

/*
// uma classe além de atributos podemos criar comportamentos
//instanciando um objeto para o tipo música
Musica musica1 = new Musica();
//dando valores para seus atributos
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

//quando o tipo do dado não é indicado por padrão será exibido o tipo da variável
//Console.WriteLine($"Nome da música: {musica1.nome}");
//Console.WriteLine($"Artista: {musica1.artista}");

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.EscreveDisponivel(false);
Console.WriteLine(musica1.LeDisponivel());

//chamando o método de comportamento para a classe música
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
*/

/*
//instanciando album e adicionando músicas na lista
Album albumDoQueen = new() { 
    Nome = "A night at the Opera"
};
Musica musica1 = new Musica() {
    Nome = "Love of my life",
    Duracao = 213
    
};
Musica musica2 = new Musica() {
    Nome = "Bohemian Rhapsody",
    Duracao = 354
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.exibirMusicasDoAlbum();
*/

/*
instanciando objeto contaBancaria e atribuindo valores para seus atributos
ContaBancaria conta1 = new ContaBancaria();
Console.WriteLine(conta1.NumContaBancaria);
Console.WriteLine(conta1.NomeTitular);
Console.WriteLine(conta1.Saldo);

Console.WriteLine($"Titular: {conta1.NomeTitular}");
Console.WriteLine($"Saldo: {conta1.Saldo}");

conta1.ExibirNomeTitularESaldo();
carro carro1 = new carro();
carro1.Fabricante = "Ford";
carro1.Modelo = "Mustang GTD";
carro1.Ano = 2010;
carro1.QuantidadePortas = 2;
carro1.Velocidade = 150;

carro1.exibirInformacoes();
carro1.acelerar();
carro1.buzinar();
carro1.frear(5);
*/

/*
 Em C#, um método é um bloco de código que contém um conjunto de instruções que realizam uma determinada tarefa ou operação. Métodos são membros de uma classe e definem o comportamento dos objetos dessa classe.

Um método pode receber zero ou mais parâmetros como entrada, realizar operações com esses parâmetros ou com outros dados internos da classe, e pode retornar um valor ou simplesmente executar ações sem retorno.

Atualmente, nossa classe Música possui apenas um método chamado ExibirFichaTecnica(), como mostra o código abaixo.

Na próxima aula:
Vamos seguir as boas práticas de programação e alterar a visibilidade dos atributos, além de aplicar um conceito muito usado no mundo real chamado Properties.

 */

/*
 No C#, lambdas são funções anônimas que podem ser usadas para criar expressões ou blocos de código compactos e concisos. Eles são especialmente úteis quando se trata de trabalhar com coleções de dados, realizar operações em uma sequência de elementos ou lidar com delegados.

Vamos começar com um exemplo simples de um código sem lambda. Suponha que você tenha uma lista de números inteiros e deseje filtrar apenas os números pares. Aqui está um exemplo sem o uso de lambda:

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);

bool BuscarNumerosQueSaoPares(int numero)
{
    return numero % 2 == 0;
}

foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}
Neste exemplo, definimos um método chamado BuscarNumerosQueSaoPares, que recebe um número inteiro e retorna um valor booleano indicando se o número é par. Em seguida, usamos o método FindAll da classe List<T> para filtrar os números da lista com base nessa condição e exibimos os valores no console.

Como seria esse código com funções lambdas?
Lembrando que a estrutura de código de uma função lambda no C# segue um formato geral. Aqui está a estrutura básica de uma função lambda:
(parametros) => expressao

Parâmetros: É uma lista opcional de parâmetros, separados por vírgulas, que especifica as entradas da função lambda. Cada parâmetro pode ser tipado explicitamente ou pode ser inferido pelo compilador.

Operador =>: É o operador de seta (=>), que separa a lista de parâmetros da expressão lambda. Ele indica que os parâmetros estão sendo mapeados para a expressão ou bloco de código seguinte.

Expressão ou bloco de código: É a expressão ou o bloco de código que define a lógica da função lambda. Pode ser uma única expressão ou um bloco de código delimitado por chaves ({}). Se a função lambda contiver um único comando, a expressão será automaticamente retornada. Caso contrário, você pode usar a palavra-chave return para retornar explicitamente um valor.

Mão nas teclas
Vamos iniciar substituindo a função BuscarNumerosQueSaoPares por uma função anônima que tem a mesma finalidade:

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);

A expressão lambda especifica um parâmetro numero seguido por uma seta (=>) e uma expressão que retorna um valor booleano. A função FindAll utiliza essa expressão lambda como critério para filtrar os números da lista.

Em seguida, podemos usar uma função lambda na exibição dos números pares:

numerosPares.ForEach(numero => Console.WriteLine(numero));

Segue o código completo:

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
numerosPares.ForEach(numero => Console.WriteLine(numero));

Algumas vantagens das lambdas em relação ao código sem lambda
Concisão: As lambdas permitem escrever código de forma mais concisa, eliminando a necessidade de definir métodos separados para funções simples.

Legibilidade: As lambdas são mais fáceis de ler e entender, especialmente quando o critério de filtragem ou a lógica do código é curto e direto.

Flexibilidade: As lambdas podem ser usadas em várias situações, como filtrar, ordenar, mapear ou reduzir coleções de dados. Elas permitem que você especifique a lógica do código diretamente no local onde é necessário, sem a necessidade de criar métodos adicionais.

Encerramento de escopo: As lambdas têm acesso às variáveis do escopo em que são definidas, o que permite que você capture e utilize valores externos dentro da expressão lambda. Isso pode ser útil em casos onde você precisa fazer referência a variáveis externas dentro de um loop, por exemplo.

Em resumo, lambdas no C# são funções anônimas que fornecem uma sintaxe concisa para escrever blocos de código em situações onde a criação de um método separado seria inconveniente ou desnecessário. Elas oferecem vantagens em termos de concisão, legibilidade, flexibilidade e encerramento de escopo.

Quando não é recomendado o uso de código lambda?
Complexidade excessiva: Se a lógica da expressão lambda se tornar muito complexa ou difícil de entender, é preferível usar métodos e blocos de código separados para manter a clareza e legibilidade do código.

Reutilização de código: Se você precisa reutilizar a lógica em várias partes do seu código, é mais adequado criar um método separado em vez de usar uma função lambda repetidamente. Isso promove a reutilização do código e torna mais fácil a manutenção.

Aumento da complexidade do código: Em alguns casos, o uso excessivo de funções lambda pode tornar o código mais difícil de entender e dar manutenção, especialmente quando as expressões lambdas são aninhadas. Nesses casos, pode ser melhor dividir o código em partes menores e mais legíveis.

Embora as funções lambda sejam uma ferramenta poderosa e muito usada no mundo de desenvolvimento C#, há situações em que é mais apropriado evitar o seu uso.
 */
/*
 Propriedade ou atributo?

No C#, um atributo é uma variável declarada dentro de uma classe que armazena dados associados a uma instância específica desta classe e uma propriedade é uma abstração que fornece um meio de acessar e modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita. Veja o exemplo de código abaixo que contém uma classe com um atributo e uma propriedade:
class Filme
{
    public string Titulo;

    public int Orcamento { get; set; }
}

Um exemplo da instância desta classe seria:
Filme matrix = new Filme();
matrix.Titulo = "Matrix";
matrix.Orcamento = 63;


 */
/*
 Desafio:
1-Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
2-Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
3-Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
4-Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.
 */
/*
Produto camiseta = new()
{
    Nome = "Camiseta",
    Marca = "Nike Air",
    Estoque = 40,
 };
Console.WriteLine(camiseta.DescricaoProduto);

Produto exibir = new();
exibir.ExibirDesconto();
*/

/*
 No C#, uma função lambda pode ser aplicada em atributos, propriedades ou na forma como escrevemos funções. Abaixo, existe uma função que soma 2 valores inteiros e retorna o resultado da soma, como mostra o trecho de código a seguir:
public int Somar(int a, int b)
{
    int resultado = a + b;
    return resultado;
}
Agora é sua vez! Refaça esse método Somar() usando uma função lambda retornando o resultado da operação.

public int Somar(int a, int b) => a + b;

Nesta versão, utilizamos a sintaxe de expressão lambda, que é uma forma concisa de definir funções anônimas. No caso, a expressão lambda recebe dois parâmetros a e b do tipo int e retorna a soma dos valores utilizando a expressão a + b.

Lembrando: Essa forma simplificada de escrever a função é útil quando a função tem apenas uma linha de código e o retorno é direto, permitindo economizar espaço e tornar o código mais conciso.
 */
/*
 Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.

Titular titular1 = new();
titular1.Nome = "Romário";
titular1.Cpf = "12213134-43";
titular1.Endereco = "Rua 213 - Liverpool";

ContaBancaria conta1 = new();
conta1.Titular = titular1;
conta1.Agencia = 1234;
conta1.Saldo = 2000.0;
conta1.limite = 300.0;
conta1.NumContaBancaria = 1334;

Console.WriteLine(conta1.informacoes);
*/
/*
 Desenvolver uma classe que represente um estoque de produtos, 
e que tenha as funcionalidades de adicionar novos produtos,
e exibir todos os produtos no estoque.
 */
/*
Produto produto1 = new Produto();
produto1.Nome = "Camisa";
produto1.Marca = "Nike Air";
produto1.Estoque = 20;
produto1.Preco = 78;
produto1.ValorPromocao = 65;


Estoque estoque1 = new Estoque();
estoque1.AdicionarProduto(produto1);

Produto produto2 = new Produto();
produto2.Nome = "Tenis";
produto2.Marca = "Nike SB";
produto2.Estoque = 10;
produto2.Preco = 280;
produto2.ValorPromocao = 256;

Estoque estoque2 = new Estoque();   
estoque2.AdicionarProduto(produto2);

estoque1.ExibirProdutos();
estoque2.ExibirProdutos();
*/
/*
 * Modelar o sistema de uma escola. Crie classes para Aluno, 
 * Professor e Disciplina. A classe Aluno deve ter informações como nome, 
 * idade e notas. A classe Professor deve ter informações sobre nome e 
 * disciplinas lecionadas. A classe Disciplina deve armazenar o 
 * nome da disciplina e a lista de alunos matriculados.
 */

/*
 * Modelar um sistema para um restaurante com classes como Restaurante,
 * Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem 
 * ser reservadas e um cardápio com itens que podem ser pedidos. 
 * Os pedidos podem estar associados a uma mesa.
 */


