using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp_UpWork
{
    /// <summary>
    /// Interaction logic for PrioritySelectionPage.xaml
    /// </summary>
    public partial class PrioritySelection : Window
    {
        public Process process { get; set; }
        public PrioritySelection()
        {
            InitializeComponent();
        }
        public PrioritySelection(uint id)
        {
            InitializeComponent();

            process = Process.GetProcessById(Convert.ToInt32(id));



            switch (process.PriorityClass)
            {
                case ProcessPriorityClass.BelowNormal:
                    bnormal.IsChecked = true;
                    break;

                case ProcessPriorityClass.Normal:
                    normal.IsChecked = true;
                    break;

                case ProcessPriorityClass.AboveNormal:
                    anormal.IsChecked = true;
                    break;

                case ProcessPriorityClass.High:
                    high.IsChecked = true;
                    break;

                case ProcessPriorityClass.RealTime:
                    rt.IsChecked = true;
                    break;
            };
        }

        public void OnChecked(object sender, RoutedEventArgs e)
        {
            var btn = sender as RadioButton;

            if(btn.IsChecked == true)
            {
                switch ((ProcessPriorityClass)Convert.ToInt32(btn.Tag))
                {
                    case ProcessPriorityClass.BelowNormal:
                        process.PriorityClass = ProcessPriorityClass.BelowNormal;
                        break;

                    case ProcessPriorityClass.Normal:
                        process.PriorityClass = ProcessPriorityClass.Normal;
                        break;

                    case ProcessPriorityClass.AboveNormal:
                        process.PriorityClass = ProcessPriorityClass.AboveNormal;
                        break;

                    case ProcessPriorityClass.High:
                        process.PriorityClass = ProcessPriorityClass.High;
                        break;

                    case ProcessPriorityClass.RealTime:
                        process.PriorityClass = ProcessPriorityClass.RealTime;
                        break;
                };
            }
        }
    }
}
