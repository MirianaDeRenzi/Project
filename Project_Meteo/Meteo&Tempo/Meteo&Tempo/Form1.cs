using MySql.Data.MySqlClient;
using System.Linq.Expressions;
namespace Meteo_Tempo
{
    public partial class Form1 : Form
    {
        String Connection = "server = 127.0.0.1;" +
                            "database = meteotempo;" +
                            "uid = ;" +//user
                            "pwd = ";//pass
        public Form1()
        {
            InitializeComponent();
            Tabella();
        }
        public void Tabella()
        {
            dataGridView1.Rows.Clear();
            MySqlConnection cnn = new MySqlConnection(Connection);

            try
            {
                cnn.Open();

                string query = "SELECT * FROM statistiche";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                                           dr.GetInt32("id").ToString(),
                                           dr.GetDouble("temperatura").ToString()+("°"),
                                           dr.GetDateTime("orario").ToString("il dd/MM/yyyy alle HH:mm:ss")); // HH=24 - hh=12
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nella connessione al database  " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            buttonUpdate.Visible = true;
            buttonClear.Visible = true;
            buttonChart.Visible = true;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Tabella();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        private void buttonChart_Click(object sender, EventArgs e)
        {
            Form_chart chart = new Form_chart();
            chart.Show();
           //chart.ShowDialog(); non si può interagire con altre finestre finchè non viene chiusa          
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
