using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace ConexaoBd
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Sql;
            int RowAffect = 0;

            MySqlConnection conexao = new MySqlConnection("Server = 127.0.0.1; database = cadastro_clientes; User ID = root; Password= ;");

            MySqlCommand comando = new MySqlCommand();

            Sql = "INSERT INTO  dados_Clientes (nome , data_nascimento , Telefone , Cpf , RG , UF , Sexo) VALUES ('" + txtNome.Text + " ',' " + mkbData.Text + " ',' " + mskbCelular.Text + "','" + mstCpf.Text + " ',' " + mskbRG.Text + " ',' " + cbbUF.Text + " ',' " + cbbSexo.Text + "') ";

            conexao.Open();

            comando.Connection = conexao;
            comando.CommandText = Sql;

            RowAffect = comando.ExecuteNonQuery();

            if (RowAffect == 1)
            {
                MessageBox.Show("Cadastro Realizado com Sucesso! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                mkbData.Text = "";
                mskbCelular.Text = "";
                cbbSexo.Text = "";
                mstCpf.Text = "";
                mskbRG.Text = "";
                cbbUF.Text = "";
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Cadastro Não Realizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            string SQL;
            int ROWAFFECT = 0;

            MySqlConnection conexao = new MySqlConnection("Server = 127.0.0.1; database = cadastro_clientes; User ID = root; Password= ;");

            MySqlCommand comando = new MySqlCommand();

            SQL= "DELETE FROM dados_Clientes WHERE Cpf  = " + "'" + mstCpf.Text + "'";

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;

            ROWAFFECT = comando.ExecuteNonQuery();

            if ( ROWAFFECT == 1 )
            {
                MessageBox.Show ("Cadastro Excluido" , "OK" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                mkbData.Text = "";
                txtNome.Focus ();

            }

            else
            {
                MessageBox.Show("Erro ao excluir cadastro");
            }
        }
    }
}
