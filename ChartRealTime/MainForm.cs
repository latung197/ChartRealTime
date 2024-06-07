namespace ChartRealTime
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }


        public void CreateChart(double[] dataX, double[] dataY)
        {
            chart1.Invoke(new Action(() =>
            {
                chart1.Plot.Add.Scatter(dataX, dataY);
                chart1.Refresh();
            }));

        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                double[] DX = new double[1, 1, 3, 4, 1];
                double[] DY = new double[1, 2, 3, 4, 5];
                CreateChart(DX, DY);


            });

        }
    }
}
