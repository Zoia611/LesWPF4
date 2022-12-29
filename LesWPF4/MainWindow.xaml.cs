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

namespace LesWPF4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            ressum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double wellEuro = Convert.ToDouble(well.Text);
            double SumEuro = Convert.ToDouble(Sum.Text);
            double resDouble = wellEuro * SumEuro;
            wellSum.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double welEuro = Convert.ToDouble(wel.Text);
            double SUMEuro = Convert.ToDouble(SUM.Text);
            double resDouble = welEuro * SUMEuro;
            welSUM.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double wellsEuro = Convert.ToDouble(wells.Text);
            double suMEuro = Convert.ToDouble(suM.Text);
            double resDouble = wellsEuro * suMEuro;
            wellssuM.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double transInches = Convert.ToDouble(trans.Text);
            double resDouble = transInches/2.54;
            result.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double tranFut = Convert.ToDouble(tran.Text);
            double resDouble = tranFut/3.281;
            resul.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double trMili = Convert.ToDouble(tr.Text);
            double resDouble = trMili*1609;
            res.Text = resDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double trsVerst = Convert.ToDouble(trs.Text);
            double resDouble = trsVerst * 1067;
            rest.Text = resDouble.ToString();
        }
    }
}
