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

namespace YearZeroRandomizer.NET6
{
    public partial class MainWindow : Window
    {
        int STAT = 0;
        int SKILL = 0;
        int INSTR = 0;

        Button LastClickedSTAT;
        Button LastClickedSKILL;
        Button LastClickedINSTR;

        SetOfDices StatDices = new(6, 0);
        SetOfDices SkillDices = new(6, 0);
        SetOfDices InstrDices = new(6, 0);

        Dice d2 = new(2);
        Dice d3 = new(3);
        Dice d4 = new(4);
        Dice d6 = new(6);
        Dice d8 = new(8);

        Dice d10 = new(10);
        Dice d12 = new(12);
        Dice d16 = new(16);
        Dice d20 = new(20);
        SetOfDices TWO_d6 = new(6, 2);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void STAT_Click(object sender, RoutedEventArgs e)
        {
            if (LastClickedSTAT != null)
            {
                LastClickedSTAT.Background = Brushes.LightGray;
            }

            Button clickedButton = (Button)sender;
            clickedButton.Background = Brushes.LightGoldenrodYellow;
            LastClickedSTAT = clickedButton;
            if (int.TryParse(clickedButton.Content?.ToString(), out int result))
            {
                STAT = result;
            }
        }

        private void SKILL_Click(object sender, RoutedEventArgs e)
        {
            if (LastClickedSKILL != null)
            {
                LastClickedSKILL.Background = Brushes.LightGray;
            }

            Button clickedButton = (Button)sender;
            clickedButton.Background = Brushes.LightGreen;
            LastClickedSKILL = clickedButton;
            if (int.TryParse(clickedButton.Content?.ToString(), out int result))
            {
                SKILL = result;
            }
        }

        private void INSTR_Click(object sender, RoutedEventArgs e)
        {
            if (LastClickedINSTR != null)
            {
                LastClickedINSTR.Background = Brushes.LightGray;
            }

            Button clickedButton = (Button)sender;
            clickedButton.Background = Brushes.LightSteelBlue;
            LastClickedINSTR = clickedButton;
            if (int.TryParse(clickedButton.Content?.ToString(), out int result))
            {
                INSTR = result;
            }
        }

        private void ROLL_Click(object sender, RoutedEventArgs e)
        {
            StatDices.ChangeNumberOfDices(STAT);
            StatDices.RollAllDices();

            SkillDices.ChangeNumberOfDices(SKILL);
            SkillDices.RollAllDices();

            InstrDices.ChangeNumberOfDices(INSTR);
            InstrDices.RollAllDices();

            Success.Text = $"{StatDices.NumberOf_6 + SkillDices.NumberOf_6 + InstrDices.NumberOf_6}";
            FailuresSTAT.Text = $"{StatDices.NumberOf_1}";
            FailuresINSTR.Text = $"{InstrDices.NumberOf_1}";

            PUSH_BUTTON.IsEnabled = true;
        }

        private void PUSH_Click(object sender, RoutedEventArgs e)
        {
            StatDices.Push(false);

            SkillDices.Push(true);

            InstrDices.Push(false);

            Success.Text = $"{StatDices.NumberOf_6 + SkillDices.NumberOf_6 + InstrDices.NumberOf_6}";
            FailuresSTAT.Text = $"{StatDices.NumberOf_1}";
            FailuresINSTR.Text = $"{InstrDices.NumberOf_1}";

            PUSH_BUTTON.IsEnabled = false;
        }



        private void CLEAR_Click(object sender, RoutedEventArgs e)
        {
            STAT_Clear();
            SKILL_Clear();
            INSTR_Clear();

            Success.Text = "-";
            FailuresSTAT.Text = "-";
            FailuresINSTR.Text = "-";

            PUSH_BUTTON.IsEnabled = false;
        }

        private void STAT_Clear()
        {
            if (LastClickedSTAT != null)
            {
                LastClickedSTAT.Background = Brushes.LightGray;
            }

            STAT = 0;
            StatDices.Clear();
        }

        private void SKILL_Clear()
        {
            if (LastClickedSKILL != null)
            {
                LastClickedSKILL.Background = Brushes.LightGray;
            }

            SKILL = 0;
            SkillDices.Clear();
        }

        private void INSTR_Clear()
        {
            if (LastClickedINSTR != null)
            {
                LastClickedINSTR.Background = Brushes.LightGray;
            }

            INSTR = 0;
            InstrDices.Clear();
        }



        private void D2_Click(object sender, RoutedEventArgs e)
        {
            d2.Roll();
            Button clickedButton = (Button)sender;
            clickedButton.Content = d2.Value;
        }

        private void D3_Click(object sender, RoutedEventArgs e)
        {
            d3.Roll();
            Button clickedButton = (Button)sender;
            clickedButton.Content = d3.Value;
        }

        private void D4_Click(object sender, RoutedEventArgs e)
        {
            d4.Roll();
            Button clickedButton = (Button)sender;
            clickedButton.Content = d4.Value;
        }

        private void D6_Click(object sender, RoutedEventArgs e)
        {
            d6.Roll();
            Button clickedButton = (Button)sender;
            clickedButton.Content = d6.Value;
        }

        private void D8_Click(object sender, RoutedEventArgs e)
        {
            d8.Roll();
            Button clickedButton = (Button)sender;
            clickedButton.Content = d8.Value;
        }

        private void D10_Click(object sender, RoutedEventArgs e)
        {
            d10.Roll();
            Button clickedButton = (Button)sender;
            clickedButton.Content = d10.Value;
        }

        private void D12_Click(object sender, RoutedEventArgs e)
        {
            d12.Roll();
            Button clickedButton = (Button)sender;
            clickedButton.Content = d12.Value;
        }

        private void D16_Click(object sender, RoutedEventArgs e)
        {
            d16.Roll();
            Button clickedButton = (Button)sender;
            clickedButton.Content = d16.Value;
        }

        private void D20_Click(object sender, RoutedEventArgs e)
        {
            d20.Roll();
            Button clickedButton = (Button)sender;
            clickedButton.Content = d20.Value;
        }

        private void TWO_d6_Click(object sender, RoutedEventArgs e)
        {
            TWO_d6.RollAllDices();
            Button clickedButton = (Button)sender;
            clickedButton.Content = $"{TWO_d6.Dices[0].Value}.{TWO_d6.Dices[1].Value}";
        }
    }
}
