using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChestionarV
{
    public partial class Form1 : Form
    {
        Intrebare[] Q;
        int nr; // la a cata intrebare suntem
        int[,] raspunsuri; // o matrice in care vom retine numarul de ordine al fiecarui raspuns dintr-o intrebare
        int[] scorinterese; // suma numerelor de ordine corespunzatoare fiecarui tip de interes
        string[] interese; 

        public Form1()
        {
            InitializeComponent();
            IncarcaIntrebarile();
            AfisIntrebare();
            
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void IncarcaIntrebarile()
        {
            raspunsuri = new int[6, 6];
            int i, j;

            for (i = 1; i <= 5 ; i++)
                for (j = 0; j < 6; j++)
                    raspunsuri[i, j] = 1;

            Q = new Intrebare[6];

            scorinterese = new int[6];

            for (i = 0; i < 6; i++)
               scorinterese[i] = 0;

            interese = new string[6];
            interese[0] = "Realist";
            interese[1] = "Investigativ";
            interese[2] = "Artistic";
            interese[3] = "Social";
            interese[4] = "Intreprinzator";
            interese[5] = "Conventional";

            nr = 1;
            int n = 0;


            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\madalina\Desktop\ChestionarV\ChestionarV\intrebari.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select count(*) as nr_intrebari from intrebari";

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    r.Read();

                    n = (int)r[0];

                    r.Close();
                }

                conn.Close();
            }


            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\madalina\Desktop\ChestionarV\ChestionarV\intrebari.mdf;Integrated Security=True";

            
            using (SqlConnection conn = new SqlConnection(connString))
            {

                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select *from Intrebari ";
                i = 0;
                j = 0;



                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read() && j <= 5)
                    {

                        
                            Intrebare w = new Intrebare();
                            j++;
                            w.enuntIntrebare = r[1].ToString();
                            w.enuntRaspuns[0] = r[2].ToString();
                            w.enuntRaspuns[1] = r[3].ToString();
                            w.enuntRaspuns[2] = r[4].ToString();
                            w.enuntRaspuns[3] = r[5].ToString();
                            w.enuntRaspuns[4] = r[6].ToString();
                            w.enuntRaspuns[5] = r[7].ToString();
                            
                            Q[j] = w;
                           
                  
                    }

                    r.Close();
                }

                conn.Close();

            }
        }

        void AfisIntrebare()
        {

             Intrebare w = Q[nr];
             labelNr.Text = (nr).ToString();
             labelEnunt.Text = w.enuntIntrebare;

            groupBoxRaspunsuri.Controls.Clear();
            for (int i = 0; i < 6; i++)
            {
                NumericUpDown raspuns = new NumericUpDown();
                raspuns.Minimum = 1;
                raspuns.Maximum = 6;
                raspuns.Value = 1;
                raspuns.Tag = i;
                raspuns.Size = new Size(50, 30);
                raspuns.Location = new Point(5, 25 + i * 25);
                raspuns.ValueChanged += raspuns_ValueChanged;
                groupBoxRaspunsuri.Controls.Add(raspuns);

                Label enuntrasp = new Label();
                enuntrasp.Text = w.enuntRaspuns[i];
                enuntrasp.AutoSize = true;
                enuntrasp.Location = new Point(70, 25 + i * 25);
                groupBoxRaspunsuri.Controls.Add(enuntrasp);
            }

        }

        private void raspuns_ValueChanged(object sender, EventArgs e)
        {
            int k;
            NumericUpDown NrOrdine = sender as NumericUpDown;
            k = (int)NrOrdine.Tag;
            raspunsuri[nr, k] = (int)NrOrdine.Value;

        }
        
        private void buttonUrmatoarea_Click(object sender, EventArgs e)
        {
            int i, j;

            if (nr < 5)
            {

                for (i = 0; i < 5; i++)
                    for (j = i + 1; j < 6; j++)
                        if (raspunsuri[nr, i] == raspunsuri[nr, j])
                        {
                            MessageBox.Show("Exista numere de ordine identice");
                            return;
                        }


                nr++;
                AfisIntrebare();


            }
            else
            if (nr == 5)
            {
                
                for (i = 0; i < 5; i++)
                    for (j = i + 1; j < 6; j++)
                        if (raspunsuri[nr, i] == raspunsuri[nr, j])
                        {
                            MessageBox.Show("Exista numere de ordine identice");
                            return;
                        }

                buttonUrmatoarea.Enabled = false;
                

            }
            else buttonRezultat.Enabled = false;
            
    
         
        }

        private void CalculScor()
        {
            int i, j = 1;

            // suma numerelor de ordine corespunzatoare fiecarui tip de interes, unde scorinterese[0]
            // corespunde lui interese[0] ... 

            scorinterese[0] = raspunsuri[1, 0] + raspunsuri[2, 2] + raspunsuri[3, 1] + raspunsuri[4, 5] +
                         raspunsuri[5, 1];
            scorinterese[1] = raspunsuri[1, 3] + raspunsuri[2, 1] + raspunsuri[3, 3] + raspunsuri[4, 1] +
                         raspunsuri[5, 2];
            scorinterese[2] = raspunsuri[1, 1] + raspunsuri[2, 3] + raspunsuri[3, 4] + raspunsuri[4, 4] +
                         raspunsuri[5, 0];
            scorinterese[3] = raspunsuri[1, 4] + raspunsuri[2, 4] + raspunsuri[3, 0] + raspunsuri[4, 2] +
                         raspunsuri[5, 3];
            scorinterese[4] = raspunsuri[1, 2] + raspunsuri[2, 5] + raspunsuri[3, 5] + raspunsuri[4, 0] +
                         raspunsuri[5, 5];
            scorinterese[5] = raspunsuri[1, 5] + raspunsuri[2, 0] + raspunsuri[3, 2] + raspunsuri[4, 3] +
                         raspunsuri[5, 4];

            // ordonarea intereselor dupa scorul obtinut

            for (i = 0; i < 5; i++)
                for (j = i + 1; j < 6; j++)
                    if (scorinterese[i] > scorinterese[j])
                    {
                        Swap(i, j);
                    }


            groupBoxInterese.Controls.Clear();
            for (i = 0; i < 3; i++)
            {
                Button interes = new Button();
                interes.Text = interese[i].ToString();
                interes.Size = new Size(200, 25);
                interes.Location = new Point(30, 15 + i * 20);
                interes.Click += Interes_Click;
                groupBoxInterese.Controls.Add(interes);
                
            }

        }

        private void Interes_Click(object sender, EventArgs e)
        {
            Button i = sender as Button;
            if(i.Text == "Realist")
            {
                MessageBox.Show("Interesele realiste se manifestă prin tendinţa de a se îndrepta spre activităţi" +
                    "care presupun manipularea obiectelor, maşinilor şi instrumentelor");
            }
            if(i.Text == "Investigativ")
            {
                MessageBox.Show("Interesele investigative (I) presupun o atracţie pentru cercetare, investigare" +
                    " sub diverse forme şi în cele mai diverse domenii(biologic, fizic, social, cultural, etc.)");
            }
            if(i.Text == "Conventional")
            {
                MessageBox.Show("Interesele de tip convenţional (C) presupun preferinţa pentru activităţi care " +
                    "necesită manipularea sistematică şi ordonată a unor date sau obiecte într - un cadru bine organizat şi definit.");
            }
            if(i.Text == "Artistic")
            {
                MessageBox.Show("Interesele artistice (A) se manifestă prin atracţie spre activităţile mai puţin" +
                    "structurate, care presupun o rezolvare creativă şi oferă posibilitatea de autoexpresie(poezie, pictură, muzică, design)");
            }
            if(i.Text == "Social")
            {
                MessageBox.Show("Interesele sociale implică orientarea spre activităţi care necesită relaţionare" +
                    "interpersonală(preferinţa pentru predarea sau pentru a ajuta oamenii să-şi rezolve diverse probleme)");
            }
            if(i.Text == "Intreprinzator")
            {
                MessageBox.Show("Interesele antreprenoriale se manifestă prin preferinţa pentru activităţi care permit" +
                    "iniţiativă şi posibilitate de coordonare a propriei activităţi sau a activităţii unui grup; ");
            }
        }

        private void Swap(int i, int j)
        {
            int aux;
            aux = scorinterese[i];
            scorinterese[i] = scorinterese[j];
            scorinterese[j] = aux;

            string saux;
            saux = interese[i];
            interese[i] = interese[j];
            interese[j] = saux;

        }

        private void buttonRezultat_Click(object sender, EventArgs e)
        {
            CalculScor();

            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\madalina\Desktop\ChestionarV\ChestionarV\facultati.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                listBoxAfisare.Items.Clear();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select facultate from interese where (interesul1 = '" + interese[0].ToString() + "' or interesul2 ='" + interese[0].ToString() + "'or interesul3 ='" + interese[0].ToString() +
                 "') and (interesul1 ='" + interese[1].ToString() + "' or interesul2 = '" + interese[1].ToString() + "' or interesul3 = '" + interese[1].ToString() +
                 "') and (interesul1 ='" + interese[2].ToString() + "' or interesul2 = '" + interese[2].ToString() + "' or interesul3 = '" + interese[2].ToString() +
                 "' or interesul3 IS NULL )";

                   
               

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string linie = r["facultate"].ToString();
                        listBoxAfisare.Items.Add(linie);

                    }

                    r.Close();
                }

                conn.Close();

            }
        }

       
    }
}
