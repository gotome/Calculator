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
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10);
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btn1_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 1;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 1;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btn2_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 2;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 2;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btn3_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 3;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 3;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btn4_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 4;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 4;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btn5_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 5;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 5;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btn6_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 6;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 6;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btn7_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 7;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 7;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btn8_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 8;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 8;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btn9_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 * 10) + 9;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 * 10) + 9;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btnC_Click(object sender, RoutedEventArgs e)
    {
      num1 = 0;
      num2 = 0;
      operation = String.Empty;
      txtBxResult.Text = num1.ToString();
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
      txtBxResult.Text = 0.ToString();
    }

    private void btnDel_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 = (num1 / 10);
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 = (num2 / 10);
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btnPlsMin_Click(object sender, RoutedEventArgs e)
    {
      if (String.IsNullOrEmpty(operation))
      {
        num1 *= -1;
        txtBxResult.Text = num1.ToString();
      }
      else
      {
        num2 *= -1;
        txtBxResult.Text = num2.ToString();
      }
    }

    private void btnClc_Click(object sender, RoutedEventArgs e)
    {
      switch (operation)
      {
        case "/":
          num1 /= num2; 
          txtBxResult.Text = num1.ToString();
          break;
        case "*":
          num1 *= num2;
          txtBxResult.Text = num1.ToString();
          break;
        case "-":
          num1 -= num2;
          txtBxResult.Text = num1.ToString();
          break;
        case "+":
          num1 += num2;
          txtBxResult.Text = num1.ToString();
          break;
        default:
          break;
      }
    }

    private void btnDiv_Click(object sender, RoutedEventArgs e)
    {
      operation = "/";
      num2 = 0; 
      txtBxResult.Text = 0.ToString();
    }

    private void btnMul_Click(object sender, RoutedEventArgs e)
    {
      operation = "*";
      num2 = 0;
      txtBxResult.Text = 0.ToString();
    }

    private void btnMin_Click(object sender, RoutedEventArgs e)
    {
      operation = "-";
      num2 = 0;
      txtBxResult.Text = 0.ToString();
    }

    private void btnPls_Click(object sender, RoutedEventArgs e)
    {
      operation = "+";
      num2 = 0;
      txtBxResult.Text = 0.ToString();
    }
  }
}
