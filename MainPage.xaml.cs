using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyFirstGUIApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int res;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            res = a + b;
            textBlockAns.Text = res.ToString();
            RadioButton1.IsChecked = true;
        }

        private void SubButton_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            res = a - b;
            textBlockAns.Text = res.ToString();
            RadioButton1.IsChecked = true;
        }

        private void MulButton_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            res = a * b;
            textBlockAns.Text = res.ToString();
            RadioButton1.IsChecked = true;
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            res = a / b;
            textBlockAns.Text = res.ToString();
            RadioButton1.IsChecked = true;
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton1.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(res, 10);
            }
        }

        private void RadioButton2_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton2.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(res, 2);
            }
        }

        private void RadioButton3_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton3.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(res, 16);
            }
        }

        private void RadioButton4_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton4.IsChecked == true)
            {
                textBlockAns.Text = Convert.ToString(res, 8);
            }
        }
    }
}