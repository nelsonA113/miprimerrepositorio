using Evaluator.Logic;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DPotencia_Click(object sender, EventArgs e)
        {
            Display.Text += "^";
        }

        private void DAbrir_Click(object sender, EventArgs e)
        {
            Display.Text += "(";
        }

        private void DCerrar_Click(object sender, EventArgs e)
        {
            Display.Text += ")";
        }

        private void DDividir_Click(object sender, EventArgs e)
        {
            Display.Text += "/";
        }

        private void DSeven_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        private void DEight_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        private void DNine_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        private void DMultiplicacion_Click(object sender, EventArgs e)
        {
            Display.Text += "*";
        }

        private void DFour_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        private void DFive_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        private void DSix_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        private void DRest_Click(object sender, EventArgs e)
        {
            Display.Text += "-";
        }

        private void DOne_Click(object sender, EventArgs e)
        {
            Display.Text += "1";
        }

        private void DTwo_Click(object sender, EventArgs e)
        {
            Display.Text += "2";
        }

        private void DTree_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
        }

        private void DSuma_Click(object sender, EventArgs e)
        {
            Display.Text += "+";
        }

        private void DPunto_Click(object sender, EventArgs e)
        {
            Display.Text += ".";
        }

        private void DZero_Click(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        private void DLimpiar_Click(object sender, EventArgs e)
        {
            Display.Text = string.Empty;
        }

        private void DDelete_Click(object sender, EventArgs e)
        {
            Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
        }

        private void DIgual_Click(object sender, EventArgs e)
        {
            Display.Text += $"={FunctionEvaluator.Evalute(Display.Text)}";
        }
    }
}
