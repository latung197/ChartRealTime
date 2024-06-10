using ScottPlot;
namespace ChartRealTime
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateChart();
        }


        public void CreateChart()
        {
            //var  ScottPlot.Version.ShouldBe(4, 1, 71);
            ScottPlot.Version.ShouldBe(4, 1, 71);
            var plt = new ScottPlot.Plot(600, 400);

            // sample data
            double[] xs = DataGen.Consecutive(51);
            double[] sin = DataGen.Sin(51);
            double[] cos = DataGen.Cos(51);

            // plot the data
            plt.AddScatter(xs, sin);
            plt.AddScatter(xs, cos);

            // customize the axis labels
            plt.Title("ScottPlot Quickstart");
            plt.XLabel("Horizontal Axis");
            plt.YLabel("Vertical Axis");


        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                //double[] DX = new double[1, 1, 3, 4, 1];
                //double[] DY = new double[1, 2, 3, 4, 5];
                //CreateChart(DX, DY);
            });

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
