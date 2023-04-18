# Classes, atributos, métodos, membros estáticos

## Classes

### Uma classe é uma estrutura de programação que define um conjunto de métodos e atributos que descrevem um objeto. É uma abstração que encapsula um conjunto de dados e comportamentos relacionados, permitindo a criação de objetos que possuem essas características.

<hr>

## Atributos

### Os atributos são as características ou propriedades que um objeto possui. Eles armazenam informações sobre o estado do objeto. Cada objeto pode ter diferentes valores para seus atributos, e esses valores podem ser alterados durante a execução do programa.

<hr>

## Métodos

### Os métodos são as ações que um objeto pode executar. Eles representam o comportamento do objeto e podem ser usados para alterar o estado dos atributos ou realizar alguma ação específica. Um método pode receber parâmetros e retornar valores.

<hr>

## Membros estáticos

### Membros estáticos são aqueles que pertencem à classe em vez de pertencerem a cada instância da classe. Isso significa que eles são compartilhados por todas as instâncias da classe. Por exemplo, uma variável estática pode ser usada para contar o número de instâncias criadas da classe. Métodos estáticos também são possíveis e podem ser usados sem a necessidade de criar uma instância da classe.

<hr>

## Encapsulamento

### Encapsulamento é a técnica de esconder os detalhes de implementação de uma classe e expor apenas uma interface pública para o usuário. Isso permite que o usuário use a classe sem se preocupar com a implementação interna, e também protege os dados internos da classe de modificações não autorizadas.

## Exemplo

    class Pessoa {
        private $nome;
        private static $totalPessoas = 0;

        public function __construct($nome) {
            $this->nome = $nome;
            self::$totalPessoas++;
        }

        public function getNome() {
            return $this->nome;
        }

        public static function getTotalPessoas() {
            return self::$totalPessoas;
        }
    }

    $pessoa1 = new Pessoa("João");
    $pessoa2 = new Pessoa("Maria");

    echo $pessoa1->getNome() . "\n"; // João
    echo Pessoa::getTotalPessoas() . "\n"; // 2


## Neste exemplo, temos uma classe Pessoa com um atributo $nome e um membro estático $totalPessoas, que é incrementado a cada nova instância criada. O método getNome() retorna o nome da pessoa e o método estático getTotalPessoas() retorna o número total de instâncias da classe Pessoa criadas.

