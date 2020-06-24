using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Detektivspiel
{
    public partial class Form2 : Form
    {
        string[] m_Fragen;
        string[] m_Antworten;
        string[] m_Hinweise;
        string[] m_lblHinweis;
        int m_Aktuell;
        int m_LetzteAntwort = -1;

        // database connection information
        string server = "127.0.0.1";
        string user_id = "test";
        string password = "test";
        Int16 port = 3306;
        string database = "detektivspiel";
        string ssl_mode = "Preferred";

        MySqlConnection detektivspielConnection = new MySqlConnection();
        MySqlCommand detektivspielCommand = new MySqlCommand();

        public Form2()
        {
            InitializeComponent();

            m_Hinweise = new string[8];
            m_Fragen = new string[8];
            m_Antworten = new string[8];
            m_lblHinweis = new string[8];

            //Anfangs sind wir bei der ersten Frage
            m_Aktuell = 0;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            m_lblHinweis[0] = "Hinweis 1";
            m_Hinweise[0] = "Die Security hat bestätigt, dass an dem Datum, an dem das Thinkpad verschwand, nur Mitarbeiter (d. h. keine Besucher) das Gebäude mit irgendeiner Hardware verlassen haben.";
            m_Fragen[0] = "Wie viele Menschen bleiben als Verdächtige übrig?";
            m_Antworten[0] = "140";
            m_lblHinweis[1] = "Hinweis 2";
            m_Hinweise[1] = "Die Security hat bestätigt, dass das Thinkpad am 4. Juli 2003 verschwand.\n\n(Hinweis: Bestimmen Sie die komplette Liste der möglichen Verdächtigen durch die Verbindung zweier Tabellen.)";
            m_Fragen[1] = "Wie viele Leute bleiben verdächtig?";
            m_Antworten[1] = "44";
            m_lblHinweis[2] = "Hinweis 3";
            m_Hinweise[2] = "Der Verdächtige hat das Gebäude zwischen 16.00 Uhr und 07.00 Uhr verlassen.";
            m_Fragen[2] = "Wie viele Leute bleiben verdächtig?";
            m_Antworten[2] = "32";
            m_lblHinweis[3] = "Hinweis 4";
            m_Hinweise[3] = "Die Videoüberwachungsbänder zeigen, dass am 4. Juli 2003 von 16.00 bis 19.00 Uhr nur Männer das Gebäude verlassen und Thinkpad-Taschen getragen haben.";
            m_Fragen[3] = "Wie viele Leute bleiben verdächtig?";
            m_Antworten[3] = "23";
            m_lblHinweis[4] = "Hinweis 5";
            m_Hinweise[4] = "Der Verdächtige hat braune Haare.";
            m_Fragen[4] = "Wie viele Leute bleiben verdächtig?";
            m_Antworten[4] = "11";
            m_lblHinweis[5] = "Hinweis 6";
            m_Hinweise[5] = "Der Anruf, der über das vermisste Thinkpad informierte, kam von der Durchwahl 5555.\n\n(Hinweis:. Das ist nicht die Person, die das fehlende Thinkpad nahm, aber Sie brauchen die Informationen aus dem resultierenden Datensatz später im Spiel.)";
            m_Fragen[5] = "Wie viele Leute bleiben verdächtig?";
            m_Antworten[5] = "10";
            m_lblHinweis[6] = "Hinweis 7";
            m_Hinweise[6] = "Ein Thinkpad mit der gleichen Seriennummer wie das fehlende Gerät wurde während einer Inventarisierung im Zimmer X-2111 gefunden. Dieses Zimmer hat eine Zugangsbeschränkung.";
            m_Fragen[6] = "Wer hat das Thinkpad?";
            m_Antworten[6] = "Marc Ost";
            m_lblHinweis[7] = "Hinweis 8";
            m_Hinweise[7] = "Der Chef von Marc Ost wurde kontaktiert. Er erklärte, dass er Marc das Thinkpad gegeben hat, es aber vergessen hatte, die Hardware-Tabelle zu aktualisieren, um einzutragen, dass Marc der neue Besitzer ist. Aktualisieren Sie die Hardware-Tabelle, um die Information zu speichern, dass Marc der neue Besitzer des Thinkpads ist. Klicken Sie dann auf „Fall gelöst“.";
            m_Fragen[7] = "";
            m_Antworten[7] = "";

            //Fortschrittsanzeige
            progressBar1.Minimum = 0;
            progressBar1.Maximum = m_Fragen.Length - 1;
            progressBar1.Value = 0;

            //controls set (hinweis, Frage, )
            lbl_hinweis.Text = m_lblHinweis[m_Aktuell];
            Hinweistext.Text = m_Hinweise[m_Aktuell];
            Frage.Text = m_Fragen[m_Aktuell];
            Antwortfeld.Select();
            Antwortfeld.Text = "";
            btn_weiter.Enabled = false;
            btn_zurueck.Enabled = false;

            //prepopulate MySQL-Connection 
            detektivspielConnection.ConnectionString =
                $"server={server};" +
                $"user id={user_id};" +
                $"password={password};" +
                $"port={port};" +
                $"database={database};" +
                $"SslMode={ssl_mode}";
        }

        private void btn_weiter_Click(object sender, EventArgs e)
        {
            GeheZu();
        }

        private void GeheZu()
        {
            if (m_Aktuell + 1 < m_Fragen.Length)
            {
                m_Aktuell = m_Aktuell + 1;
                lbl_hinweis.Text = m_lblHinweis[m_Aktuell];
                Hinweistext.Text = m_Hinweise[m_Aktuell];
                if (m_Aktuell == m_LetzteAntwort + 1)
                {
                    Frage.Text = m_Fragen[m_Aktuell];
                }
                Antwortfeld.Text = "";
                Antwortfeld.Select();

                if (m_Aktuell + 1 >= m_Fragen.Length)
                {
                    btn_weiter.Enabled = false;

                    //Letzte Frage 
                    Antwortfeld.Visible = false;
                    btn_Antwort_bestaetigen.Visible = false;
                    btn_Fallgeloest.Visible = true;

                }
                btn_zurueck.Enabled = true;
            }
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            if (m_Aktuell > 0)
            {
                m_Aktuell = m_Aktuell - 1;


                lbl_hinweis.Text = m_lblHinweis[m_Aktuell];
                Hinweistext.Text = m_Hinweise[m_Aktuell];
                Antwortfeld.Text = "";

                if (m_Aktuell == 0)
                {
                    btn_zurueck.Enabled = false;
                }
                btn_weiter.Enabled = true;

            }

        }

        private void Antwort_bestaetigen_Click(object sender, EventArgs e)
        {
            if (m_Antworten[m_LetzteAntwort + 1] == Antwortfeld.Text)
            {
                //Richtige Antwort
                m_LetzteAntwort = m_LetzteAntwort + 1;
                progressBar1.Value = m_LetzteAntwort + 1;

                if (m_LetzteAntwort + 1 == m_Antworten.Length - 1)
                {
                    //vorletzter Hinweis
                    MsgBox msg = new MsgBox();
                    msg.Content = "Es wurde bestätigt, dass Marc Ost das Thinkpad nahm. Folgen Sie dem letzten Hinweis, um diese Untersuchung abzuschließen.";
                    msg.Title = "Bestätigt";
                    msg.ShowDialog();
                }
                else
                {
                    //Bestätigung einer richtigen Antwort
                    MsgBox msg = new MsgBox();
                    msg.Content = "Gut gemacht! Die Liste der Verdächtigen wird immer kleiner. Zeit für den nächsten Hinweis.";
                    msg.Title = "Die Suche geht weiter ...";
                    msg.ShowDialog();
                }

                //Gehe zur nächsten Frage, die beantwortet werden muss
                m_Aktuell = m_LetzteAntwort;
                GeheZu();
            }
            else
            {
                //falsche Antwort
                if (m_LetzteAntwort + 1 == m_Antworten.Length - 2)
                {
                    //falsche Antwort auf letzte Frage
                    MsgBox msg = new MsgBox();
                    msg.Content = "Sie haben den falschen Verdächtigen! Versuchen Sie es erneut - stellen Sie sicher, dass alle Hinweise richtig interpretiert wurden.";
                    msg.Title = "Falsch!!!";
                    msg.ShowDialog();
                }
                else
                {
                    //Zwischenhinweis auf falsche Antwort
                    MsgBox msg = new MsgBox();
                    msg.Content = "Sie haben nicht die richtige Anzahl von Verdächtigen gefunden. Versuchen Sie es erneut.";
                    msg.Title = "Verlassen Sie nicht die Spur!";
                    msg.ShowDialog();
                }

                Antwortfeld.Text = "";
                Antwortfeld.Select();

            }
        }

        private void btn_Verlassen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Fallschliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Antwortfeld_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Das Drücken der Enter-Taste nach der Eingabe entspricht dem Klick auf "Bestätigen"
                btn_Antwort_bestaetigen.PerformClick();
            }
        }

        private void btn_RunQuery_Click(object sender, EventArgs e)
        {
            // check if query string is not set
            if (!(Txt_QueryCmd.TextLength > 1))
            {
                return;
            }

            if (Txt_QueryCmd.Text.ToUpper().StartsWith("SELECT"))
            {
                DataTable myDataTable = RunSelectQuery(detektivspielConnection, detektivspielCommand, out bool success);

                if (success)
                {
                    //display dataset in a DataGrid
                    Grid_QueryResult.DataSource = myDataTable;
                    Grid_QueryResult.AutoResizeColumns();
                }
            }
            else if (Txt_QueryCmd.Text.ToUpper().StartsWith("INSERT"))
            {
                int anzahl = RunNonQuery(detektivspielConnection, detektivspielCommand);

                if (anzahl > 0)
                {
                    MessageBox.Show("Ein Datensatz wurde eingefügt!");
                }
            }
            else
            {
                MessageBox.Show("Es sind nur SELECT und INSERT Querys zugelassen!!!");
            }
        }

        private DataTable RunSelectQuery(MySqlConnection con, MySqlCommand cmd, out bool success)
        {
            // link db connection to query command
            cmd.Connection = con;
            // add query text
            cmd.CommandText = Txt_QueryCmd.Text;

            // create RAM table
            DataTable dt = new DataTable();

            try
            {
                con.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // fill RAM-Table with query result
                adapter.Fill(dt);

                success = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                success = false;
            }

            con.Close();
            return dt;
        }

        private Int32 RunNonQuery(MySqlConnection con, MySqlCommand cmd)
        {
            // link db connection to query command
            cmd.Connection = con;
            // add query text
            cmd.CommandText = Txt_QueryCmd.Text;

            // set default
            Int32 count = -1;

            try
            {
                con.Open();

                // get number of datasets
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            return count;
        }
    }
}