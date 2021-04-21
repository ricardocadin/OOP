# Já ouviu falar de Programação Orientação a Objetos?

Apesar de ser um conceito inicial e sempre nos deparamos com ele na universidade ou em cursos básicos de programação, a orientada a objetos permear diversos tópicos e padrões mais avançados voltados para desenvolvimento/arquitetura de software. 

Quando falamos de OOP (Programação Orientada a Objetos) é extremamente comum se ouvir as exigências de baixo acoplamento e alta coesão, não é mesmo? Mas o que isso significa?  Quando dizemos que deve ter um baixo acoplamento, estamos nos referindo diretamente a dependência de um objeto por outro, ou seja, quando um deles muda o outro muda por consequência. No caso da coesão é o contrário, temos objetos com uma única responsabilidade e livres de qualquer dependência direta com outro objeto, ou seja, temos uma maior flexibilidade para mudanças.

Sem falar que esse tema é amplamente abordado no mercado de trabalho e em provas técnicas, posso te garantir que quando for se aplicar para uma vaga de desenvolvimento esses conceitos estarão lá para validar seu conhecimento. Por isso, é extremamente importante dominar os pilares fundamentais e também saber como aplicá-los para alcançar as melhores práticas com design de código, padrões e abordagens arquiteturais.

E quais são esses pilares?

-	Estado
-	Comportamento
-	Abstração
-	Herança
-	Polimorfismo
-	Encapsulamento

## Estado e Comportamento

Antes de explicar o que de fato é um estado e comportamento temos de abordar dois conceitos iniciais que explicam o que são Classes e o que são Objetos.

Classes nada mais são do que uma estrutura que visa representar qualquer objeto do mundo real, ou seja, é um mapeamento que leva a representação por meio de uma estrutura informação.

Agora um objeto é uma instância de uma classe, ou seja, a partir do momento que você está criando uma determinada classe e atribuindo valores as suas propriedades para uma representação temporária na memória como um objeto.

Agora que entendemos essa diferença, podemos explicar o que é um estado e o que é um comportamento. Vamos supor que temos uma classe pessoa e ela possui as propriedades de nome e data de nascimento e um método de retornar à idade da pessoa com base no ano anual e sua data de nascimento.

O estado basicamente seria o objeto daquela classe estar armazenando algumas informações em determinado momento, ou seja, a classe pessoa tem uma propriedade nome que possui o valor “João” e que possui a data de nascimento com valor “02/01/2000” por exemplo.

Já o comportamento é tudo aquilo capaz de gerar ou processa uma informação através da própria classe, como assim? Lembra do método de calcular a idade da pessoa, pois é, ele é um comportamento capaz de devolver essa informação com base em um comportamento gerando uma informação.

## Herança 

A herança é bem simples de entender dentro da OOP, digamos que temos uma classe funcionário e que ela tenha as suas propriedades que a representam, como por exemplo, data de admissão e seu registro. Agora, lembra da nossa classe pessoa? Ela possui as informações de nome e de data de nascimento que também podem estar como propriedades em nossa classe funcionário.

Mas pera aí, não podemos dizer que o funcionário é uma pessoa? Sim e essa é a ideia da herança, não precisamos repetir as informações estruturais (propriedades) de uma classe sendo que temos uma mais genérica do mesmo tipo. Basicamente estamos dizendo que a classe funcionário é uma especialização da classe pessoa, ou seja, compartilha de algumas informações com sua classe mãe principal, porém pois algumas informações que são restritas a ela.

A e não vamos esquecer que ao herdar as estruturas de uma classe mãe, estamos nos referindo tanto as suas propriedades como também comportamentos (métodos).

## Abstração

E se eu te dissesse que a abstração é uma forma de criar um conceito genérico, ou seja, uma superclasse para apoiar a herança de forma que ela seja sempre herdada por suas classes filhas para especializar o seu comportamento. Mas qual a diferença para uma herança simples? Uma classe que é abstrata ela não pode ser instanciada para ser utilizada diretamente, pelo contrário, ela oferece comportamentos e informações básicas que todas as suas especializações (filhas) terão e poderão ter a escolha de implementar.

Mas como é isso, digamos que temos uma superclasse abstrata de eletrodomésticos com as informações de nome e sua voltagem. Além disso, temos o comportamento abstrato de ligar e desligar o que naturalmente todo eletrodoméstico faz. Porém, não ensinamos o eletrodoméstico a ligar ou desligar, simplesmente dizemos que ele possui esses comportamentos e que a classe filha que o herdar é obrigada a codificar tal forma de realizar essas ações.

Digamos que temos as classes filhas micro-ondas e liquidificador, ambas terão informações a respeito de nome e voltagem da classe abstrata pai e também terão formas diferente de ligar e desligar. Além disso, cada uma pode especializar demais comportamentos ou informações, como por exemplo um liquidificador que liquidifica alimentos o que um micro-ondas não faz.

Vale lembrar que o fato de ser uma classe abstrata não impede de ter um comportamento que não seja abstrato, ou seja, a classe pode ter um comportamento implementado dentro dela mesma para reutilização das filhas, ou seja, o que já é realizado naturalmente pela herança. 

## Polimorfismo

Lembra do exemplo de micro-ondas e liquidificador dado quando falei sobre abstração? A essência da palavra polimorfismo nos dá a ideia de vários comportamentos e tem uma relação direta com a abstração pelo motivo de realizar a sobrescrita dos comportamentos abstratos, como também possui a capacidade de adicionar novos comportamentos em sua especialização.

No exemplo anterior do liquidificador, teríamos a sobrescrita dos comportamentos de ligar e desligar (obrigatoriamente por ser abstrato os comportamentos na classe mãe) e poderíamos também ter outros comportamentos como liquidificar um alimento, triturar em uma velocidade diferente etc.

Um conceito chave do polimorfismo é essa possibilidade de literalmente sobrescrever ou mudar um comportamento da sua classe mãe, possibilitando essa pluralidade que está implícita no significado da palavra.

## Encapsulamento

É a arte de esconder comportamentos através da exposição de métodos públicos e escrita de métodos privados de uma determinada classe. Com certeza você já ouviu alguém dizer que somente está utilizando o método e não sabe como ele funciona internamente, ou seja, a famosa caixa preta. Além disso, esse conceito está internamente ligado a modificadores de acesso aos estados e comportamentos de uma classe:

- **Public**: o acesso não é restrito
- **Protected**: o acesso é restrito e limitado a classes filhas que estão herdando de uma classe principal
- **Internal**: o acesso é limitado somente por aquele assembly, ou seja, apenas aquele projeto (dll) possui acesso
- **Protected Internal**: o acesso é para aqueles que estão dentro do próprio assembly ou que esteja herdando de uma classe principal. Modificador exclusivo para métodos
- **Private**: o acesso é privado e limitado a somente a aquele tipo
- **Private Protected**: o acesso é privado e limitado para o contexto da classe e para classes derivadas dela que estejam no mesmo assembly. Modificador exclusivo para métodos.
- **Sealed**: exclusivo para classes e impede que ela seja herdada por alguma outra

## Interface vs Implementação

Esse conceito é extremamente importante, pois está ligado diretamente ao alto acoplamento entre classes e componentes. A ideia é, sempre dependa de uma interface ao invés de realizar uma implementação direta.

Mas o que seria uma implementação direta? Seria você realizar a criação direta de uma instância em uma classe que está consumindo os recursos que determinado objeto tenha, ou seja, você está acessando a classe de dependência de maneira direta e caso ela mude algum tipo de contrato em seu construtor por exemplo, a classe consumidora sofrerá com essa mudança e é aí que surge o alto acoplamento.

No caso de uso de interfaces ao invés da classe concreta você basicamente está dizendo que sua classe consumidora depende de um determinado contrato em que alguma classe está implementando. Você não sabe qual é essa classe e a forma que ela está implementando esses comportamentos, basicamente você quer utilizar e deixa que alguma biblioteca resolva a instanciação dessa classe. Aqui estamos falando de Injeção de Dependência, mas isto é um assunto para outro tópico.

Ao utilizar dessa forma, interfaces ao invés de implementação você está mais seguro de forma a ter um menor acoplamento entre as classes e aumenta a coesão uma vez que você não precisa saber como criar uma instância da classe que irá consumir.
