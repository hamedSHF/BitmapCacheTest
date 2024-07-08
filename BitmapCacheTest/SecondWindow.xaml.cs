using BitmapCacheTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BitmapCacheTest
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        Random random = new Random();
        public SecondWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<SampleMetric> metrics = new List<SampleMetric>();
            for (int j = 0; j < 1000; j++)
            {
                SampleMetric metric = new SampleMetric();
                metric.Name = "Test" + random.Next();
                metric.AdditionalData = "Additional data";
                for (int i = 0; i < 240; i++)
                {
                    metric.Points.Add(new DataPoint { Time = random.NextDouble() * 40, Value = random.NextDouble() });
                }
                metrics.Add(metric);
                MyList.Items.Add(metric);
            }
        }
    }
}
