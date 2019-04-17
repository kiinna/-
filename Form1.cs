using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {

        public Form1( )
        {
            InitializeComponent();
        }
        private void schet_Click(object sender, EventArgs e)
        {
            lis.Items.Clear();
            double ros = double.Parse(rost.Text);
            double ve = double.Parse(ves.Text);
            double vo = double.Parse(voz.Text);
//////////////////////////////ЖЕНСКИЙ//////////////////////////////////////////////////////////////////////////
            if (zen.Checked == true)
            {
                ////1СЕДЯЧИЙ//////////////////////////////////////////////////////////////////////////
                if (zis.Text == "Седячий, малоподвижный")
                {
                    double A = 1.3;
                    double z = (10 * ve + 6.25 * ros - 5 * vo - 161) * A; //женский нормы калори
                    double B = Math.Round((z * 0.4) / 4, 2);
                    double Z = Math.Round((z * 0.2) / 9, 2);
                    double Y = Math.Round((z * 0.4) / 4, 2);
                    string[] er = { "  Диапазон калорий : " + "" };
                    lis.Items.AddRange(er);
                    string[] c = { "  суточная норма белка - " + B + " грамм;" };
                    lis.Items.AddRange(c);
                    string[] tries = { "  суточная норма жиров - " + Z + " грамм;" };
                    lis.Items.AddRange(tries);
                    string[] ries = { "  суточная норма углеводов - " + Y + " грамм;" };
                    lis.Items.AddRange(ries);
                    //1
                    if (hel.Text == "Сбросить вес")
                    {
                        double AMR = 0.8;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                    //2
                    else if (hel.Text == "Набрать мышечную массу")
                    {
                        double AMR = 1.2;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                    //3
                    else if (hel.Text == "Поддержать вес")
                    {
                        double AMR = 1;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                }
               else if (zis.Text == "Легкая активность(упражнение  1-3 раза в неделю)")
                {
                    double A = 1.4;
                    double z = (10 * ve + 6.25 * ros - 5 * vo - 161) * A; //женский нормы калори
                    double B = Math.Round((z * 0.4) / 4,2);
                    double Z = Math.Round((z * 0.2) / 9, 2);
                    double Y = Math.Round((z * 0.4) / 4,2);
                    string[] co = { "  Диапазон калорий : " + "" };
                    lis.Items.AddRange(co);
                    string[] c = { "  суточная норма белка - " + B + " грамм;" };
                    lis.Items.AddRange(c);
                    string[] tries = { "  суточная норма жиров - " + Z + " грамм;" };
                    lis.Items.AddRange(tries);
                    string[] ries = { "  суточная норма углеводов - " + Y + " грамм;" };
                    lis.Items.AddRange(ries);
                    //1
                    if (hel.Text == "Сбросить вес")
                    {
                        double AMR = 0.8;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                    //2
                    else if (hel.Text == "Набрать мышечную массу")
                    {
                        double AMR = 1.2;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                    //3
                    else if (hel.Text == "Поддержать вес")
                    {
                        double AMR = 1;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                }
            ////3Средняя активность//////////////////////////////////////////////////////////////////////////
                else if (zis.Text == "Средняя активность(тренировка 3-5 раз в неделю)")
                {
                    double A = 1.6;
                    double z = (10 * ve + 6.25 * ros - 5 * vo - 161) * A;
                    double B = Math.Round((z * 0.4) / 4,2);
                    double Z = Math.Round((z * 0.2) / 9,2);
                    double Y = Math.Round((z * 0.4) / 4,2);
                    string[] co = { "  Диапазон калорий : " + "" };
                    lis.Items.AddRange(co);
                    string[] c = { "  суточная норма белка - " + B + " грамм;" };
                    lis.Items.AddRange(c);
                    string[] tries = { "  суточная норма жиров - " + Z + " грамм;" };
                    lis.Items.AddRange(tries);
                    string[] ries = { "  суточная норма углеводов - " + Y + " грамм;" };
                    lis.Items.AddRange(ries);
                    //1
                    if (hel.Text == "Сбросить вес")
                    {
                        double AMR = 0.8;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                    //2
                    else if (hel.Text == "Набрать мышечную массу")
                    {
                        double AMR = 1.2;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                    //3
                    else if (hel.Text == "Поддержать вес")
                    {
                        double AMR = 1;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                }
                /////4Высокая активность/////////////////////////////////////////////////////////////////////
                else if (zis.Text == "Высокая активность(высокие нагрузки каждый день)")
                {
                    double A = 1.7;
                    double z = Math.Round((10 * ve + 6.25 * ros - 5 * vo - 161) * A,2);
                    double B = Math.Round((z * 0.4) / 4,2);
                    double Z = Math.Round((z * 0.2) / 9,2);
                    double Y = Math.Round((z * 0.4) / 4,2);
                    //1
                    if (hel.Text == "Сбросить вес")
                    {
                        double AMR = 0.8;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = BMR1 * AMR; //Формула Харриса-Бенедикта.
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                    //2
                    else if (hel.Text == "Набрать мышечную массу")
                    {
                        double AMR = 1.2;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                    //3
                    else if (hel.Text == "Поддержать вес")
                    {
                        double AMR = 1;
                        double BMR1 = Math.Round(447.593 + (9.247 * ve) + (3.098 * ros) - (4.330 * vo),2); //BMR для женщин
                        double ben = Math.Round(BMR1 * AMR,2); //Формула Харриса-Бенедикта.
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + z + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR1 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben + "." };
                        lis.Items.AddRange(countr);
                    }
                }
            }
            else if (mus.Checked == true)
            {
                if (zis.Text == "Седячий, малоподвижный")
                {
                    double A = 1.2;
                    double m = (10 * ve + 6.25 * ros - 5 * vo + 5) * A;
                    double B = (m * 0.4) / 4;
                    double Z = (m * 0.2) / 9;
                    double Y = (m * 0.4) / 4;
                    string[] co = { "  Диапазон калорий : " + "" };
                    lis.Items.AddRange(co);
                    string[] c = { "  суточная норма белка - " + B + " грамм;" };
                    lis.Items.AddRange(c);
                    string[] tries = { "  суточная норма жиров - " + Z + " грамм;" };
                    lis.Items.AddRange(tries);
                    string[] ries = { "  суточная норма углеводов - " + Y + " грамм;" };
                    lis.Items.AddRange(ries);
                    if (hel.Text == "Сбросить вес")
                    {
                        double AMR = 0.8;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = Math.Round(BMR2 * AMR,2);
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                    }
                    else if (hel.Text == "Набрать мышечную массу")
                    {
                        double AMR = 1.2;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = Math.Round(BMR2 * AMR,2);
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                    else if (hel.Text == "Поддержать вес")
                    {
                        double AMR = 1;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = Math.Round(BMR2 * AMR,2);
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                }
                else if (zis.Text == "Легкая активность(упражнение  1-3 раза в неделю)")
                {
                    double A = 1.4;
                    double m = Math.Round((10 * ve + 6.25 * ros - 5 * vo + 5) * A,2);
                    double B = Math.Round((m * 0.4) / 4,2);
                    double Z = Math.Round((m * 0.2) / 9,2);
                    double Y = Math.Round((m * 0.4) / 4,2);
                    string[] co = { "  Диапазон калорий : " + "" };
                    lis.Items.AddRange(co);
                    string[] c = { "  суточная норма белка - " + B + " грамм;" };
                    lis.Items.AddRange(c);
                    string[] tries = { "  суточная норма жиров - " + Z + " грамм;" };
                    lis.Items.AddRange(tries);
                    string[] ries = { "  суточная норма углеводов - " + Y + " грамм;" };
                    lis.Items.AddRange(ries);
                    if (hel.Text == "Сбросить вес")
                    {
                        double AMR = 0.8;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = Math.Round(BMR2 * AMR,2);
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                        string[] cou = { "Ориентиры для сбрасывания веса:  " };
                        lis.Items.AddRange(cou);
                    }
                    else if (hel.Text == "Набрать мышечную массу")
                    {
                        double AMR = 1.2;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = Math.Round(BMR2 * AMR,2);
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                    else if (hel.Text == "Поддержать вес")
                    {
                        double AMR = 1;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = Math.Round(BMR2 * AMR,2);
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                }
                else if (zis.Text == "Средняя активность(тренировка 3-5 раз в неделю)")
                {
                    double A = 1.6;
                    double m = Math.Round((10 * ve + 6.25 * ros - 5 * vo + 5) * A,2);
                    double B = Math.Round((m * 0.4) / 4,2);
                    double Z = Math.Round((m * 0.2) / 9,2);
                    double Y = Math.Round((m * 0.4) / 4,2);
                    string[] co = { "  Диапазон калорий :" + "" };
                    lis.Items.AddRange(co);
                    string[] c = { "  суточная норма белка - " + B + " грамм;" };
                    lis.Items.AddRange(c);
                    string[] tries = { "  суточная норма жиров - " + Z + " грамм;" };
                    lis.Items.AddRange(tries);
                    string[] ries = { "  суточная норма углеводов - " + Y + " грамм;" };
                    lis.Items.AddRange(ries);
                    if (hel.Text == "Сбросить вес")
                    {
                        double AMR = 0.8;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = Math.Round(BMR2 * AMR,2);
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                    else if (hel.Text == "Набрать мышечную массу")
                    {
                        double AMR = 1.2;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = BMR2 * AMR;
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                    else if (hel.Text == "Поддержать вес")
                    {
                        double AMR = 1;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = BMR2 * AMR;
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                }
                else if (zis.Text == "Высокая активность(высокие нагрузки каждый день)")
                {
                    double A = 1.7;
                    double m = Math.Round((10 * ve + 6.25 * ros - 5 * vo + 5) * A,2);
                    double B = Math.Round((m * 0.4) / 4,2);
                    double Z = Math.Round((m * 0.2) / 9,2);
                    double Y = Math.Round((m * 0.4) / 4,2);
                    string[] co = { "  Диапазон калорий :" + "" };
                    lis.Items.AddRange(co);
                    string[] c = { "  суточная норма белка - " + B + " грамм;" };
                    lis.Items.AddRange(c);
                    string[] tries = { "  суточная норма жиров - " + Z + " грамм;" };
                    lis.Items.AddRange(tries);
                    string[] ries = { "  суточная норма углеводов - " + Y + " грамм;" };
                    lis.Items.AddRange(ries);
                    if (hel.Text == "Сбросить вес")
                    {
                        double AMR = 0.8;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = BMR2 * AMR;
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] cou = { "Ориентиры для сбрасывания веса:  " };
                        lis.Items.AddRange(cou);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                    else if (hel.Text == "Набрать мышечную массу")
                    {
                        double AMR = 1.2;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = BMR2 * AMR;
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                    else if (hel.Text == "Поддержать вес")
                    {
                        double AMR = 1;
                        double BMR2 = Math.Round(88.362 + (13.397 * ve) + (4.799 * ros) - (5.677 * vo),2); //BMR для женщин
                        double ben2 = Math.Round(BMR2 * AMR,2);
                        string[] ret = { " " };
                        lis.Items.AddRange(ret);
                        string[] countries = { "Суточная норма калорий:" };
                        lis.Items.AddRange(countries);
                        string[] cr = { "  по среднему расходу на килограмм - " + m + ";" };
                        lis.Items.AddRange(cr);
                        string[] countri = { "  по формуле Харриса-Бенедикта - " + BMR2 + ";" };
                        lis.Items.AddRange(countri);
                        string[] countr = { "  по формуле Миффлина - Сан Жеора - " + ben2 + "." };
                        lis.Items.AddRange(countr);
                    }
                }
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(rost.Text) & string.IsNullOrEmpty(ves.Text) & string.IsNullOrEmpty(voz.Text) & string.IsNullOrEmpty(zis.Text) & string.IsNullOrEmpty(hel.Text))
            //   schet.Enabled = false;
            //else if (string.IsNullOrEmpty(mus.Text) || string.IsNullOrEmpty(zen.Text))
            //    schet.Enabled = false;
            //else
            //   schet.Enabled = true;

        }

        private void rost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ves.Focus();
            }

        } 

        private void ves_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                voz.Focus();
            }
        }

        private void voz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ves.Focus();
            }
        }

        private void mus_CheckedChanged(object sender, EventArgs e)
        {
            if (mus.Checked) zen.Checked = false;
        }

        private void zen_CheckedChanged(object sender, EventArgs e)
        {
            if(mus.Checked)zen.Checked = false;
        }

        private void zis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lis_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
