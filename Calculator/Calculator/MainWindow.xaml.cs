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

namespace Calculator
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {

    private long num1;
    private long num2;
    private string operation = String.Empty;
 
    public MainWindow()
    {
      InitializeComponent();
    }

    private void btn0_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10);
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10);
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btn1_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 1;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 1;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btn2_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 2;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 2;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btn3_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 3;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 3;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btn4_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 4;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 4;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btn5_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 5;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 5;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btn6_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 6;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 6;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btn7_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 7;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 7;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btn8_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 8;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 8;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btn9_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 9;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 9;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void btnC_Click(object sender, RoutedEventArgs e)
    {
      num1 = 0;
      num2 = 0;
      operation = String.Empty;
      TxtBxResult.Text = num1.ToString();
    }

    private void btnCE_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = 0;

      }
      else
      {
        num2 = 0;
      }
      TxtBxResult.Text = String.Empty;
    }

    private void btnDel_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 / 10);
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 / 10);
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void plsMinBtn_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 *= -1;
        TxtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 *= -1;
        TxtBxResult.Text = num2.ToString();
      }
    }

    private void clcBtn_Click(object sender, RoutedEventArgs e)
    {

    }
  }
}
