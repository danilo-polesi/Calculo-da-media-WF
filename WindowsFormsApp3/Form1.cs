using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double nota4 = Convert.ToDouble(txtNota4.Text);
            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            

            if (media >= 6)
            {
                listaAprovados.Items.Add(nome);
                lblAprovados.Text = listaAprovados.Items.Count.ToString();
                MessageBox.Show("Aprovado!");
                comboBox1.Items.Add(nome);
            }
            else
            {
                listaRecuperacao.Items.Add(nome);
                lblRecuperacao.Text = listaRecuperacao.Items.Count.ToString();
                MessageBox.Show("Reprovado!");
                comboBox2.Items.Add(nome);
            }
            txtNome.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            txtNome.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparlistas_Click(object sender, EventArgs e)
        {
            listaAprovados.Items.Clear();
            listaRecuperacao.Items.Clear();
            lblRecuperacao.Text = "";
            lblAprovados.Text = "";
            txtNome.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
