

using System.Numerics;
using DashboardLiveChartsExample;
using LiveCharts.Defaults;
using LiveCharts;
using LiveCharts.Wpf;


namespace Dashboard
{
    public partial class Form1 : Form
    {
        private object _databaseService;
        private object pieChart1;

        public Form1()
        {
            InitializeComponent();
            SetupKPIs();
            SetupLineChart();
            
        }

        private void SetupLineChart()
        {
            //Cria uma nova Série do tipo Line ( linha)
            var lineSeries = new LineSeries
            {
                Title = "Vendas Mensais",
                //Usaremos valores numéricos (double) para o eixo Y
                Values = new ChartValues<double> { 42321,  53211, 48975, 65234, 71230, 82321, 82345, 94412, 101200, 88123, 75321, 112450 },
            };
        }

        private void SetupKPIs()
        {
            labelkpi1Desc.Text = "Receita Total (Mês)";
            labelkpi1.Text = "R$ 152.304,05";

            labelkpi2.Text = "1.284";
            labelkpi2Desc.Text = "Total de Vendas";

            labelkpi3.Text = "R$ 118,57";
            labelkpi3Desc.Text = "Ticket Médio";

            labelkpi4.Text = "12.4%";
            labelkpi4Desc.Text = "Crescimento Anual"; 

        }

    }
     private void SetupLineChart()
        {
            var vendas = _databaseService.ObterVendasMensais();

            var lineSeries = new LineSeries
            {
                Title = "Vendas Mensais",
                Values = new ChartValues<double>(vendas.Select(v => (double)v.Valor)),
                Fill = System.Windows.Media.Brushes.Transparent,
                StrokeThickness = 3,
                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 10,
                PointForeground = System.Windows.Media.Brushes.White
            };

            cartesianChart1.Series = new SeriesCollection { lineSeries };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Mês",
                Labels = vendas.Select(v => v.Mes).ToArray()
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Vendas (R$)",
                LabelFormatter = value => value.ToString("C0")
            });

            cartesianChart1.LegendLocation = LegendLocation.Top;
        }

        private void SetupPieChart()
        {
            var marketShare = _databaseService.ObterMarketShare();

            var pieSeriesCollection = new SeriesCollection();

            foreach (var item in marketShare)
            {
                pieSeriesCollection.Add(new PieSeries
                {
                    Title = item.Empresa,
                    Values = new ChartValues<ObservableValue> { new ObservableValue((double)item.Percentual) },
                    DataLabels = true,
                    LabelPoint = chartPoint => $"{chartPoint.Y}%"
                });
            }

            pieChart1.Series = pieSeriesCollection;
            pieChart1.InnerRadius = 50;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        // Botão para atualizar os dados
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            MessageBox.Show("Dados atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadDashboardData()
        {
            throw new NotImplementedException();
        }
    }
}

