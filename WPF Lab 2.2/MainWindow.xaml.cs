 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPF_Lab_2._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Logic
    {
        //начало логики
        //функция удаляет из строк повторяющиеся буквы
        public static string DelDup(string s)
        {
            int check = 0;
            string WithOutDup = string.Empty;
            string temp = string.Empty;
            for (int i = s.Length - 1; -1 < i; i--)
            {
                for (int j = i - 1; -1 < j; j--)
                {
                    if (s[i] == s[j])
                    {
                        check++;
                    }
                }
                if (check == 0)
                {
                    WithOutDup += s[i];
                }
                check = 0;
            }
            for (int g = WithOutDup.Length - 1; -1 < g; g--)
            {
                temp += WithOutDup[g];
            }
            WithOutDup = temp;
            return WithOutDup;
        }
        //функция ищет похожие буквы в 2-х строках введеных пользователем
        public static string FindSimilarLetters(string SecondWord, string FirstWord)
        {
            int Check = 0;
            string ReturnResult = string.Empty;
            for (int i = 0; i < SecondWord.Length; i++)
            {
                for (int j = 0; j < FirstWord.Length; j++)
                {
                    if (FirstWord[j] == SecondWord[i])
                    {
                        ReturnResult += "yes ";
                        Check = 0;
                        break;
                    }
                    else
                    {
                        Check++;
                    }
                }
                if (Check == FirstWord.Length)
                {
                    ReturnResult += "no ";
                }
                Check = 0;
            }
            return ReturnResult;
        }
        //конец логики
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textbox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.Match(e.Text, @"^[a-zа-я]+$", RegexOptions.IgnoreCase).Success)
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AnswerBlock.Text = Logic.FindSimilarLetters(Logic.DelDup(textbox1.Text), Logic.DelDup(textbox2.Text));
        }

        private void textbox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!Regex.Match(e.Text, @"^[a-zа-я]+$", RegexOptions.IgnoreCase).Success)
            {
                e.Handled = true;
            }
        }
    }
    }

