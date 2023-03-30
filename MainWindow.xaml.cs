using MaketVarBibliarry1;
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


namespace MaketVar1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string GenderChoise;
        string PayMentChoise;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FullNameTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (FullNameTb.Text == "Full Name")
            {
                FullNameTb.Text = "";
            }
        }

        private void FullNameTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (FullNameTb.Text == "")
            {
                FullNameTb.Text = "Full Name";
            }
        }

        private void EmailTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailTb.Text == "Email")
            {
                EmailTb.Text = "";
            }
        }

        private void EmailTb_LostFocus(object sender, RoutedEventArgs e)
        {

            if (EmailTb.Text == "" )
            {
                EmailTb.Text = "Email";
            }
        }

        private void PasswordTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Text == "Password")
            {
                PasswordTb.Text = "";
            }
        }

        private void PasswordTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordTb.Text == "")
            {
                PasswordTb.Text = "Password";
            }
        }

        private void DaysTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (DaysTb.Text == "DD")
            {
                DaysTb.Text = "";
            }
        }

        private void DaysTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (DaysTb.Text == "")
            {
                DaysTb.Text = "DD";
            }
        }

        private void MonthTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MonthTb.Text == "MM")
            {
                MonthTb.Text = "";
            }
        }

        private void MonthTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (MonthTb.Text == "")
            {
                MonthTb.Text = "MM";
            }
        }

        private void YearTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (YearTb.Text == "YYYY")
            {
                YearTb.Text = "";
            }
        }

        private void YearTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (YearTb.Text == "")
            {
                YearTb.Text = "YYYY";
            }
        }

        private void MaleChoise_Click(object sender, RoutedEventArgs e)
        {
            GenderChoise = "male";
            MaleChoise.Background = Brushes.Orange;
            MaleChoise.Foreground = Brushes.White;
            FemaleChoise.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            FemaleChoise.Foreground = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        }

        private void FemaleChoise_Click(object sender, RoutedEventArgs e)
        {
            GenderChoise = "female";

            FemaleChoise.Background = Brushes.Orange;
            FemaleChoise.Foreground = Brushes.White;
            MaleChoise.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            MaleChoise.Foreground = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        }

        private void CreditCardBtn_Click(object sender, RoutedEventArgs e)
        {
            PayMentChoise = "CreditCard";

            CreditCardBtn.Background = Brushes.Orange;
            CreditCardBtn.Foreground = Brushes.White;
            PayPalbtn.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            PayPalbtn.Foreground = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        }

        private void PayPalbtn_Click(object sender, RoutedEventArgs e)
        {
            PayMentChoise = "Paypal";

            PayPalbtn.Background = Brushes.Orange;
            PayPalbtn.Foreground = Brushes.White;
            CreditCardBtn.Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));
            CreditCardBtn.Foreground = new SolidColorBrush(Color.FromRgb(160, 160, 160));
        }
        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            Check check = new Check();
            string name = FullNameTb.Text;
            string mail = EmailTb.Text;
            string password = PasswordTb.Text;
            string dd = DaysTb.Text;
            string month = MonthTb.Text;
            string year = YearTb.Text;
            string cardnum = CardNumTb.Text;
            string cardCVC = CardCVCTb.Text;
            string genderChoise = GenderChoise;
            string paymentChoise = PayMentChoise;
            string dayEnd = DateEndCmb.Text;
            string yearEnd = YearEndCmb.Text;



            if ( check.YearEnd(yearEnd) && check.DateEnd(dayEnd) && check.GenderChoise(genderChoise) && check.PaymentType(paymentChoise) && check.FullName(name) && check.Email(mail) && check.Password(password) && check.Days(dd) && check.Monts(month) && check.YearBirdth(year) && check.CardNumbers(cardnum) && check.CVC(cardCVC))
            {
                MessageBox.Show("Ваша форма заполнена верно, данные отправлены на сервер!");
            }
            else
            {
                MessageBox.Show("Ввели данные не коректно, пожалуйста попробуйте снова!");
                //FullNameTb.Clear();
                //EmailTb.Clear();
                //PasswordTb.Clear();
                //DaysTb.Clear();
                //MonthTb.Clear();
                //YearTb.Clear();
                //CardNumTb.Clear();
                //CardCVCTb.Clear();
            }
        }

        private void CardNumTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CardNumTb.Text == "")
            {
                CardNumTb.Text = "Card Number";
            }
        }

        private void CardNumTb_GotFocus(object sender, RoutedEventArgs e)
        {

            if (CardNumTb.Text == "Card Number")
            {
                CardNumTb.Text = "";
            }
        }

        private void CardCVCTb_LostFocus(object sender, RoutedEventArgs e)
        {

            if (CardCVCTb.Text == "")
            {
                CardCVCTb.Text = "Card CVC";
            }
        }

        private void CardCVCTb_GotFocus(object sender, RoutedEventArgs e)
        {

            if (CardCVCTb.Text == "Card CVC")
            {
                CardCVCTb.Text = "";
            }
        }

        private void AccessCB_Checked(object sender, RoutedEventArgs e)
        {
            ConfirmBtn.Visibility = Visibility.Visible;
        }

        private void AccessCB_Unchecked(object sender, RoutedEventArgs e)
        {
            ConfirmBtn.Visibility = Visibility.Hidden;
        }
    }
}
