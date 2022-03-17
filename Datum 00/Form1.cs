using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datum_00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // ***** Třída DateTime *****
            //Slouží pro uložení časového okamžiku (nejčastěji vyjádřen jako datum a čas)
            //Má spoustu metod pro práci s datem a časem

            //Konstruktor má 12 přetížení, my si vyzkoušíme 4

            //Konstruktor bez parametru - Vytvoří datum a čas 1.1. roku 1, čas je 00:00:00
            DateTime dt1 = new DateTime();
            MessageBox.Show(dt1.ToString());
            //Konstruktor s parametry rok, měsíc, den  (čas zůstane 00:00:00)
            DateTime dt2 = new DateTime(1, 1, 1);
            MessageBox.Show(dt2.ToString());
            //Konstruktor s parametry rok, měsíc, den, hodiny, minuty, sekundy)
            DateTime dt3 = new DateTime(2022, 6, 30, 9, 30, 0);
            MessageBox.Show(dt3.ToString());
            //Konstruktor s parametrem počet taktů (tiků) - zadáme 10 milionů
            DateTime dt4 = new DateTime(10000000);
            MessageBox.Show(dt4.ToString());
            //*******************
            //Vytvoření instance přiřazením konkrétního data a času

            //řetězec parsujeme na DateTime (vyhodí výjimku, když řetězec není zapsán správně)


            //metoda TryParse vrací bool, zda se konverze na DateTime podařila, nikdy nedojde k výjimce

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2012, 4, 9, 15, 6, 48);

            //*** výpis data a času v různých formátech ***

            //MessageBox.Show(dt.ToShortDateString());
            //MessageBox.Show(dt.ToLongDateString());
            //MessageBox.Show(dt.ToShortTimeString());
            //MessageBox.Show(dt.ToLongTimeString());

            //***Výpis data a času v libovolném tvaru - pomocí formátovacího řetězce ***
            
            dt = DateTime.Now;
            //MessageBox.Show(dt.ToString("dddd d. MM. yyyy h:m:s.fff"));
            //MessageBox.Show(dt.ToString("MMMM yyyy"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Aktuální okamžik - vlastnost Now
            DateTime dt = DateTime.Now;
            MessageBox.Show("Aktuální čas a datum pomocí now je: "+dt.ToString());
            //Aktuální datum (den), čas nás nezajímá - vlastnost Today
            dt = DateTime.Today;
            MessageBox.Show("Aktuální čas a datum pomocí today je: "+dt.ToString());
            
        }
         

        private void button5_Click(object sender, EventArgs e)
        {
            //Výpočet věk z data narození - přesně na den

            DateTime narozen = DateTime.Parse(textBox1.Text);
            DateTime dnes = DateTime.Today;

            //věk pouze přibližně = kolik let letos dovrší
            int bDay = narozen.Year;
            int today = dnes.Year;
            int age = today - bDay;
            //Věk chceme PŘESNĚ
            //Spočteme datum letošních narozenin - metoda AddYears zvětší instanci Datetime o zadaný počet let
            DateTime bDayThisYear = narozen.AddYears(age);
            //
            //Pokud ještě letos neměl narozeniny, příslušný věk zatím nedovršil a snížíme jej tedy o 1 rok
            if (bDayThisYear > dnes) age--;
                MessageBox.Show(age+" let");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Dovršení plnoletosti (18 let) nebo jiného věku
            DateTime narozen = DateTime.Parse(textBox2.Text);
            DateTime dnes = DateTime.Today;

            //Zjistíme datum 18-tých narozenin
            //narozeniny18 - datum 18-tých narozenin
            DateTime narozeniny18 = narozen.AddYears(18);
            //Zeptáme se, zda už měl 18-té narozeniny (dříve nebo dnes)

            if (dnes >= narozeniny18) MessageBox.Show("Je plnoletý");
            else MessageBox.Show("Není plnoletý");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            MessageBox.Show(dt.Day.ToString()); //den
            MessageBox.Show(dt.DayOfWeek.ToString()); //den v týdnu
            MessageBox.Show(dt.Month.ToString()); // měsíc
            MessageBox.Show(dt.Year.ToString());//rok
            MessageBox.Show(dt.Date.ToString()); // jenom datum
            MessageBox.Show(dt.Date.ToString("d MMMM yy"));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Parse(textBox3.Text);

            //spočteme datum za 30 dní od zadaného data
            DateTime datumZa30 = datum;
            datumZa30 = datum.AddDays(30);
            //Zeptáme se, zda spočtené datum už nastalo

            if (datumZa30 >= DateTime.Today) MessageBox.Show("Karanční doba nevypršela");
            else MessageBox.Show("Karanční doba vypršela");
            //podobným způsobem se můžeme ptát, zda již uplynuly např. dvě hodiny od zadaného datumu a času (nebo minutz, sekundy..)
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // ***** Třída Timespan *****
            //Slouží pro uchování časového intervalu - doba uplynulá mezi dvěma zadanými okamžiky
            //Pomocí metod můžeme časový interval převádět na různé jednotky (sekundy, minuty, dny apod.)
            //Převádět časový interval na měsíce a roky nelze - nejsou to stejně dlouhé časové jednotky)

            DateTime dt1 = DateTime.Parse(textBox4.Text);
            DateTime dt2 = DateTime.Parse(textBox5.Text);
            TimeSpan doba = dt2 - dt1;
            MessageBox.Show("Uplynulá doba " + doba.Days.ToString());
            MessageBox.Show("Uplynulá doba " + doba.TotalDays.ToString());
            MessageBox.Show("Uplynulá doba " + doba.Minutes.ToString());
            MessageBox.Show("Uplynulá doba " + doba.Seconds.ToString());


            //long x = TimeSpan.TicksPerSecond;
            //MessageBox.Show(x.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            MessageBox.Show(dt.ToShortDateString());
        }
    }
}
