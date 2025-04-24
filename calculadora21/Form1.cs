namespace calculadora21
{
    public partial class Form1 : Form
    {
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public decimal Resultado { get; set; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

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

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {

                OperacaoSelecionada = Operacao.Subtracao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                label1.Text = "-";
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                OperacaoSelecionada = Operacao.Multiplicacao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                label1.Text = "*";
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {

                OperacaoSelecionada = Operacao.Divisao;
                Valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                label1.Text = "/";
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
                txtResultado.Text += ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))
            {
                decimal segundoValor = Convert.ToDecimal(txtResultado.Text);

                switch (OperacaoSelecionada)
                {
                    case Operacao.Adicao:
                        Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            label1.Text = "";
            Valor = 0;
            Resultado = 0;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

