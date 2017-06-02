using DataAnalytics.AnalyticData;
using DataAnalytics.CarControllers;
using DataAnalytics.Controllers;
using DataAnalytics.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalytics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                try
                {
                    List<string> _selector = new List<string>();
                    List<string> AllData;
                    _selector.Add("_gll");
                    _selector.Add("_pac");
                    _selector.Add("_52eh _5bcu");

                    IInput InputData = new InputFileController(i + ".txt");

                    IAnalyticData AnalyticData = new AnalyticsFacebook(ref _selector);
                    IOutput Output = new OutputCsvFileController(i + "output.csv");

                    string tt = InputData.GetSourceStream();
                    AllData = AnalyticData.AnalyticsMethod(tt);
                    Output.OutputFile(ref AllData);
                }
                catch (Exception eee)
                {
                    break;
                }
            }
            MessageBox.Show("OK");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputCarFileController InputCarFile = new InputCarFileController();
            CarAnalytics Analyics = new CarAnalytics();
            OutputCarFileController output = new OutputCarFileController();

            InputCarFile.GetSourceStream();
            List<string> AllFiles = InputCarFile.ReturnFiles();

            List<string> AllData = Analyics.Analyitcs(ref AllFiles);

            output.OutputFile(ref AllData);
        }
    }
}
