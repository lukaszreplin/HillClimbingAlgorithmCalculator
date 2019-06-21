using HillClimbingAlgorithmCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HillClimbingAlgorithmCalculator
{
    public partial class MainForm : Form
    {
        private Parameters _parameters;
        private Results _results = new Results();

        public MainForm()
        {
            InitializeComponent();
            fromTb.Text = "-4";
            toTb.Text = "12";
            tTb.Text = "50";
            precisionCb.Items.AddRange(new string[] { "0,001", "0,01", "0,1" });
            precisionCb.SelectedIndex = 0;
            _parameters = new Parameters();
            resChart.ChartAreas[0].AxisX.Interval = 1;
            resChart.ChartAreas[0].AxisX.IntervalOffset = 0;
            var ser = new Series();
            ser.Name = "Best";
            ser.ChartType = SeriesChartType.Line;
            resChart.Series.Add(ser);
            resChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            if (!AssignParameters())
            {
                MessageBox.Show("Invalid parameters format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Algorithm algorithm = new Algorithm(_parameters);
            Cursor = Cursors.WaitCursor;
            await Task.Run(() => 
            {
                _results = algorithm.Start();
            });
            resFXTb.Text = _results.FXBest.ToString();
            resXBinTb.Text = _results.XBinBest;
            resXRealTb.Text = _results.XRealBest.ToString();
            Cursor = Cursors.Arrow;
            foreach (var sss in resChart.Series)
            {
                sss.Points.Clear();
            }
            resChart.Series[0].ChartType = SeriesChartType.Point;
            resChart.Series[0].Name = "Results";
            for (int i = 0; i < _results.Bests.Count; i++)
            {
                resChart.Series["Best"].Points.AddXY(i, _results.Bests[i]);
                var resval = _results.ResValues[i];
                int count = 1;
                foreach (var elem in resval)
                {
                    double xVal = i + (1.0 / resval.Count) * count;
                    resChart.Series["Results"].Points.AddXY(xVal, elem);
                    count++;
                }
            }
        }

        private bool AssignParameters()
        {
            try
            {
                _parameters.From = float.Parse(fromTb.Text);
                _parameters.To = float.Parse(toTb.Text);
                _parameters.T = int.Parse(tTb.Text);
                _parameters.Precision = double.Parse(precisionCb.SelectedItem.ToString());
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
