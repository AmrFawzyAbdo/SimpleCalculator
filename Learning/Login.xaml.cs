using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Learning
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            //int calc = Convert.ToInt32(year.Text) - Convert.ToInt32(bornDate.Text);

            //if (calc >= 1 && calc <= 10)
            //{
            //    we.Text = $"Too young, your age is: {calc.ToString()}";
            //}

            int resu = 0;
            result.Text = $"{Convert.ToInt32(resu)}";
            int res = Convert.ToInt32(result.Text);

        }

        //MARK:- Variables
        double first = 0;
        double second = 0;
        bool pl;
        bool mi;
        bool mu;
        bool di;




        //MARK:- Equal button clicked
        void equal_Clicked(System.Object sender, System.EventArgs e)
        {
            if (pl == true && first != 0)
            {
                double finalRes = first + second;
                result.Text = $"{first} + {second} = {finalRes}";
                first = 0;
                second = 0;
            }
            else if (mi == true && first != 0)
            {
                double finalRes = first - second;
                result.Text = $"{first} - {second} = {finalRes}";
                first = 0;
                second = 0;
            }
            else if (mu == true && first != 0)
            {
                double finalRes = first * second;
                result.Text = $"{first} * {second} = {finalRes}";
                first = 0;
                second = 0;
            }
            else if (di == true && first != 0)
            {
                double finalRes = first / second;
                result.Text = $"{first} / {second} = {finalRes}";
                first = 0;
                second = 0;
            }
            else
            {
                result.Text = "0";
            }

        }

        //MARK:- Plus button clicked
        void plus_Clicked(System.Object sender, System.EventArgs e)
        {
            //pl = true;
            //mi = false;
            //mu = false;
            //di = false;
            //if (first == 0)
            //{
            //    result.Text = "0";
            //}
            //else
            //{
            //    result.Text = $"{first} +";
            //}
            //result.Text = $"{first}";

            calcSigns(pll: true, mii: false, muu: false, dii: false, signMark: $"{first} +");


        }

        //MARK:- Minus button clicked
        void minus_Clicked(System.Object sender, System.EventArgs e)
        {
            //pl = false;
            //mi = true;
            //mu = false;
            //di = false;
            //if (first == 0)
            //{
            //    result.Text = "0";
            //}
            //else
            //{
            //    result.Text = $"{first} -";
            //}
            //result.Text = $"{first}";

            calcSigns(pll: false, mii: true, muu: false, dii: false, signMark: $"{first} -");


        }

        //MARK:- Mult button clicked
        void mult_Clicked(System.Object sender, System.EventArgs e)
        {
            //pl = false;
            //mi = false;
            //mu = true;
            //di = false;
            //if (first == 0)
            //{
            //    result.Text = "0";
            //}
            //else
            //{
            //    result.Text = $"{first} *";
            //}

            calcSigns(pll: false, mii: false, muu: true, dii: false, signMark: $"{first} *");

        }


        //MARK:- divide button clicked
        void divide_Clicked(System.Object sender, System.EventArgs e)
        {
            //pl = false;
            //mi = false;
            //mu = false;
            //di = true;
            //if (first == 0)
            //{
            //    result.Text = "0";
            //}
            //else
            //{
            //    result.Text = $"{first} /";
            //}

            calcSigns(pll: false, mii: false, muu: false, dii: true, signMark: $"{first} /");
        }


        //MARK:- Declaration of signs
        private void calcSigns(bool pll, bool mii, bool muu, bool dii, string signMark)
        {
            pl = pll;
            mi = mii;
            mu = muu;
            di = dii;
            if (first == 0)
            {
                result.Text = "0";
            }
            else
            {
                result.Text = $"{signMark}";
            }
        }


        //MARK:- Delete all variables and zero result
        void deleteAll_Clicked(System.Object sender, System.EventArgs e)
        {
            pl = false;
            mi = false;
            mu = false;
            di = false;
            first = 0;
            second = 0;
            result.Text = $"{Convert.ToInt32(0)}";

        }

        //MARK:- Numbers

        void zero_Clicked(System.Object sender, System.EventArgs e)
        {
            calculator(0);
        }

        void one_Clicked(System.Object sender, System.EventArgs e)
        {
            calculator(1);
        }

        void two_Clicked(System.Object sender, System.EventArgs e)
        {
            calculator(2);
            //if (first == 0)
            //{
            //    first = 2;
            //    result.Text = $"{Convert.ToInt32(2)}";
            //}
            //else if (second == 0)
            //{
            //    if (pl == true)
            //    {
            //        second = 2;
            //        result.Text = $"{first} + {Convert.ToInt32(2)}";
            //    }
            //    else
            //    {
            //        second = 2;
            //        result.Text = $"{first} - {Convert.ToInt32(2)}";
            //    }
            //}

            //result.Text = $"{Convert.ToInt32(2)}";
            //first = Convert.ToInt32(result.Text);

        }

        void three_Clicked(System.Object sender, System.EventArgs e)
        {

            calculator(3);

            //if (first == 0)
            //{
            //    first = 3;
            //    result.Text = $"{Convert.ToInt32(3)}";
            //}
            //else if (second == 0)
            //{
            //    if (pl == true)
            //    {
            //        second = 3;
            //        result.Text = $"{first} + {Convert.ToInt32(3)}";
            //    }
            //    else
            //    {
            //        second = 3;
            //        result.Text = $"{first} - {Convert.ToInt32(3)}";
            //    }

            //}
            //second = 3;
            //if (first == 0)
            //{
            //    result.Text = "3";
            //}
            //else {
            //    result.Text = $"{first} + 3";
            //}

        }

        void four_Clicked(System.Object sender, System.EventArgs e)
        {
            calculator(4);
        }

        void five_Clicked(System.Object sender, System.EventArgs e)
        {
            calculator(5);
        }

        void six_Clicked(System.Object sender, System.EventArgs e)
        {
            calculator(6);
        }

        void seven_Clicked(System.Object sender, System.EventArgs e)
        {
            calculator(7);
        }

        void eight_Clicked(System.Object sender, System.EventArgs e)
        {
            calculator(8);
        }

        void nine_Clicked(System.Object sender, System.EventArgs e)
        {
            calculator(9);
        }



        //MARK:- Manage operations according to signs
        private void calculator(int theNumber)
        {
            if (first == 0)
            {
                first = theNumber;
                result.Text = $"{Convert.ToInt32(theNumber)}";
                pl = false;
                mi = false;
                mu = false;
                di = false;
            }
            else if (second == 0)
            {
                if (pl == true)
                {
                    second = theNumber;
                    result.Text = $"{first} + {Convert.ToInt32(theNumber)}";
                }
                else if (mi == true)
                {
                    second = theNumber;
                    result.Text = $"{first} - {Convert.ToInt32(theNumber)}";
                }
                else if (mu == true)
                {
                    second = theNumber;
                    result.Text = $"{first} * {Convert.ToInt32(theNumber)}";
                }
                else if (di == true)
                {
                    second = theNumber;
                    result.Text = $"{first} / {Convert.ToInt32(theNumber)}";
                }
                else
                {
                    result.Text = $"{first}";
                }
            }
        }



    }
}
