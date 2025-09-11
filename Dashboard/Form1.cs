


using DashboardLiveChartsExample;
using LiveCharts.Defaults;
using LiveCharts;
using LiveCharts.Wpf;



namespace Dashboard
{
    public partial class Form1 : Form
    {
        private DatabaseServices _databaseService;
        private object kpis;
        private object pieChart1;

        public Form1()
        {
            InitializeComponent();
            //SetupKPIs();
            //SetupLineChart();
            _databaseService = new DatabaseServices(
             server: "localhost",
             database: "DashboardDB",
             userId: "root",
             password: "Info@2025"
             );

            //Carregar dados  do banco
            LoadDashboardData();

        }

        private void LoadDashboardData()
        {
            try
            {
                //1. Carregar e configurar KPIs
                SetupKPIs();
                //2.Carregar Configurar gráfico de linhas
                SetupLineChart();
                //3. Carregar e configurar gráfico de pizza
                SetupPieChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SetupKPIs()
        {
            var KPIs = _databaseService.ObterKPIs();
            //Supondo que temos menos de 4 KPIs na ordem correta
            if (KPIs.Count >= 4)
            {
                labelkpi1.Text = $"{KPIs[0].Valor.ToString("C2")}";
                labelkpi1Desc.Text = KPIs[0].Nome;

                labelkpi2.Text = $"{KPIs[1].Valor} {KPIs[1].Unidade}";
                labelkpi2Desc.Text = KPIs[1].Nome;

                labelkpi3.Text = $"{KPIs[2].Valor.ToString("C2")}";
                labelkpi3Desc.Text = KPIs[2].Nome;

                labelkpi4.Text = $"{KPIs[3].Valor} {KPIs[3].Unidade}";
                labelkpi4Desc.Text = KPIs[3].Nome;
            }

        }
        private void SetupLineChart()
        {
            var vendas = _databaseService.ObterVendasMensais();
            var lineSeries = new LineSeries
            {
                Title = "Vendas Mensais",
                Values = new ChartValues<decimal>(vendas.Select(v => v.Valor)),
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

            pieChart2.Series = pieSeriesCollection;
            pieChart2.InnerRadius = 50;
            pieChart2.LegendLocation = LegendLocation.Bottom;
        }

        // Botão para atualizar os dados
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            MessageBox.Show("Dados atualizados com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}

