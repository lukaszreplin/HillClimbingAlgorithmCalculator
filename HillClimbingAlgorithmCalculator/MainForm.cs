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

namespace HillClimbingAlgorithmCalculator
{
    public partial class MainForm : Form
    {
        private Parameters _parameters;

        public MainForm()
        {
            InitializeComponent();
            fromTb.Text = "-4";
            toTb.Text = "12";
            tTb.Text = "50";
            precisionCb.Items.AddRange(new string[] { "0,001", "0,01", "0,1" });
            precisionCb.SelectedIndex = 0;
            _parameters = new Parameters();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            if (!AssignParameters())
            {
                MessageBox.Show("Invalid parameters format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Algorithm algorithm = new Algorithm(_parameters);
            await Task.Run(() => 
            {
                algorithm.Start();
            });
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
