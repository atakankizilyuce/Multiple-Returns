using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenFazlaDegerDondurme2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
    private void button1_Click(object sender, EventArgs e)
        {
            int carpma = 0;
            int carpma2 = 0;
            int Ref_ToplamaVeCarpma(int sayi1, int sayi2, ref int carpma) // ref 
            {
                carpma = sayi1 * sayi2;
                return sayi1 + sayi2;
            }
            int Ref_ToplaCarpDegeri = Ref_ToplamaVeCarpma(20, 30, ref carpma);
            
            int Out_ToplamaVeCarpma(int sayi1, int sayi2, out int carpma2) // out
            {
                carpma2 = sayi1 * sayi2;
                return sayi1 + sayi2;
            }
            int Out_ToplaCarpDegeri = Out_ToplamaVeCarpma(20, 30, out carpma2);
           

            int[] Array_ToplamaVeCarpma(int sayi1, int sayi2) // array
            {
                int[] ToplaCarp = new int[300];
                ToplaCarp[0] = sayi1 + sayi2;
                ToplaCarp[1] = sayi1 * sayi2;
                return ToplaCarp;
            }
            int[] ToplaCarp = Array_ToplamaVeCarpma(20, 30);
            

            static Struct_ToplamaVeCarpma Struct_ToplamaVeCarpmaDeger(int sayi1, int sayi2) //struct
            {
                Struct_ToplamaVeCarpma toplamaCarpma = new Struct_ToplamaVeCarpma();
                toplamaCarpma.toplama = sayi1 + sayi2;
                toplamaCarpma.carpma = sayi1 * sayi2;
                return toplamaCarpma;
            }

            Struct_ToplamaVeCarpma toplamaVeCarpma = Struct_ToplamaVeCarpmaDeger(20, 30);
            

            Tuple<int, int> Tuple_ToplamaVeCarpma(int sayi1, int sayi2) // tuple
            {
                int toplama, carpma;
                toplama = sayi1 + sayi2;
                carpma = sayi1 * sayi2;
                return new Tuple<int, int>(toplama, carpma);
            }
            var Tuple_ToplamaCarpmaDegeri = Tuple_ToplamaVeCarpma(20, 30);
            label1.Text = Ref_ToplaCarpDegeri.ToString(); // ref output
            label9.Text = carpma2.ToString(); // ref carpma output
            label2.Text = Out_ToplaCarpDegeri.ToString(); // out output
            label10.Text = carpma.ToString(); // out carpma output
            label3.Text = ToplaCarp[0].ToString(); // array 1. eleman output
            label4.Text = ToplaCarp[1].ToString(); // array 2.eleman output
            label5.Text = toplamaVeCarpma.toplama.ToString(); // struct toplama output
            label6.Text = toplamaVeCarpma.carpma.ToString(); // struct carpma output
            label7.Text = Tuple_ToplamaCarpmaDegeri.Item1.ToString(); // tuple 1.deger output
            label8.Text = Tuple_ToplamaCarpmaDegeri.Item2.ToString(); // tuple 2.deger output

           
        }
        struct Struct_ToplamaVeCarpma //struct tanımlama
        {
            public int toplama;
            public int carpma;
        }
           
        
    }
}
