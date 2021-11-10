using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace U44Afl
{
    public partial class Form1 : Form
    {
        string strconn = @"Data Source=RASMUS-LAPTOP;Initial Catalog=U44DBAfl;Integrated Security=True"; //Connection string to a local SQL DB
        private const bool test = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u44DBAflDataSet.Ordre' table. You can move, or remove it, as needed.
            this.ordreTableAdapter.Fill(this.u44DBAflDataSet.Ordre);

        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            string OrdreId = maskedOIDTextBox.Text;
            string KundeTlf = maskedKtlfTextBox.Text;
            string Tekst = maskedTekstBox.Text;
            string Pris = maskedPrisTextBox.Text;

            // assumption:
            bool KundeTlf_ok = true, Tekst_ok = true, Pris_ok = true;

            // length check:
            if (KundeTlf.Length > 11) KundeTlf_ok = false;
            if (Tekst.Length > 50) Tekst_ok = false;
            if (Pris.Length > 20) Pris_ok = false;

            // "<" check for JS tags ... NO cross site scripting here.:
            if (KundeTlf.Contains("<")) KundeTlf_ok = false;
            if (Tekst.Contains("<")) Tekst_ok = false;
            if (Pris.Contains("<")) Pris_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(KundeTlf)) KundeTlf_ok = false;

            // Check for alphanumeric characters
            Regex dectal = new Regex(@"(^[0-9 ]*.?[0-9]*$)");
            if (!dectal.IsMatch(Pris)) Pris_ok = false;

            // action
            if (KundeTlf_ok && Tekst_ok && Pris_ok)
            {
                // database med kundetabel:
                SqlConnection conn = new SqlConnection(strconn);

                //C(RUD):
                string sqlCom = "INSERT INTO Ordre VALUES (@kundetlf, @tekst, @pris);";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@kundetlf", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@kundetlf"].Value = Convert.ToString(KundeTlf);
                cmd.Parameters.Add("@tekst", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@tekst"].Value = Convert.ToString(Tekst);
                cmd.Parameters.Add("@pris", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@pris"].Value = Convert.ToDecimal(Pris);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@kundetlf"].Value + ", " +
                                    cmd.Parameters["@tekst"].Value + ", " +
                                    cmd.Parameters["@pris"].Value +
                                    ")");
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                    this.ordreTableAdapter.Fill(this.u44DBAflDataSet.Ordre);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                }
            }
            else if (!KundeTlf_ok)
            {
                MessageBox.Show("Der må kun indtastes tal i Kunde Tlf. feltet, samt maks 11 tegn.");
                maskedOIDTextBox.Text = "";
                maskedKtlfTextBox.Text = "";
            }

            else if (!Tekst_ok)
            {
                MessageBox.Show("Der må maks være 50 tegn i Tekst feltet.");
                maskedOIDTextBox.Text = "";
                maskedTekstBox.Text = "";
            }

            else if (!Pris_ok)
            {
                MessageBox.Show("Der må kun indtastes tal og et komma/punktum i Pris feltet, samt maks 50 tegn og maks 2 decimaler.");
                maskedOIDTextBox.Text = "";
                maskedPrisTextBox.Text = "";
            }
        }

        private void autofillbutton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();

            string OrdreId = maskedOIDTextBox.Text;

            //(C)R(UD)

            string sSQL = "SELECT kundetlf FROM Ordre WHERE OrdreId = " + OrdreId + "; "; //Udfylder kunde tlf. feltet
            SqlCommand command = new SqlCommand(sSQL, conn);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            maskedKtlfTextBox.Text = reader.GetString(0);

            //Luk reader
            reader.Close();
            sSQL = "SELECT tekst FROM Ordre WHERE OrdreId = " + OrdreId + "; "; //Udfylder tekst feltet  
            command = new SqlCommand(sSQL, conn);
            SqlDataReader reader2 = command.ExecuteReader();

            reader2.Read();
            maskedTekstBox.Text = reader2.GetString(0);

            //Luk reader2
            reader2.Close();
            sSQL = "SELECT pris FROM Ordre WHERE OrdreId = " + OrdreId + "; "; //Udfylder pris feltet
            command = new SqlCommand(sSQL, conn);
            SqlDataReader reader3 = command.ExecuteReader();

            reader3.Read();
            maskedPrisTextBox.Text = Convert.ToString(reader3.GetDecimal(0));

            //Luk reader3
            reader3.Close();

            command.ExecuteNonQuery(); //Execute query

            this.ordreTableAdapter.Fill(this.u44DBAflDataSet.Ordre);

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string OrdreId = maskedOIDTextBox.Text;
            string KundeTlf = maskedKtlfTextBox.Text;
            string Tekst = maskedTekstBox.Text;
            string Pris = maskedPrisTextBox.Text;

            // assumption:
            bool KundeTlf_ok = true, Tekst_ok = true, Pris_ok = true;

            // length check:
            if (KundeTlf.Length > 11) KundeTlf_ok = false;
            if (Tekst.Length > 50) Tekst_ok = false;
            if (Pris.Length > 20) Pris_ok = false;

            // "<" check for JS tags ... NO cross site scripting here.:
            if (KundeTlf.Contains("<")) KundeTlf_ok = false;
            if (Tekst.Contains("<")) Tekst_ok = false;
            if (Pris.Contains("<")) Pris_ok = false;

            // Check for alphanumeric characters
            Regex retal = new Regex(@"(^[0-9 ]*$)");
            if (!retal.IsMatch(KundeTlf)) KundeTlf_ok = false;

            // Check for alphanumeric characters
            Regex dectal = new Regex(@"(^[0-9 ]*.?[0-9]*$)");
            if (!dectal.IsMatch(Pris)) Pris_ok = false;

            // action
            if (KundeTlf_ok && Tekst_ok && Pris_ok)
            {
                // database med kundetabel:
                SqlConnection conn = new SqlConnection(strconn);

                //(CR)U(D):
                string sqlCom = "UPDATE Ordre SET KundeTlf = @kundetlf, Tekst = @tekst, Pris = @pris WHERE OrdreId = @OrdreId;";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@OrdreId", System.Data.SqlDbType.Int);
                cmd.Parameters["@OrdreId"].Value = Convert.ToInt32(OrdreId);
                cmd.Parameters.Add("@kundetlf", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@kundetlf"].Value = Convert.ToString(KundeTlf);
                cmd.Parameters.Add("@tekst", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@tekst"].Value = Convert.ToString(Tekst);
                cmd.Parameters.Add("@pris", System.Data.SqlDbType.Decimal);
                cmd.Parameters["@pris"].Value = Convert.ToDecimal(Pris);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close(); 
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@OrdreId"].Value + ", " +
                                    cmd.Parameters["@kundetlf"].Value + ", " +
                                    cmd.Parameters["@tekst"].Value + ", " +
                                    cmd.Parameters["@pris"].Value +
                                    ")");
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                    this.ordreTableAdapter.Fill(this.u44DBAflDataSet.Ordre);
                }

                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                }
            }
            else if (!KundeTlf_ok) //Fejl besked for Kunde Tlf. feltet
            {
                MessageBox.Show("Der må kun indtastes tal i Kunde Tlf. feltet, samt maks 11 tegn.");
                maskedOIDTextBox.Text = "";
                maskedKtlfTextBox.Text = "";
            }

            else if (!Tekst_ok) //Fejl besked for Tekst feltet
            {
                MessageBox.Show("Der må maks være 50 tegn i Tekst feltet.");
                maskedOIDTextBox.Text = "";
                maskedTekstBox.Text = "";
            }

            else if (!Pris_ok) //Fejl besked for Pris feltet
            {
                MessageBox.Show("Der må kun indtastes tal og et komma/punktum i Pris feltet, samt maks 50 tegn og maks 2 decimaler.");
                maskedOIDTextBox.Text = "";
                maskedPrisTextBox.Text = "";
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string OrdreId = maskedOIDTextBox.Text;

            // assumption:
            bool KundeTlf_ok = true, Tekst_ok = true, Pris_ok = true;

            // action
            if (KundeTlf_ok && Tekst_ok && Pris_ok)
            {
                // database med kundetabel:
                SqlConnection conn = new SqlConnection(strconn);

                //(CRU)D:
                string sqlCom = "DELETE FROM Ordre WHERE (OrdreId = @OrdreId);";
                SqlCommand cmd = new SqlCommand(sqlCom, conn);
                cmd.Parameters.Add("@OrdreId", System.Data.SqlDbType.Int);
                cmd.Parameters["@OrdreId"].Value = Convert.ToInt32(OrdreId);

                // Attempt to execute query
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close(); 
                    MessageBox.Show("SUCCESS :\n" + sqlCom + "\nmed værdierne: (" +
                                    cmd.Parameters["@OrdreId"].Value + ")");
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                    this.ordreTableAdapter.Fill(this.u44DBAflDataSet.Ordre);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("ERROR: \n\n" + exc.ToString());
                    maskedOIDTextBox.Text = "";
                    maskedKtlfTextBox.Text = "";
                    maskedTekstBox.Text = "";
                    maskedPrisTextBox.Text = "";
                }
            }
            else
                MessageBox.Show("Wrong user input!!! TBC");
                maskedOIDTextBox.Text = "";
                maskedKtlfTextBox.Text = "";
                maskedTekstBox.Text = "";
                maskedPrisTextBox.Text = "";
        }
    }
}
