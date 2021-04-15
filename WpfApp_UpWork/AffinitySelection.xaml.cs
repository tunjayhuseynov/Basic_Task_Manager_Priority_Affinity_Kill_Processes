using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp_UpWork
{
    /// <summary>
    /// Interaction logic for AffinitySelection.xaml
    /// </summary>
    public partial class AffinitySelection : Window
    {
        public Process process { get; set; }
        public AffinitySelection()
        {
            InitializeComponent();
            GenerateCheckBoxs();
        }

        public AffinitySelection(uint id)
        {
            InitializeComponent();

            process = Process.GetProcessById(Convert.ToInt32(id));

            GenerateCheckBoxs();
        }

        private void GenerateCheckBoxs()
        {
            int numOfCpu = Environment.ProcessorCount;

            int processorAffinity = (int)process.ProcessorAffinity;

            string bits = Convert.ToString(processorAffinity, 2).PadLeft(numOfCpu, '0');

            for (int i = 0; i < numOfCpu; i++)
            {
                CheckBox rb = new CheckBox() { Content = "CPU " + i, IsChecked = bits[^(i+1)] == '1'};
                rb.Checked += OnChecked;
                rb.Unchecked += OnChecked;

                rb.Tag = i;

                CheckBoxGenerator.Children.Add(rb);
            }
        }

        public void OnChecked(object sender, RoutedEventArgs args)
        {
            var list = this.CheckBoxGenerator.Children.OfType<CheckBox>().Where(x => x.IsChecked == true);
         
            string response = "00000000";
            StringBuilder s = new(response);
            foreach (var item in list)
            {
                s[^(int.Parse(item.Tag.ToString()) + 1)] = '1';
            }


            process.ProcessorAffinity = (IntPtr) Convert.ToInt32(s.ToString(), 2);


        }

    }
}
