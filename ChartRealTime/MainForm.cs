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
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };

            chart1.Plot.Add.Scatter(dataX, dataY);
            chart1.Refresh();
        }

        private void chart1_Load(object sender, EventArgs e)
        {

        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
