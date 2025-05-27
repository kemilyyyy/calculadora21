*Namespace*

```csharp
namespace calculadora21
```

Agrupa todo o código dentro do projeto chamado `calculadora21`.

*Classe Form1*

```csharp
public partial class Form1 : Form
```

Classe principal do formulário, herdando de `Form`, que representa a janela da interface.

*Propriedades*

```csharp
public decimal Resultado { get; set; }
public decimal Valor { get; set; }
private Operacao OperacaoSelecionada { get; set; }
```
`Valor`: Armazena o primeiro número digitado.
`Resultado`: Guarda o resultado do cálculo.
`OperacaoSelecionada`: Guarda qual operação matemática o usuário escolheu.

*Enum Operacao*

```csharp
private enum Operacao
{
    Adicao,
    Subtracao,
    Multiplicacao,
    Divisao
}
```

Enumeração que define os tipos de operações possíveis: soma, subtração, multiplicação e divisão.


*Construtor*

```csharp
public Form1()
{
    InitializeComponent();
}
```

Inicializa os componentes da interface quando o formulário é carregado.

*Botões Numéricos*

Cada botão adiciona seu número ao campo de texto:

```csharp
private void btnX_Click(object sender, EventArgs e)
{
    txtResultado.Text += "X";
}
```

* Exemplo com o número 1:

```csharp
private void btn1_Click(object sender, EventArgs e)
{
    txtResultado.Text += "1";
}
```

*Botões de Operações*

Exemplo: *Adição*

```csharp
private void btnAdicao_Click(object sender, EventArgs e)
{
    if (!string.IsNullOrEmpty(txtResultado.Text))
    {
        OperacaoSelecionada = Operacao.Adicao;
        Valor = Convert.ToDecimal(txtResultado.Text);
        txtResultado.Text = "";
        label1.Text = "+";
    }
}
```

Verifica se o campo `txtResultado` não está vazio.
Salva o número digitado na variável `Valor`.
Define que a operação escolhida é adição.
Limpa o campo de texto para digitar o próximo número.
Atualiza o `label1` com o símbolo "+".

(Para subtração, multiplicação e divisão o processo é o mesmo, mudando o operador.)

*Botão da Vírgula*

```csharp
private void btnVirgula_Click(object sender, EventArgs e)
{
    if (!txtResultado.Text.Contains(","))
        txtResultado.Text += ",";
}
```
Adiciona a vírgula decimal se ela ainda não estiver no texto.

*Botão Igual*

```csharp
private void btnIgual_Click(object sender, EventArgs e)
{
    if (!string.IsNullOrEmpty(txtResultado.Text))
    {
        decimal segundoValor = Convert.ToDecimal(txtResultado.Text);

        switch (OperacaoSelecionada)
        {
            case Operacao.Adicao:
                Resultado = Valor + segundoValor;
                break;
            case Operacao.Subtracao:
                Resultado = Valor - segundoValor;
                break;
            case Operacao.Multiplicacao:
                Resultado = Valor * segundoValor;
                break;
            case Operacao.Divisao:
                if (segundoValor != 0)
                    Resultado = Valor / segundoValor;
                else
                    MessageBox.Show("Não é possível dividir por zero!");
                break;
        }

        txtResultado.Text = Convert.ToString(Resultado);
        label1.Text = "=";
    }
}
```

Executa a operação escolhida.
Calcula o resultado de acordo com a operação.
Se a operação for divisão, verifica se o divisor não é zero.
Mostra o resultado no campo `txtResultado`.

*Botão Limpar*

```csharp
private void btnLimpar_Click(object sender, EventArgs e)
{
    txtResultado.Text = "";
    label1.Text = "";
    Valor = 0;
    Resultado = 0;
}
```

Limpa tudo: campo de texto, label e as variáveis `Valor` e `Resultado`.

*Evento txtResultado\_TextChanged*

```csharp
private void txtResultado_TextChanged(object sender, EventArgs e)
{
}
```

Está vazio. Esse evento é disparado quando o texto do campo muda, mas não está sendo usado no código.

*Resumo*

* Você digita o primeiro número.
* Clica na operação (+, -, \*, /).
* Digita o segundo número.
* Clica no igual (=) para ver o resultado.
* Usa o botão limpar (C) para começar um novo cálculo.
