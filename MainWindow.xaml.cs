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

namespace _2048
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] number = new int[25];

        public MainWindow()
        {
            InitializeComponent();

            int IsOK = 0;
            while (IsOK == 0)
            {
                Random rnd = new Random();
                int temp = rnd.Next(0, 16);
                if (number[temp] == 0)
                {
                    number[temp] = 2;
                    IsOK = 1;
                    Save();
                }
            }
        }

        private void Save()
        {
            a0.Content = number[0];
            a1.Content = number[1];
            a2.Content = number[2];
            a3.Content = number[3];
            a4.Content = number[4];
            a5.Content = number[5];
            a6.Content = number[6];
            a7.Content = number[7];
            a8.Content = number[8];
            a9.Content = number[9];
            a10.Content = number[10];
            a11.Content = number[11];
            a12.Content = number[12];
            a13.Content = number[13];
            a14.Content = number[14];
            a15.Content = number[15];
        }

        private void Show()
        {
            number[0] = (int)a0.Content;
            number[1] = (int)a1.Content;
            number[2] = (int)a2.Content;
            number[3] = (int)a3.Content;
            number[4] = (int)a4.Content;
            number[5] = (int)a5.Content;
            number[6] = (int)a6.Content;
            number[7] = (int)a7.Content;
            number[8] = (int)a8.Content;
            number[9] = (int)a9.Content;
            number[10] = (int)a10.Content;
            number[11] = (int)a11.Content;
            number[12] = (int)a12.Content;
            number[13] = (int)a13.Content;
            number[14] = (int)a14.Content;
            number[15] = (int)a15.Content;
        }

        private void Up_Click(object sender, RoutedEventArgs e)
        {
            int IsChanged = 0;

            while (IsChanged == 0)
            {
                IsChanged = 1;
                for (int i = 0; i < 16; i++)
                {
                    if (number[i] == 0)
                    {
                        number[i] = number[i + 4];
                        if (number[i+4] != 0) IsChanged = 0;
                        number[i + 4] = 0;
                        
                    }
                    else if (number[i] == number[i + 4] && number[i] != 0)
                    {
                        number[i] += number[i + 4];
                        number[i + 4] = 0;
                        IsChanged = 0;
                    }
                }
            }

            int IsOK = 0;
            while (IsOK == 0)
            {
                Random rnd = new Random();
                int temp = rnd.Next(0, 16);
                if (number[temp] == 0)
                {
                    number[temp] = 2;
                    IsOK = 1;
                    Save();
                }
            }
            Save();
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            int[] numberleft = new int[24];
            numberleft[0] = number[0];
            numberleft[4] = number[1];
            numberleft[8] = number[2];
            numberleft[12] = number[3];
            numberleft[1] = number[4];
            numberleft[5] = number[5];
            numberleft[9] = number[6];
            numberleft[13] = number[7];
            numberleft[2] = number[8];
            numberleft[6] = number[9];
            numberleft[10] = number[10];
            numberleft[14] = number[11];
            numberleft[3] = number[12];
            numberleft[7] = number[13];
            numberleft[11] = number[14];
            numberleft[15] = number[15];


            int IsChanged = 0;

            while (IsChanged == 0)
            {
                IsChanged = 1;
                for (int i = 0; i < 16; i++)
                {
                    if (numberleft[i] == 0)
                    {
                        numberleft[i] = numberleft[i + 4];
                        if (numberleft[i + 4] != 0) IsChanged = 0;
                        numberleft[i + 4] = 0;

                    }
                    else if (numberleft[i] == numberleft[i + 4] && numberleft[i] != 0)
                    {
                        numberleft[i] += numberleft[i + 4];
                        numberleft[i + 4] = 0;
                        IsChanged = 0;
                    }
                }
            }

            number[0] = numberleft[0];
            number[1] = numberleft[4];
            number[2] = numberleft[8];
            number[3] = numberleft[12];
            number[4] = numberleft[1];
            number[5] = numberleft[5];
            number[6] = numberleft[9];
            number[7] = numberleft[13];
            number[8] = numberleft[2];
            number[9] = numberleft[6];
            number[10] = numberleft[10];
            number[11] = numberleft[14];
            number[12] = numberleft[3];
            number[13] = numberleft[7];
            number[14] = numberleft[11];
            number[15] = numberleft[15];


            int IsOK = 0;
            while (IsOK == 0)
            {
                Random rnd = new Random();
                int temp = rnd.Next(0, 16);
                if (number[temp] == 0)
                {
                    number[temp] = 2;
                    IsOK = 1;
                    Save();
                }
            }
            Save();
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            int[] numberleft = new int[24];
            numberleft[12] = number[0];
            numberleft[8] = number[1];
            numberleft[4] = number[2];
            numberleft[0] = number[3];
            numberleft[13] = number[4];
            numberleft[9] = number[5];
            numberleft[5] = number[6];
            numberleft[1] = number[7];
            numberleft[14] = number[8];
            numberleft[10] = number[9];
            numberleft[6] = number[10];
            numberleft[2] = number[11];
            numberleft[15] = number[12];
            numberleft[11] = number[13];
            numberleft[7] = number[14];
            numberleft[3] = number[15];


            int IsChanged = 0;

            while (IsChanged == 0)
            {
                IsChanged = 1;
                for (int i = 0; i < 16; i++)
                {
                    if (numberleft[i] == 0)
                    {
                        numberleft[i] = numberleft[i + 4];
                        if (numberleft[i + 4] != 0) IsChanged = 0;
                        numberleft[i + 4] = 0;

                    }
                    else if (numberleft[i] == numberleft[i + 4] && numberleft[i] != 0)
                    {
                        numberleft[i] += numberleft[i + 4];
                        numberleft[i + 4] = 0;
                        IsChanged = 0;
                    }
                }
            }

            number[0] = numberleft[12];
            number[1] = numberleft[8];
            number[2] = numberleft[4];
            number[3] = numberleft[0];
            number[4] = numberleft[13];
            number[5] = numberleft[9];
            number[6] = numberleft[5];
            number[7] = numberleft[1];
            number[8] = numberleft[14];
            number[9] = numberleft[10];
            number[10] = numberleft[6];
            number[11] = numberleft[2];
            number[12] = numberleft[15];
            number[13] = numberleft[11];
            number[14] = numberleft[7];
            number[15] = numberleft[3];


            int IsOK = 0;
            while (IsOK == 0)
            {
                Random rnd = new Random();
                int temp = rnd.Next(0, 16);
                if (number[temp] == 0)
                {
                    number[temp] = 2;
                    IsOK = 1;
                    Save();
                }
            }
            Save();
        }

        private void Down_Click(object sender, RoutedEventArgs e)
        {
            int[] numberleft = new int[24];
            numberleft[15] = number[0];
            numberleft[14] = number[1];
            numberleft[13] = number[2];
            numberleft[12] = number[3];
            numberleft[11] = number[4];
            numberleft[10] = number[5];
            numberleft[9] = number[6];
            numberleft[8] = number[7];
            numberleft[7] = number[8];
            numberleft[6] = number[9];
            numberleft[5] = number[10];
            numberleft[4] = number[11];
            numberleft[3] = number[12];
            numberleft[2] = number[13];
            numberleft[1] = number[14];
            numberleft[0] = number[15];


            int IsChanged = 0;

            while (IsChanged == 0)
            {
                IsChanged = 1;
                for (int i = 0; i < 16; i++)
                {
                    if (numberleft[i] == 0)
                    {
                        numberleft[i] = numberleft[i + 4];
                        if (numberleft[i + 4] != 0) IsChanged = 0;
                        numberleft[i + 4] = 0;

                    }
                    else if (numberleft[i] == numberleft[i + 4] && numberleft[i] != 0)
                    {
                        numberleft[i] += numberleft[i + 4];
                        numberleft[i + 4] = 0;
                        IsChanged = 0;
                    }
                }
            }

            number[0] = numberleft[15];
            number[1] = numberleft[14];
            number[2] = numberleft[13];
            number[3] = numberleft[12];
            number[4] = numberleft[11];
            number[5] = numberleft[10];
            number[6] = numberleft[9];
            number[7] = numberleft[8];
            number[8] = numberleft[7];
            number[9] = numberleft[6];
            number[10] = numberleft[5];
            number[11] = numberleft[4];
            number[12] = numberleft[3];
            number[13] = numberleft[2];
            number[14] = numberleft[1];
            number[15] = numberleft[0];


            int IsOK = 0;
            while (IsOK == 0)
            {
                Random rnd = new Random();
                int temp = rnd.Next(0, 16);
                if (number[temp] == 0)
                {
                    number[temp] = 2;
                    IsOK = 1;
                    Save();
                }
            }
            Save();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            for(int i=0; i < 25; i++)
            {
                number[i] = 0;
            }

            int IsOK = 0;
            while (IsOK == 0)
            {
                Random rnd = new Random();
                int temp = rnd.Next(0, 16);
                if (number[temp] == 0)
                {
                    number[temp] = 2;
                    IsOK = 1;
                    Save();
                }
            }
        }
    }
}
