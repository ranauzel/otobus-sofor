using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace otobus_sofor
{
    public partial class Form1 : Form
    {
        public LinkedList obj;
        public Form1()
        {
            InitializeComponent();
            obj = new LinkedList();

            listbox.Items.Add(comboBox2.Text);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (obj.search(obj.head, "AHMET ÜNAL"))
            {
             
                listbox.Items.Add("");
                listbox.Items.Add("TC:34573898324");
                listbox.Items.Add("DOĞUM TARİHİ:13.01.1979");
                listbox.Items.Add("VARDİYA:GÜNDÜZ");

            }
            else if (obj.search(obj.head, "MUSTAFA YILMAZ"))
            {
                listbox.Items.Add("");
                listbox.Items.Add("TC: 16783489270");
                listbox.Items.Add("DOĞUM TARİHİ: 15.09.1976");
                listbox.Items.Add("VARDİYA: GECE");
            }
            else if (obj.search(obj.head, "FATİH AY"))
            {
                listbox.Items.Add("");
                listbox.Items.Add("TC: 46792412890");
                listbox.Items.Add("DOĞUM TARİHİ: 11.10.1980");
                listbox.Items.Add("VARDİYA: GECE");
            }
            else if (obj.search(obj.head, "MUSA YANAR"))
            {
                listbox.Items.Add("");
                listbox.Items.Add("TC: 75689423624");
                listbox.Items.Add("DOĞUM TARİHİ: 12.11.1982");
                listbox.Items.Add("VARDİYA: GÜNDÜZ");
            }
            else if (obj.search(obj.head, "HAMDİ BULUT"))
            {
                listbox.Items.Add("");
                listbox.Items.Add("TC: 42365874528");
                listbox.Items.Add("DOĞUM TARİHİ: 17.05.1975");
                listbox.Items.Add("VARDİYA: GÜNDÜZ");
            }
            else if (obj.search(obj.head, "ALİ ARI"))
            {
                listbox.Items.Add("");
                listbox.Items.Add("TC: 16574623422");
                listbox.Items.Add("DOĞUM TARİHİ: 14.06.1976");
                listbox.Items.Add("VARDİYA: GECE");
            }
            else if (obj.search(obj.head, "METİN KARS"))
            {
                listbox.Items.Add("");
                listbox.Items.Add("TC: 86475689112");
                listbox.Items.Add("DOĞUM TARİHİ: 11.03.1987");
                listbox.Items.Add("VARDİYA: GÜNDÜZ");
            }
            else if (obj.search(obj.head, "HAKAN ŞAŞMAZ"))
            {
                listbox.Items.Add("");
                listbox.Items.Add("TC: 42365874528");
                listbox.Items.Add("DOĞUM TARİHİ: 170.05.1975");
                listbox.Items.Add("VARDİYA: GÜNDÜZ");
            }
            else if (obj.search(obj.head, "MEHMET ŞİMŞEK"))
            {
                listbox.Items.Add("");
                listbox.Items.Add("TC:45675315824");
                listbox.Items.Add("DOĞUM TARİHİ: 09.02.1977");
                listbox.Items.Add("VARDİYA: GECE");
            }
            else if (obj.search(obj.head, "NURİ KARS"))
            {
                listbox.Items.Add("");
                listbox.Items.Add("TC: 78564123536");
                listbox.Items.Add("DOĞUM TARİHİ: 29.12.1978");
                listbox.Items.Add("VARDİYA: GÜNDÜZ");
            }
            else if (obj.search(obj.head, "FEHMİ KURT"))
            {
                
                listbox.Items.Add("");
                listbox.Items.Add("TC: 18823657882");
                listbox.Items.Add("DOĞUM TARİHİ: 22.05.1975");
                listbox.Items.Add("VARDİYA: GECE");
            }
            else if (obj.search(obj.head, "SEMİH ŞANSLI"))
            {
               
                listbox.Items.Add("");
                listbox.Items.Add("TC: 97851232510");
                listbox.Items.Add("DOĞUM TARİHİ: 18.07.1981");
                listbox.Items.Add("VARDİYA: GÜNDÜZ");
            }
            else if (obj.search(obj.head, "VOLKAN UYANIK"))
            {
      
                listbox.Items.Add("");
                listbox.Items.Add("TC: 12849667532");
                listbox.Items.Add("DOĞUM TARİHİ: 04.03.1988");
                listbox.Items.Add("VARDİYA: GECE");
            }
            else if (obj.search(obj.head, "HAKAN ÖZÇELİK")) 
            {
           
                listbox.Items.Add("");
                listbox.Items.Add("TC: 75634957834");
                listbox.Items.Add("DOĞUM TARİHİ: 01.02.1988");
                listbox.Items.Add("VARDİYA: GÜNDÜZ");
            }
            else if (obj.search(obj.head, "HASAN SALİM"))
            {
              
                listbox.Items.Add("");
                listbox.Items.Add("TC:46878523210");
                listbox.Items.Add("DOĞUM TARİHİ: 11.08.1979");
                listbox.Items.Add("VARDİYA: GECE");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("İSTANBUL");
            comboBox1.Items.Add("ANKARA");
            comboBox1.Items.Add("BURSA");
            comboBox1.Items.Add("BALIKESİR");
            comboBox1.Items.Add("İZMİR");
         
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İSTANBUL")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("AHMET ÜNAL");
                comboBox2.Items.Add("MUSTAFA YILMAZ");
                comboBox2.Items.Add("FATİH AY");

            }

            if (comboBox1.Text == "ANKARA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("MUSA YANAR");
                comboBox2.Items.Add("HAMDİ BULUT");
                comboBox2.Items.Add("ALİ ARI");

            }

            if (comboBox1.Text == "BURSA")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("METİN KARS");
                comboBox2.Items.Add("HAKAN ŞAŞMAZ");
                comboBox2.Items.Add("MEHMET ŞİMŞEK");

            }

            if (comboBox1.Text == "BALIKESİR")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("NURİ KARS");
                comboBox2.Items.Add("FEHMİ KURT");
                comboBox2.Items.Add("SEMİH ŞANSLI");

            }

            if (comboBox1.Text == "İZMİR")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("VOLKAN UYANIK");
                comboBox2.Items.Add("HAKAN ÖZÇELİK");
                comboBox2.Items.Add("HASAN SALİM");

            }

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj.push(comboBox2.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string file = "C:\\Folder\\File.txt";

            FileStream stream = File.Create(file);
            StreamWriter sw = new StreamWriter(stream);
        }
    }
}


