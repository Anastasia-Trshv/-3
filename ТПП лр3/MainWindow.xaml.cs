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
using static System.Net.Mime.MediaTypeNames;

namespace ТПП_лр2
{


    public partial class MainWindow : Window
    {
        float a, b;
        int count, itemnum;
        string his;

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            checkbx.Visibility = Visibility.Hidden;
            historylist.Visibility = Visibility.Hidden;
            clnhtr.Visibility = Visibility.Hidden;
            clnhtr_Copy.Visibility = Visibility.Hidden;
        }

        //NuMbErS^^------------------------------------------------------------------
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 7;
            his += "7";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 8;
            his += "8";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 9;
            his += "9";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 4;
            his += "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 5;
            his += "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 6;
            his += "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 1;
            his += "1";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 2;
            his += "2";

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 3;
            his += "3";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textbl.Text = textbl.Text + 0;
            his += "0";
        }

        //--------------------------------------------------------------------------

        //BuTtOnS^^--------------------------------------------------------------
        private void Button_Click(object sender, RoutedEventArgs e) //stirka
        {
            textbl.Text = "";
            textbl2.Text = "";
            his ="";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (textbl.Text == "-" || textbl.Text == "+" || textbl.Text == "*" || textbl.Text == "/")
            {
                textbl.Text = "";
                textbl2.Text = "";
                a = 0;
            }
            if (textbl.Text == "")
            {
                a = 0;
                textbl2.Text = a.ToString() + "+";
                count = 1;
            }
            else
            {
                a = float.Parse(textbl.Text);
                textbl.Text = "";
                textbl2.Text = a.ToString() + "+";
                count = 1;
                his += "+";
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            if (textbl.Text == "-" || textbl.Text == "+" || textbl.Text == "*" || textbl.Text == "/")
            {
                textbl.Text = "";
                textbl2.Text = "";
            }
            if (textbl.Text == "")
            {
                textbl.Text = "-";
                his += "-";
            }

            else
            {
                a = float.Parse(textbl.Text);
                textbl.Text = "";
                textbl2.Text = a.ToString() + "-";
                count = 2;
                his += "-";
            }

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (textbl.Text == "-" || textbl.Text == "+" || textbl.Text == "*" || textbl.Text == "/")
            {
                textbl.Text = "";
                textbl2.Text = "";
            }
            if (textbl.Text == "")
            {
                a = 0;
                textbl2.Text = a.ToString() + "*";
                count = 3;
            }
            else
            {
                a = float.Parse(textbl.Text);
                textbl.Text = "";
                textbl2.Text = a.ToString() + "*";
                count = 3;
                his += "*";
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (textbl.Text == "-" || textbl.Text == "+" || textbl.Text == "*" || textbl.Text == "/")
            {
                textbl.Text = "";
                textbl2.Text = "";
            }
            if (textbl.Text == "")
            {
                a = 0;
                textbl2.Text = a.ToString() + "/";
                count = 4;
            }
            else
            {
                a = float.Parse(textbl.Text);
                textbl.Text = "";
                textbl2.Text = a.ToString() + "/";
                count = 4;
                his += "/";
            }
        }
        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            calculate();
            textbl.Text = "";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
           
            historylist.Visibility = Visibility.Visible;
            checkbx.Visibility = Visibility.Visible;
            clnhtr.Visibility = Visibility.Visible;
            clnhtr_Copy.Visibility = Visibility.Visible;

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

            checkbx.Visibility = Visibility.Hidden;
            historylist.Visibility = Visibility.Hidden;
            clnhtr.Visibility = Visibility.Hidden;
            clnhtr_Copy.Visibility = Visibility.Hidden;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           
        }



       

        private void CheckBox_unChecked (object sender, RoutedEventArgs e)
        {
            his = "";
        }

        private void history_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
           historylist.Items.Clear();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            itemnum = historylist.Items.Count;
            historylist.Items.Remove(historylist.Items[itemnum-1]);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void calculate()
        {

            switch (count)
            {
                case 1:
                    {


                        if (string.IsNullOrWhiteSpace(textbl.Text))
                        {
                            textbl2.Text = "Need 2nd nmbr";
                            his = "";
                            break;
                        }
                        else
                        {
                            b = a + float.Parse(textbl.Text);
                            textbl2.Text = b.ToString();
                           if (checkbx.IsChecked==true)
                            {
                            his += "="+b.ToString();
                               
                                historylist.Items.Add(his);
                                his = "";
                            }
                            


                            break;
                        }

                    }
                case 2:
                    {

                        if (string.IsNullOrWhiteSpace(textbl.Text))
                        {
                            textbl2.Text = "Need 2nd nmbr";
                            his = "";
                            break;
                        }
                        else
                        {
                            b = a - float.Parse(textbl.Text);
                            textbl2.Text = b.ToString();
                            if (checkbx.IsChecked == true)
                            {
                                his += "=" + b.ToString();
                                historylist.Items.Add(his);
                                his = "";
                            }
                            break;
                        }
                    }
                case 3:
                    {

                        if (string.IsNullOrWhiteSpace(textbl.Text))
                        {
                            textbl2.Text = "Need 2nd nmbr";
                            his = "";
                            break;
                        }
                        else
                        {
                            b = a * float.Parse(textbl.Text);
                            textbl2.Text = b.ToString();
                            if (checkbx.IsChecked == true)
                            {
                                his += "=" + b.ToString();
                                historylist.Items.Add(his);
                                his = "";
                            }
                            break;
                        }
                    }
                case 4:
                    {

                        if (string.IsNullOrWhiteSpace(textbl.Text))
                        {
                            textbl2.Text = "Need 2nd nmbr";
                            his = "";
                            break;
                        }
                        if (float.Parse(textbl.Text) == 0)
                        {
                            textbl2.Text = "NO!!! >:(";
                            his = "";
                            break;
                        }
                        else
                        {
                            b = a / float.Parse(textbl.Text);
                            textbl2.Text = b.ToString();
                            if (checkbx.IsChecked == true)
                            {
                                his += "=" + b.ToString();
                                historylist.Items.Add(his);
                                his = "";
                            }
                            break;
                        }
                    }


                default:
                    break;
            }




        }
    }
}
