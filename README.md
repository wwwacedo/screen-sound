# OOP

#### Atributos `(fields)` e Propriedades `(properties)` em `C#` são diferentes

- Ambos são usados para armazenar e manipular dados em uma classe
- **Atributo**: variável declarada dentro de uma classe que armazena dados associados a uma instância específica desta classe;
- **Propriedade**: abstração que fornece um meio de acessar e modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita.

```csharp
class Filme
{
  public string Titulo; // atributo
  public int Orcamento { get; set; } // propriedade sem lambda expression
}
```

#### Propriedade `sem` Lambda expression

```csharp
public string DescricaoResumida
{
  get
  {
    return $"A musica '{Nome}' pertence ao artista '{Artista}'";
  }
}
```

#### Propriedade `com` Lambda expression

```csharp
public string DescricaoResumida => $"A musica '{Nome}' pertence ao artista '{Artista}'";
```

#### Instanciando objeto com propriedades opcionais

```csharp
Musica musica1 = new Musica(queen, "Love of My Life", rock) {
  Duracao = 213,
  Disponivel = true
};
```

