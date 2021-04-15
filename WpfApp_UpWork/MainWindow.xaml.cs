using System.Collections.Generic;
using System.Windows;
using System.Management;
using System.Linq;
using System.Drawing;
using System.Windows.Media.Imaging;
using System;
using System.Windows.Interop;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;
using System.Windows.Controls;
using System.ComponentModel;

namespace WpfApp_UpWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Model> ProcessList = new();
        public MainWindow()
        {
            InitializeComponent();

            processAdd.Click += ProcessAddAction;
           
        }

        public void OnKill(object sender, RoutedEventArgs e)
        {
            var grid = dataGrid.SelectedItem as Model;

            try
            {
                Process.GetProcessById(Convert.ToInt32(grid.ProcessId)).Kill();
            }
            catch (Win32Exception)
            {
                MessageBox.Show("The process cannot be terminated");
            }
        }

        public void OnPriorityChange(object sender, RoutedEventArgs e)
        {
            var grid = dataGrid.SelectedItem as Model;

            var page = new PrioritySelection(grid.ProcessId);

            page.ShowDialog();
        }

        public void OnAffinityChange(object sender, RoutedEventArgs e)
        {
            var grid = dataGrid.SelectedItem as Model;

            var page = new AffinitySelection(grid.ProcessId);

            page.ShowDialog();
        }

        private void ProcessAddAction(object sender, RoutedEventArgs e)
        {
            Model process = GetMainModule(processInput.Text.ToLower().Trim());
            
            if(process is not null)
            {
                ProcessList.Add(process);

                UpdateGrid();
                processInput.Text = "";
            }
            else
            {
                MessageBox.Show("There is no such a process");
            }
                
        }

        private void UpdateGrid()
        {
            dataGrid.Items.Clear();
            foreach (var item in ProcessList)
            {
                dataGrid.Items.Add(item);
            }
        }
        private Model GetMainModule(string name)
        {
            string wmiQueryString = $"SELECT ProcessId, Name, ExecutablePath  FROM Win32_Process WHERE Name = '{name}'";
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            {
                using (var results = searcher.Get())
                {
                    ManagementObject mo = results.Cast<ManagementObject>().FirstOrDefault();
                    if (mo != null)
                    {
                        return new Model() { 

                            ProcessName= (string)mo["Name"],
                            ProcessId = (uint)mo["ProcessId"],
                            ProcessImagePath = System.Drawing.Icon.ExtractAssociatedIcon((string)mo["ExecutablePath"]).ToBitmap().ToBitmapImage(),
                            ProcessUserName = Process.GetProcessById(Convert.ToInt32((uint)mo["ProcessId"])).ProcessName
                            
                        };
                    }
                }
            }
            return null;
        }

        private class Model
        {
            public uint ProcessId { get; set; }
            public BitmapImage ProcessImagePath { get; set; }
            public string ProcessName { get; set; }
            public string ProcessUserName { get; set; }
        }

    }

}
