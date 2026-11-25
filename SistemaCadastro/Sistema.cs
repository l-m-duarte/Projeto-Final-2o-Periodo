using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Sistema : Form
    {
        int idAlterar;

        public Sistema()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            marcador.Height = btnCadastra.Height;
            marcador.Top = btnCadastra.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[0];
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            marcador.Height = btnBusca.Height;
            marcador.Top = btnBusca.Top;
            tabControl1.SelectedTab = tabControl1.TabPages[1];
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            listaCBDonos();
            lista_gridEletrodomesticos();
        }

        void lista_gridEletrodomesticos()
        {
            ConectaBanco con = new ConectaBanco();
            dgEletrodomesticos.DataSource = con.listaEletrodomesticos();
        }

        public void listaCBDonos()
        {
            ConectaBanco con = new ConectaBanco();
            DataTable tabelaDados = con.listaDonos();
            cbDono.DataSource = tabelaDados;
            cbDono.DisplayMember = "dono";
            cbDono.ValueMember = "iddono";

            cbAlteraDono.DataSource = tabelaDados;
            cbAlteraDono.DisplayMember = "dono";
            cbAlteraDono.ValueMember = "iddono";
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (dgEletrodomesticos.DataSource is DataTable)
            {
                (dgEletrodomesticos.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("nome like '{0}%'", txtBusca.Text);
            }
        }

        private void btnRemoveEletrodomestico_Click(object sender, EventArgs e)
        {
            int linha = dgEletrodomesticos.CurrentRow.Index;
            int id = Convert.ToInt32(
                dgEletrodomesticos.Rows[linha].Cells["ideletrodomestico"].Value.ToString());
            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir?",
                "Remover Eletrodoméstico", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                ConectaBanco con = new ConectaBanco();
                bool retorno = con.deletaEletrodomestico(id);
                if (retorno == true)
                {
                    MessageBox.Show("Eletrodoméstico excluído com sucesso!");
                    lista_gridEletrodomesticos();
                }
                else
                    MessageBox.Show(con.mensagem);
            }
            else
                MessageBox.Show("Exclusão cancelada");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int linha = dgEletrodomesticos.CurrentRow.Index;
            idAlterar = Convert.ToInt32(
                dgEletrodomesticos.Rows[linha].Cells["ideletrodomestico"].Value.ToString());
            txtAlteraNome.Text =
                dgEletrodomesticos.Rows[linha].Cells["nome"].Value.ToString();
            txtAlteraPotencia.Text =
                dgEletrodomesticos.Rows[linha].Cells["potencia"].Value.ToString();
            txtAlteraTempoMedioAtivo.Text =
                dgEletrodomesticos.Rows[linha].Cells["tempoMedioAtivo"].Value.ToString();
            cbAlteraDono.Text =
                dgEletrodomesticos.Rows[linha].Cells["dono"].Value.ToString();
            tabControl1.SelectedTab = tabAlterar;
        }

        private void btnConfirmaAlteracao_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Eletrodomestico novoEletrodomestico = new Eletrodomestico();
            novoEletrodomestico.Nome = txtAlteraNome.Text;
            novoEletrodomestico.Potencia = Convert.ToDouble(txtAlteraPotencia.Text);
            novoEletrodomestico.TempoMedioAtivo = Convert.ToDouble(txtAlteraTempoMedioAtivo.Text);
            novoEletrodomestico.Dono = Convert.ToInt32(cbAlteraDono.SelectedValue.ToString());

            bool retorno = con.alteraEletrodomestico(novoEletrodomestico, idAlterar);
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }
            lista_gridEletrodomesticos();
        }

        private void bntAddDono_Click(object sender, EventArgs e)
        {
            FrmAddDono formDono = new FrmAddDono();
            this.Hide();
            formDono.ShowDialog();
            this.Show();
            listaCBDonos();
        }

        void limpaCampos()
        {
            txtnome.Clear();
            cbDono.Text = "";
            txtPotencia.Clear();
            txtTempoMedioAtivo.Clear();
            txtnome.Focus();
        }

        private void BtnConfirmaCadastro_Click(object sender, EventArgs e)
        {
            ConectaBanco con = new ConectaBanco();
            Eletrodomestico novoEletrodomestico = new Eletrodomestico();
            novoEletrodomestico.Nome = txtnome.Text;
            novoEletrodomestico.Potencia = Convert.ToDouble(txtPotencia.Text);
            novoEletrodomestico.TempoMedioAtivo = Convert.ToDouble(txtTempoMedioAtivo.Text);
            novoEletrodomestico.Dono = Convert.ToInt32(cbDono.SelectedValue.ToString());

            bool retorno = con.insereEletrodomestico(novoEletrodomestico);
            if (retorno == false)
            {
                MessageBox.Show(con.mensagem);
            }
            limpaCampos();
            lista_gridEletrodomesticos();
        }

        private void cbDono_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
