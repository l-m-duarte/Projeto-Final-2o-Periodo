using System;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class FrmAddDono : Form
    {
        public FrmAddDono()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            bool retorno = con.insereDono(txtnome.Text);
            if (retorno == false)
                MessageBox.Show(con.mensagem);
            else
                MessageBox.Show("Dono adicionado");
            txtnome.Clear();
            txtnome.Focus();
        }
    }
}
