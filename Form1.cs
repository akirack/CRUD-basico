using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUD_basico
{
    public partial class Form1 : Form
    {

        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {

            try
            {

                conexao = new SqlConnection(@"Server=DESKTOP-S5LJFJH\SQLEXPRESS;Database=Clientes;User Id = sa; Password= akirack123;");

                strSQL = "INSERT INTO tbcliente (NOME, NUMERO) VALUES (@NOME, @NUMERO)";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@NOME", tbNome.Text);
                comando.Parameters.AddWithValue("@NUMERO", tbNumero.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

            }

            catch (Exception)
            {

                MessageBox.Show("Error");
            }

            finally
            {
                conexao.Close();

                conexao = null;
                comando = null;
            }


           

        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Server=DESKTOP-S5LJFJH\SQLEXPRESS;Database=Clientes;User Id = sa; Password= akirack123;");

                strSQL = "SELECT * FROM tbcliente";

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao);

                conexao.Open();

                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0];

            }

            catch (Exception)
            {

                MessageBox.Show("Error");
            }

            finally
            {
                conexao.Close();

                conexao = null;
                comando = null;
            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Server=DESKTOP-S5LJFJH\SQLEXPRESS;Database=Clientes;User Id = sa; Password= akirack123;");

                strSQL = "SELECT * FROM tbcliente WHERE ID =  @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", tbID.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    tbNome.Text = (string)dr["nome"];
                    tbNumero.Text = Convert.ToString(dr["numero"]);
                }


            }

            catch (Exception)
            {

                MessageBox.Show("Error");
            }

            finally
            {
                conexao.Close();

                conexao = null;
                comando = null;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Server=DESKTOP-S5LJFJH\SQLEXPRESS;Database=Clientes;User Id = sa; Password= akirack123;");

                strSQL = "UPDATE tbcliente SET NOME = @NOME,  NUMERO = @NUMERO WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", tbID.Text);
                comando.Parameters.AddWithValue("@NOME", tbNome.Text);
                comando.Parameters.AddWithValue("@NUMERO", tbNumero.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

            }

            catch (Exception)
            {

                MessageBox.Show("Error");
            }

            finally
            {
                conexao.Close();

                conexao = null;
                comando = null;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                conexao = new SqlConnection(@"Server=DESKTOP-S5LJFJH\SQLEXPRESS;Database=Clientes;User Id = sa; Password= akirack123;");

                strSQL ="DELETE tbcliente WHERE ID = @ID";

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID", tbID.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

            }

            catch (Exception)
            {

                MessageBox.Show("Error");
            }

            finally
            {
                conexao.Close();

                conexao = null;
                comando = null;
            }
        }
    }
    
}
