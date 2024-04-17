using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Media;
using LiveCharts.Defaults;
using LiveCharts.WinForms;

namespace Meteo_Tempo
{
    public partial class Form_chart : Form
    {
        String Connection = "server = 127.0.0.1;" +
                            "database = meteotempo;" +
                            "uid = ;" +//user
                            "pwd= ";//pass

        public SeriesCollection seriesCollection = new SeriesCollection();
        private List<DateTime> original_Date = new List<DateTime>();

        public Form_chart()
        {
            InitializeComponent();
            Value_chart();
            Graphic();
        }

        public void Value_chart()
        {
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Orario"
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Temperatura"
            });


            cartesianChart1.Series = seriesCollection;
            cartesianChart1.Zoom = ZoomingOptions.Xy;
            cartesianChart1.ScrollMode = ScrollMode.X;
        }

        public void Graphic()
        {
            seriesCollection.Clear();
            MySqlConnection cnn = new MySqlConnection(Connection);

            try
            {
                cnn.Open();

                string query = "SELECT temperatura, orario FROM statistiche";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                MySqlDataReader dr = cmd.ExecuteReader();


                ChartValues<double> temperature_Double= new ChartValues<double>();
                List<DateTime> orario_DateTime = new List<DateTime>();

                while (dr.Read())
                {
                    DateTime orario = dr.GetDateTime("orario");
                    double temperatura = dr.GetDouble("temperatura");

                    orario_DateTime.Add(orario);
                    original_Date.Add(orario);
                    temperature_Double.Add(temperatura);
                }

                if (orario_DateTime.Count > 0 && temperature_Double.Count > 0)
                {
                    cartesianChart1.AxisX[0].Labels = orario_DateTime.Select(date => date.ToString("dd/MM/yyyy HH:mm:ss")).ToArray();

                    seriesCollection.Add(new LineSeries
                    {
                        Title = "Temperatura",
                        Values = temperature_Double,
                        Stroke = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 41)),
                        StrokeThickness = 2.5, 
                        StrokeDashArray = new System.Windows.Media.DoubleCollection(100),
                        Fill = System.Windows.Media.Brushes.Transparent,
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il recupero dei dati: " + ex.Message);
            }
            finally
            {
                cnn.Close();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Graphic();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                //cordinate X Y minime/massime
                double minX = seriesCollection.SelectMany(series => (ChartValues<double>)series.Values).Min();
                double maxX = seriesCollection.SelectMany(series => (ChartValues<double>)series.Values).Max();
                double minY = seriesCollection.SelectMany(series => (ChartValues<double>)series.Values).Min();
                double maxY = seriesCollection.SelectMany(series => (ChartValues<double>)series.Values).Max();

                // orientamento di X 
                cartesianChart1.AxisX.Clear();
                cartesianChart1.AxisX.Add(new Axis
                {
                    MinValue = minX,
                    MaxValue = maxX,
                    Labels = original_Date.Select(date => date.ToString("dd/MM/yyyy HH:mm:ss")).ToArray()
                });

                // orientamento di Y
                cartesianChart1.AxisY.Clear();
                cartesianChart1.AxisY.Add(new Axis
                {
                    MinValue = minY,
                    MaxValue = maxY,
                });

                // new point 0/0
                cartesianChart1.Location = new Point(0, 0);
            }
            catch (LiveCharts.Helpers.LiveChartsException ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }
    }
}
