using Ch_13_TipCalc.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ch_13_TipCalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void CalculateTip(object sender, RoutedEventArgs e)
        {
            int bill, diners;
            if (Int32.TryParse(textBox_Bill.Text, out bill) && Int32.TryParse(textBox_Diners.Text, out diners))
            {
                var selectedTip = comboBox_Tips.SelectedItem as Tip;

                var tip = selectedTip.IsFixedTip ? selectedTip.FixedAmount : selectedTip.Percentage * bill;
                var totalAmount = bill + tip;

                text_totalBill.Text = bill.ToString();
                text_totalTip.Text = tip.ToString();
                text_totalAmount.Text = totalAmount.ToString();
            }
            else
            {
                var dialog = new MessageDialog("Wrong Input in some textBox ...");
                await dialog.ShowAsync();
            }
        }

        private void Page_Loading(FrameworkElement sender, object args)
        {
            DataContext = new Models.TipsViewModel();
        }
    }
}
