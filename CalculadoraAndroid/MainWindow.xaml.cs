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
using CalculadoraAndroid.Helpers;
using CalculadoraAndroid.MathLibrary;

namespace CalculadoraAndroid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Double Value1;
        Double Value2;
        Double OperationResult;
        String Operator;
        Double Zero = 0;
        List<HistoryStruct> Historial = new List<HistoryStruct>();

        /// <summary>
        ///Proof if the operation is valid
        /// </summary>

        Double Test;

        /// <summary>
        /// Cleans the OperationView if the usser doesn't clean it
        /// </summary>

        Boolean OperationTest = true;

        /// <summary>
        /// Invalids operations
        /// </summary>

        Boolean Enter = true;
        public MainWindow()
        {
            InitializeComponent();
            HistorialList.ItemsSource = Historial;
        }

        /// <summary>
        /// /// Scientific Operation Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// Sinus Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SinButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);
                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "Sin";
                    Value1 = double.Parse(TextBox.Text);
                    TextBox.Text = "0";
                    OperationView.Text = "Sin(" + Value1 + ")";
                }
            }
        }
        /// <summary>
        /// Cosinu Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CosButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "Cos";
                    Value1 = double.Parse(TextBox.Text);
                    TextBox.Text = "0";
                    OperationView.Text = "Cos" + "(" + Value1 + ")";
                }
            }
        }
        /// <summary>
        /// Tangent Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TanButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "Tan";
                    Value1 = double.Parse(TextBox.Text);
                    TextBox.Text = "0";
                    OperationView.Text = "Tan" + "(" + Value1 + ")";
                }
            }
        }
        /// <summary>
        /// Percentage Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PerButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "%";
                    Value1 = double.Parse(TextBox.Text);
                    TextBox.Text = TextBox.Text + "%";
                }
            }
        }
        /// <summary>
        /// Logarithm Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "Log";
                    Value1 = double.Parse(TextBox.Text);
                }
            }
        }
        /// <summary>
        /// Square Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaizButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "Sqr";
                    Value1 = double.Parse(TextBox.Text);
                    OperationView.Text = "√" + Value1;
                    TextBox.Text = "0";
                }
            }
        }
        /// <summary>
        /// Ten Potency Operation Button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button10x_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "10x";
                    Value1 = double.Parse(TextBox.Text);
                    OperationView.Text = "10" + "^" + Value1;
                    OperationTest = false;
                    OperationResult = BasicOperations.Pot10xOperation(Value1);
                    TextBox.Text = OperationResult.ToString();
                    Historial.Add(new HistoryStruct(Value1.ToString(), Value2.ToString("10"), Operator = "^", OperationResult.ToString()));
                }
            }
        }
        /// <summary>
        /// Basic Potency Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PotButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "^";
                    Value1 = double.Parse(TextBox.Text);
                    OperationView.Text = Value1 + "^";
                    TextBox.Text = "";
                }
            }
        }
        /// <summary>
        /// PI Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PiButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + Math.PI;
        }
        /// <summary>
        /// Factor Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "!";
                    Value1 = double.Parse(TextBox.Text);
                    TextBox.Text = TextBox.Text + "!";
                }
            }
        }
        ///<summary>
        /// Number buttons
        ///</summary>

        /// <summary>
        /// Number One Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + "1";
        }
        /// <summary>
        /// Number Two Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + "2";
        }
        /// <summary>
        /// Number Three Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + "3";
        }
        /// <summary>
        /// Number Four Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + "4";
        }
        /// <summary>
        /// Number Five Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + "5";
        }
        /// <summary>
        /// Number Six Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + "6";
        }
        /// <summary>
        /// Number Seven Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + "7";
        }
        /// <summary>
        /// Number Eight Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + "8";
        }
        /// <summary>
        /// Number Nine Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            Enter = false;
            TextBox.Text = TextBox.Text + "9";
        }
        /// <summary>
        /// Number Zero Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            else
            {
                if (TextBox.Text == Zero.ToString())
                {
                    Enter = true;
                }
                else
                {
                    Enter = false;
                }
            }
            TextBox.Text = TextBox.Text + "0";
        }
        /// <summary>
        /// Number ZeroZeroZero Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZerozeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (Enter == true)
            {
                TextBox.Text = "";
                OperationView.Text = "";
            }
            else
            {
                if (TextBox.Text == Zero.ToString())
                {
                    Enter = true;
                }
                else
                {
                    Enter = false;
                }
            }
            TextBox.Text = TextBox.Text + "000";
        }

        ///<summary>
        /// Simple buttons
        ///</summary>

        /// <summary>
        /// BackSpace Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackSpaceButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
            }
            if (TextBox.Text.Length == 0)
            {
                TextBox.Text = "0";
                OperationView.Text = "";
                Enter = true;
            }
        }
        /// <summary>
        /// Clear Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                TextBox.Text = "0";
                OperationView.Text = "";
                Enter = true;
            }
            else
            {
                if (TextBox.Text.Length == 0)
                {
                    TextBox.Text = "0";
                    OperationView.Text = "";
                    Enter = true;
                }
            }
        }
        /// <summary>
        /// Decimal Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Value1 = double.Parse(TextBox.Text);
                if (Value1 > 0)
                {
                    TextBox.Text = TextBox.Text + ",";
                }
                else
                {
                    TextBox.Text = "0,";
                }
            }
            catch
            {
                TextBox.Text = "An error ocurred";
            }
        }
        /// <summary>
        /// Operation Signal Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreButton_Click(object sender, RoutedEventArgs e)
        {
            Double number;
            Double negative = -1;
            bool equaltest = double.TryParse(TextBox.Text, out Test);
            if (!equaltest)
            {
                TextBox.Text = "Invalid argument.";
            }
            else
            {
                if (TextBox.Text == Zero.ToString())
                {
                    TextBox.Text = "-1";
                }
                else
                {
                    if (TextBox.Text.Length == 0)
                    {
                        Enter = false;
                    }
                    else
                    {
                        number = double.Parse(TextBox.Text);
                        TextBox.Text = (number * negative).ToString();
                    }
                }
            }
        }

        ///<summary>
        ///Simple Operation Buttons
        /// </summary>

        /// <summary>
        /// Plus Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "+";
                    Value1 = double.Parse(TextBox.Text);
                    TextBox.Text = "";
                    OperationView.Text = Value1 + "+";
                }
            }
        }
        /// <summary>
        /// Less Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LessButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "-";
                    Value1 = double.Parse(TextBox.Text);
                    TextBox.Text = "";
                    OperationView.Text = Value1 + "-";
                }
            }
        }
        /// <summary>
        /// Multiplication Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "*";
                    Value1 = double.Parse(TextBox.Text);
                    TextBox.Text = "";
                    OperationView.Text = Value1 + "*";
                }
            }
        }
        /// <summary>
        /// Divition Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                if (OperationTest == false)
                {
                    OperationView.Text = "";
                }
                OperationTest = true;
                bool equaltest = double.TryParse(TextBox.Text, out Test);

                if (!equaltest)
                {
                    TextBox.Text = "Invalid argument.";
                }
                else
                {
                    Operator = "/";
                    Value1 = double.Parse(TextBox.Text);
                    TextBox.Text = "";
                    OperationView.Text = Value1 + "/";
                }
            }
        }
        /// <summary>
        /// Equal Operation Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length == 0)
            {
                Enter = false;
            }
            else
            {
                switch (Operator)
                {
                    case "+":
                        {
                            Value2 = double.Parse(TextBox.Text);
                            bool plusTest = double.TryParse(TextBox.Text, out Test);
                            if (!plusTest)
                            {
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                OperationView.Text = OperationView.Text + Value2;
                                OperationTest = false;
                                OperationResult = BasicOperations.AdditionOperation(Value1, Value2);
                                TextBox.Text = OperationResult.ToString();
                                Historial.Add(new HistoryStruct(Value1.ToString(), Value2.ToString(), Operator, OperationResult.ToString()));
                            }
                            break;
                        }

                    case "-":
                        {
                            Value2 = double.Parse(TextBox.Text);
                            bool lessTest = double.TryParse(TextBox.Text, out Test);
                            if (!lessTest)
                            {
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                OperationView.Text = OperationView.Text + Value2;
                                OperationTest = false;
                                OperationResult = BasicOperations.RestOperation(Value1, Value2);
                                TextBox.Text = OperationResult.ToString();
                                Historial.Add(new HistoryStruct(Value1.ToString(), Value2.ToString(), Operator, OperationResult.ToString()));
                            }
                            break;
                        }

                    case "*":
                        {
                            Value2 = double.Parse(TextBox.Text);
                            bool xTest = double.TryParse(TextBox.Text, out Test);

                            if (!xTest)
                            {
                                OperationView.Text = OperationView.Text + Value2;
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                OperationView.Text = OperationView.Text + Value2;
                                OperationTest = false;
                                OperationResult = BasicOperations.MultiplicationOperation(Value1, Value2);
                                TextBox.Text = OperationResult.ToString();
                                Historial.Add(new HistoryStruct(Value1.ToString(), Value2.ToString(), Operator, OperationResult.ToString()));
                            }
                            break;
                        }

                    case "/":
                        {
                            Value2 = double.Parse(TextBox.Text);
                            bool divideTest = double.TryParse(TextBox.Text, out Test);
                            if (!divideTest)
                            {
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                if (Value2 == 0)
                                {
                                    TextBox.Text = "Cannot be divided by 0.";
                                }
                                else
                                {
                                    OperationView.Text = OperationView.Text + Value2;
                                    OperationTest = false;
                                    OperationResult = BasicOperations.DivitionOperation(Value1, Value2);
                                    TextBox.Text = OperationResult.ToString();
                                    Historial.Add(new HistoryStruct(Value1.ToString(), Value2.ToString(), Operator, OperationResult.ToString()));
                                }
                            }
                            break;
                        }

                    case "^":
                        {
                            Value2 = double.Parse(TextBox.Text);
                            bool PotTest = double.TryParse(TextBox.Text, out Test);
                            if (!PotTest)
                            {
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                OperationView.Text = OperationView.Text + Value2;
                                OperationTest = false;
                                OperationResult = BasicOperations.PotencyOperation(Value1, Value2);
                                TextBox.Text = OperationResult.ToString();
                                Historial.Add(new HistoryStruct(Value1.ToString(), Value2.ToString(), Operator, OperationResult.ToString()));
                            }
                            break;
                        }

                    case "%":
                        {
                            if (TextBox.Text.Contains("%"))
                            {
                                TextBox.Text = TextBox.Text.Substring(TextBox.Text.IndexOf('%') + 1);
                                bool perTest = double.TryParse(TextBox.Text, out Test);

                                if (!perTest)
                                {
                                    Value2 = 100;
                                    OperationView.Text = "(" + Value1 + "*" + Value2 + ")" + "/" + "100";
                                    OperationTest = false;
                                    OperationResult = Value1;
                                    TextBox.Text = OperationResult.ToString();
                                    Historial.Add(new HistoryStruct("(" + Value1, "/" + "100", "*" + Value2 + ")", OperationResult.ToString()));
                                }
                                else
                                {
                                    Value2 = double.Parse(TextBox.Text);
                                    OperationView.Text = "(" + Value1 + "*" + Value2 + ")" + "/" + "100";
                                    OperationTest = false;
                                    OperationResult = BasicOperations.PercentageOperation(Value1, Value2);
                                    TextBox.Text = OperationResult.ToString();
                                    Historial.Add(new HistoryStruct("(" + Value1, "/" + "100", "*" + Value2 + ")", OperationResult.ToString()));
                                }
                            }
                            break;
                        }

                    case "Sin":
                        {
                            bool SinTest = double.TryParse(TextBox.Text, out Test);
                            if (!SinTest)
                            {
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                OperationTest = false;
                                OperationResult = BasicOperations.SinOperation(Value1);
                                TextBox.Text = OperationResult.ToString();
                                Historial.Add(new HistoryStruct("Sin(", ")", Value1.ToString(), OperationResult.ToString()));
                            }
                            break;
                        }

                    case "Cos":
                        {
                            bool CosTest = double.TryParse(TextBox.Text, out Test);
                            if (!CosTest)
                            {
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                OperationTest = false;
                                OperationResult = BasicOperations.CosOperation(Value1);
                                TextBox.Text = OperationResult.ToString();
                                Historial.Add(new HistoryStruct("Cos(", ")", Value1.ToString(), OperationResult.ToString()));
                            }
                            break;
                        }

                    case "Tan":
                        {
                            bool TanTest = double.TryParse(TextBox.Text, out Test);
                            if (!TanTest)
                            {
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                OperationTest = false;
                                OperationResult = BasicOperations.TanOperation(Value1);
                                TextBox.Text = OperationResult.ToString();
                                Historial.Add(new HistoryStruct("Tan(", ")", Value1.ToString(), OperationResult.ToString()));
                            }
                            break;
                        }

                    case "Sqr":
                        {
                            OperationTest = false;
                            OperationResult = BasicOperations.SqrOperation(Value1);
                            TextBox.Text = OperationResult.ToString();
                            Historial.Add(new HistoryStruct("√", "", Value1.ToString(), OperationResult.ToString()));

                            break;
                        }

                    case "!":
                        {
                            if (TextBox.Text.Contains("!"))
                            {
                                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
                            }

                            bool factTest = double.TryParse(TextBox.Text, out Test);
                            if (!factTest)
                            {
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                // Test for invalid input.
                                if ((Value1 < 0) || (Value1 > 20))
                                {
                                    TextBox.Text = "Input must be 0 < x < 20.";
                                }

                                else
                                {
                                    OperationView.Text = Value1 + "!";
                                    OperationTest = false;
                                    OperationResult = BasicOperations.FactorialOperation(Value1);
                                    TextBox.Text = OperationResult.ToString();
                                    Historial.Add(new HistoryStruct(Value1.ToString(), "", Operator, OperationResult.ToString()));
                                }
                            }
                            break;
                        }

                    case "Log":
                        {
                            bool logTest = double.TryParse(TextBox.Text, out Test);
                            if (!logTest)
                            {
                                TextBox.Text = "Invalid argument.";
                            }
                            else
                            {
                                OperationView.Text = "Log" + "(" + Value1 + ")";
                                OperationTest = false;
                                OperationResult = BasicOperations.LogarithmOperation(Value1);
                                TextBox.Text = OperationResult.ToString();
                                Historial.Add(new HistoryStruct(Operator + "(", ")", Value1.ToString(), OperationResult.ToString()));
                            }

                            break;
                        }

                    case "10x":
                        {
                            Enter = false;
                            break;
                        }
                }
            }
        }
        ///<summary>
        /// Additionals Buttons 
        ///</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 

        /// <summary>
        /// Power Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Historial  Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button TL = (Button)sender;
            StackPanel parent = (StackPanel)TL.Parent;
            HistoryStruct R = (HistoryStruct)parent.DataContext;
            if (R != null)
            {
                TextBox.Text = R.Result;
                OperationView.Text = R.FirstOperand + R.Operation + R.SecondOperand;
            }
        }
        /// <summary>
        /// Historial Clear Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearHistorialButton_Click(object sender, RoutedEventArgs e)
        {
            Historial.Clear();
        }
    }
}