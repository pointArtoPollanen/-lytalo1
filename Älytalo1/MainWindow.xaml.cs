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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Älytalo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Lights livingRoom = new Lights();
        public Lights kitchen = new Lights();
        public Sauna sauna = new Sauna();
        public Thermostat thermostat = new Thermostat();

        public MainWindow()
        {
            InitializeComponent();

            livingRoom.SetDimmer("0");
            LRDimmerTextBox.IsReadOnly = true;
            LRDimmerTextBox.Text = livingRoom.GetText();

            kitchen.SetDimmer("0");
            KDimmerTextBox.IsReadOnly = true;
            KDimmerTextBox.Text = kitchen.GetText();

            sauna.SetOff();
            SaunaTextBox.IsReadOnly = true;
            SaunaTextBox.Text = sauna.GetText();

            thermostat.SetTemperature(21);
            CurTempTextBox.IsReadOnly = true;
            CurTempTextBox.Text = thermostat.GetTemperature().ToString();
            TargetTempTextBox.Text = "";
        }

        ///////////////

        private void LRButton0_Click(object sender, RoutedEventArgs e)
        {
            livingRoom.SetDimmer("0");
            LRDimmerTextBox.Text = livingRoom.GetText();
        }

        private void LRButton33_Click(object sender, RoutedEventArgs e)
        {
            livingRoom.SetDimmer("33");
            LRDimmerTextBox.Text = livingRoom.GetText();
        }

        private void LRButton66_Click(object sender, RoutedEventArgs e)
        {
            livingRoom.SetDimmer("66");
            LRDimmerTextBox.Text = livingRoom.GetText();
        }

        private void LRButton100_Click(object sender, RoutedEventArgs e)
        {
            livingRoom.SetDimmer("100");
            LRDimmerTextBox.Text = livingRoom.GetText();
        }

        ///////////////

        private void KButton0_Click(object sender, RoutedEventArgs e)
        {
            kitchen.SetDimmer("0");
            KDimmerTextBox.Text = kitchen.GetText();
        }

        private void KButton33_Click(object sender, RoutedEventArgs e)
        {
            kitchen.SetDimmer("33");
            KDimmerTextBox.Text = kitchen.GetText();
        }

        private void KButton66_Click(object sender, RoutedEventArgs e)
        {
            kitchen.SetDimmer("66");
            KDimmerTextBox.Text = kitchen.GetText();
        }

        private void KButton100_Click(object sender, RoutedEventArgs e)
        {
            kitchen.SetDimmer("100");
            KDimmerTextBox.Text = kitchen.GetText();
        }

        ///////////////

        private void SaunaOnButton_Click(object sender, RoutedEventArgs e)
        {
            sauna.SetOn();
            SaunaTextBox.Text = sauna.GetText();
        }

        private void SaunaOffButton_Click(object sender, RoutedEventArgs e)
        {
            sauna.SetOff();
            SaunaTextBox.Text = sauna.GetText();
        }

        ///////////////

        private void SetTempButton_Click(object sender, RoutedEventArgs e)
        {
            thermostat.SetTemperature(Int32.Parse(TargetTempTextBox.Text));
            CurTempTextBox.Text = thermostat.GetTemperature().ToString();
            TargetTempTextBox.Text = "";
        }
    }
}
