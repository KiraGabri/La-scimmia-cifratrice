using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;
using System.IO;


namespace UsaSeriale
{
    public partial class Form1 : Form
    {
        int UserId;
        string currentKey;
        int[] transpVal; // Valori di cifratura
        char[,] currentVigenereTb; // tabella di vigenere
        static string phRow = "!#$%&()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~"; // Rimosso il doppio backslash e il singolo apice per ora
        string arduinoOutput; // Conterra` il risultato di arduino
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbSerialPort.Items.Add(port);
            }
            cmbBaudRate.SelectedIndex = 0;
        }

        private void CreateVigenereTable(string TrValues)
        {

            int modifier = 0;
            int CharCursor = modifier;
            currentVigenereTb = new char[TrValues.Length, TrValues.Length];
            for (int y = 0; y < TrValues.Length; y++)
            {
                CharCursor = modifier;
                for (int x = 0; x < TrValues.Length; x++)
                {
                    if (CharCursor < TrValues.Length)
                    {
                        currentVigenereTb[y, x] = TrValues[CharCursor];
                        CharCursor++;
                    }
                    else
                    {
                        x--;
                        CharCursor = 0;
                    }
                }
                modifier++;
            }
        }

        private void removeSpaces(string stringTranspVal) 
        {
            transpVal = new int[Int32.Parse(comboBoxKey.Text)];
            char[] values = stringTranspVal.ToCharArray();
            int c = 0;
            transpVal[c]=Int32.Parse( values[c].ToString());
            c++;
            int n=0;
            for (; c < stringTranspVal.Length; c++)
            {

                if (values[c] == ' ')
                {

                }
                else
                {
                    if (values[c - 1] != ' ')
                    {
                        transpVal[n] = (transpVal[n])* 10 + Int32.Parse(values[c].ToString());
                    }
                    else 
                    {
                        n++;
                        transpVal[n] = Int32.Parse(values[c].ToString());
                    }
                    
                }

            }

            
        }

        private void reverseTranspVal(string sTranspVal)
        {// sTranspVal = valori di comboboxValTrasp;
            transpVal = default;
            currentKey = "";
            removeSpaces(sTranspVal);
            
            char[] row = phRow.ToCharArray();
            for(int counter = 0;counter< Int32.Parse(comboBoxKey.Text); counter++) 
            {
                
                currentKey=currentKey+row[transpVal[counter]];
            }
        }

        private void findTranspVal() 
        {
            string key = currentKey;
            int keyCounter = 0;
            transpVal = new int[key.Length];

            for (int counter = 0; counter < key.Length; counter++, keyCounter++)
            {
                if (keyCounter >= key.Length)
                {
                    keyCounter = 0;
                }
                transpVal[keyCounter] = phRow.IndexOf(key[keyCounter]);

            }
        }
        private string CryptString(char[,] table, string key, string sourceString)
        {
            
            
            int keyCounter = 0;
            string cripted = "";

            for (int sourceCounter = 0; sourceCounter < sourceString.Length; sourceCounter++, keyCounter++)
            {
                if (keyCounter >= key.Length)
                {
                    keyCounter = 0;
                }
                int a = phRow.IndexOf(key[keyCounter]);
                int b = phRow.IndexOf(sourceString[sourceCounter]);
                cripted = cripted+table[phRow.IndexOf(key[keyCounter]), phRow.IndexOf(sourceString[sourceCounter])];
            }
            return cripted;
        }

        private bool completeReg()
        {
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("INSERT monkey.mUsers  ");
                sql.AppendLine("(NomeUtente,Password) VALUES('" + textBoxRegUtente.Text.Trim() + "','" + textBoxRegConfermaPassword.Text.GetHashCode() + "')");

                if (GestioneMySql.InsertValues(sql.ToString()))
                {
                    buttonConfermaReg.Enabled = false;
                    MessageBox.Show("Registrazione completata");
                    buttonConfermaReg.Enabled = true;

                    return true;
                }
                else
                {
                    MessageBox.Show("Registrazione fallita riprova");
                    return false;
                }

            }
            catch
            {
                MessageBox.Show("Errore nella registrazione contattare i tecnici scimmia");
                return false;
            }


        }

        private void checkDbCryptoSettings()
        {
            try
            {
                comboBoxKey.Items.Clear();
                comboBoxValTransp.Items.Clear();
                StringBuilder sql = new StringBuilder();
                MySqlDataReader rdr = GestioneMySql.RequestQuery("SELECT DISTINCT KeyLength,valTrasposizione FROM monkey.mkeys,monkey.mUsers WHERE mKeys.Utente_ID='"+ UserId + "';");
                while (rdr.Read())
                {
                    comboBoxKey.Items.Add(rdr[0]);
                    comboBoxValTransp.Items.Add(rdr[1]);

                }
                comboBoxKey.SelectedIndex = 0;
                comboBoxValTransp.SelectedIndex = 0;

                rdr.Close();
                reverseTranspVal(comboBoxValTransp.Text);
                textBoxValK.Text = currentKey;

            }
            catch
            {
                MessageBox.Show("Errore nella richiesta delle impostazioni di criptazione al Database");
                GestioneMySql.ChiudiConnessione();
            }
        }

        private void buttonConfermaReg_Click(object sender, EventArgs e)
        {
            if ((textBoxRegConfermaPassword.Text.Equals(textBoxRegPassword.Text)) && (textBoxRegConfermaPassword.Text != ""))
            {
                string sql = "SELECT NomeUtente FROM monkey.mUsers WHERE NomeUtente='" + textBoxRegUtente.Text.ToString() + "';";
                try
                {
                    MySqlDataReader rdr = GestioneMySql.RequestQuery(sql);
                    if (rdr != null && rdr.HasRows)
                    {
                        MessageBox.Show("Questo nome utente e` gia` in uso");
                        GestioneMySql.ChiudiConnessione();
                    }
                    else
                    {
                        GestioneMySql.ChiudiConnessione();
                        completeReg();

                        textBoxRegUtente.Text = "";
                        textBoxRegPassword.Text = "";
                        textBoxRegConfermaPassword.Text = "";
                        panelRegistrati.Visible = false;
                        panelRegistrati.Enabled = false;
                        panelLogin.Visible = true;
                        panelLogin.Enabled = true;
                    }

                }
                catch
                {
                    GestioneMySql.ChiudiConnessione();

                    textBoxRegUtente.Text = "";
                    textBoxRegPassword.Text = "";
                    textBoxRegConfermaPassword.Text = "";
                    panelRegistrati.Visible = false;
                    panelRegistrati.Enabled = false;
                    panelLogin.Visible = true;
                    panelLogin.Enabled = true;
                    MessageBox.Show("Errore di connessione, verifica di essere connesso alla rete");
                }
            }
            else
            {
                if (textBoxRegConfermaPassword.Text == " ")
                {
                    MessageBox.Show("Inserire o confermare la Password");
                }
                else
                {
                    MessageBox.Show("Le password non corrispondono");
                }
            }
        }

        private void buttonConfermaLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "SELECT IDUtente,NomeUtente,Password FROM mUsers WHERE NomeUtente='" + textBoxLoginUtente.Text + 
                           "' AND Password='" + textBoxLoginPassword.Text.Trim().GetHashCode() + "';";
                MySqlDataReader rdr = GestioneMySql.RequestQuery(sql);
                if (rdr != null && rdr.HasRows)
                {
                    rdr.Read();
                    
                    UserId = Int32.Parse(rdr[0].ToString());
                    
                    buttonConfermaLogin.Enabled = false;
                    buttonRegistrazione.Enabled = false;
                    MessageBox.Show("Login completato");
                    buttonConfermaLogin.Enabled = true;
                    buttonRegistrazione.Enabled = true;
                    panelLogin.Visible = false;
                    panelLogin.Enabled = false;
                    rdr.Close();
                    GestioneMySql.ChiudiConnessione();
                    checkDbCryptoSettings();
                    Invoke(new EventHandler(btnConnetti_Click));
                }
                else
                {
                    MessageBox.Show("Nome utente o password inesistenti");
                    GestioneMySql.ChiudiConnessione();
                }

            }
            catch
            {

                GestioneMySql.ChiudiConnessione();
                MessageBox.Show("Errore di connessione, verifica di essere connesso alla rete");
            }
        }

        private void btnConnetti_Click(object sender, EventArgs e)
        {
            if (cmbSerialPort.Text.Trim().Length == 0)
            {
                MessageBox.Show("Devi selezionare una porta", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbBaudRate.Text.Trim().Length == 0)
            {
                MessageBox.Show("Devi selezionare un Baud Rate", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            serialPort.PortName = cmbSerialPort.Text.Trim();
            cmbBaudRate.Text = "115200";
            serialPort.BaudRate = Convert.ToInt32(cmbBaudRate.Text.Trim());
            try
            {
                serialPort.Open();
            
                if (serialPort.IsOpen)
                {
                    btnDisconnetti.Enabled = true;
                    btnConnetti.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Nessuna scimmia collegata, controlla le impostazioni per riprovare");
                }
            }
            catch 
            {
                MessageBox.Show("Nessuna scimmia collegata, controlla le impostazioni per riprovare");
            }
        }

        private void btnDisconnetti_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                btnDisconnetti.Enabled = false;
                btnConnetti.Enabled = true;
            }
        }

        private void btnScrivi_Click(object sender, EventArgs e)
        {
            char apici = '"';
            
            textBoxFrase.Text.Trim();
           
            if (!textBoxFrase.Text.Contains(" ") && !textBoxFrase.Text.Contains("\r") && !textBoxFrase.Text.Contains("'") && !textBoxFrase.Text.Contains(apici) && !textBoxFrase.Text.Contains("\\"))
            {
                if (serialPort.IsOpen && textBoxFrase.Text.Length > 0 && textBoxFrase.Text != " ")
                {
                    serialPort.WriteLine(textBoxFrase.Text.Length.ToString());
                }
                else
                {
                    MessageBox.Show("Inserire un valore valido e verificare che la scimmia sia connessa");
                }
            }
            else 
            {
                MessageBox.Show("Non puoi inserire alcun spazio,apice,backslash o doppio apice");
            }

        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                arduinoOutput = serialPort.ReadLine().Trim(); 
                Invoke(new EventHandler(ArduinoRequestAndSaveToDB));
            }
            catch 
            {
                
            }
        }

        private void ArduinoRequestAndSaveToDB(object sender, EventArgs e)
        {

            if (arduinoOutput != null && arduinoOutput != "\0" && currentKey != null && comboBoxKey.Items.Count>0)
            {
                if (currentVigenereTb == null)
                {
                    CreateVigenereTable(phRow);
                }
                reverseTranspVal(comboBoxValTransp.Text);
                string cryptedString = CryptString(currentVigenereTb, currentKey, textBoxFrase.Text).ToString();
                string monkeyString = arduinoOutput;
                txtOutput.AppendText(arduinoOutput);
                try
                {
                    StringBuilder sql = new StringBuilder();
                    MySqlDataReader rdr = GestioneMySql.RequestQuery(
                    "SELECT IDKey " +
                    "FROM monkey.mkeys " +
                    "WHERE KeyLength=" + Int32.Parse(comboBoxKey.Text) +
                    " AND valTrasposizione='" + comboBoxValTransp.Text + "';"); 
                    rdr.Read();

                    int idKeySettings = Convert.ToInt32(rdr[0]);
                    sql.AppendLine("INSERT monkey.mstrings ");
                    sql.AppendLine(" (Key_ID,monkeyString,CryptoString) VALUES (");
                    sql.AppendLine(idKeySettings + ",'" + monkeyString + "','" + cryptedString + "')");
                    rdr.Close();
                    if (GestioneMySql.InsertValues(sql.ToString()))
                    {
                        MessageBox.Show("Dati inseriti con successo!");
                    }
                    else
                    {
                        MessageBox.Show("Errore nell'inserimento dati");
                    }
                }
                catch
                {
                    MessageBox.Show("Errore nella comunicazione, inserire una nuova frase");
                    GestioneMySql.ChiudiConnessione();
                }
            }
            else 
            {
                MessageBox.Show("Errore nella comunicazione, nessuna impostazione di criptazione selezionata");
            }
            buttonSendSaveDb.Enabled = true;
            comboBoxKey.Enabled = true;
            comboBoxValTransp.Enabled = true;
            buttonCreateNewCryptSetting.Enabled = true;
            buttonShowSettings.Enabled = true;
            labelFrase.Text = "Inserire una frase da criptare";
        }

        private void buttonSendSaveDb_Click(object sender, EventArgs e)
        {
            labelFrase.Text = "In attesa della scimmia...";
            buttonSendSaveDb.Enabled = false;
            buttonCreateNewCryptSetting.Enabled = false;
            comboBoxKey.Enabled = false;
            comboBoxValTransp.Enabled = false;
            buttonShowSettings.Enabled = false;
            currentKey = comboBoxKey.Text;
            Invoke(new EventHandler(btnScrivi_Click));
        }

        private void buttonConfirmCryptoSettings_Click(object sender, EventArgs e)
        {
            if (!textBoxNewKey.Text.Contains(" "))
            {
                try
                {
                    int c = 0;
                    currentKey = textBoxNewKey.Text.Trim();
                    findTranspVal();
                    string ValoriTransposizione = "";
                    ValoriTransposizione = transpVal[c].ToString();
                    c++;
                    while (c < transpVal.Length)
                    {
                        ValoriTransposizione = ValoriTransposizione + ' ';
                        ValoriTransposizione = ValoriTransposizione + transpVal[c].ToString();
                        c++;
                    }

                    string sqlCheck =
                        "SELECT Utente_ID,KeyLength,valTrasposizione " +
                        "FROM monkey.mKeys " +
                        "WHERE KeyLength=" + currentKey.Length +
                        " AND valTrasposizione='" + ValoriTransposizione + 
                        "'AND Utente_ID="+ UserId +
                        ";";

                    MySqlDataReader rdr = GestioneMySql.RequestQuery(sqlCheck);

                    if (rdr != null && rdr.HasRows == true) 
                    {
                        MessageBox.Show("Questa impostazione esiste gia`!");
                        rdr.Close();
                        GestioneMySql.ChiudiConnessione();
                    }
                    else
                    {
                        rdr.Close();
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("INSERT monkey.mkeys "); 
                        sql.AppendLine(" (Utente_ID,KeyLength,valTrasposizione) VALUES ("+ UserId +","+ currentKey.Length);
                        sql.AppendLine(",'" + ValoriTransposizione + "')");
                        if (GestioneMySql.InsertValues(sql.ToString()))
                        {
                            MessageBox.Show("Impostazioni create con successo");
                        }
                        else
                        {
                            MessageBox.Show("Errore logico nella creazione delle impostazioni");
                        }
                        checkDbCryptoSettings();
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show("Errore nella creazione delle impostazioni: " + f);
                    GestioneMySql.ChiudiConnessione();
                }
            }
            else 
            {
                MessageBox.Show("Errore non e` possibile inserire spazi nella chiave");
            }
        }

        /*//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/
        private void comboBoxKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBoxValTransp.SelectedIndex = comboBoxKey.SelectedIndex;
            
        }

        private void comboBoxValTransp_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKey.SelectedIndex = comboBoxValTransp.SelectedIndex;

        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            currentKey = "4";
            reverseTranspVal(comboBoxValTransp.Text);
          //  phRow = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
         //   findTranspVal();
           // CreateVigenereTable(phRow);
           // char[] prova = CryptString(currentVigenereTb, "VERME", "ARRIVANOIRINFORZI");
            // createTableSourceFile(PhTable);
        } // TOGLIERE QUESTA COSA PRIMA DI SALVARE TUTTO

        private void buttonShowSettings_Click(object sender, EventArgs e)
        {
            buttonShowSettings.Visible = false;
            panelSettings.Visible = true;
            panelSettings.Enabled = true;
        }

        private void buttonHideSettingsUI_Click(object sender, EventArgs e)
        {
            buttonShowSettings.Visible = true;
            panelSettings.Visible = false;
            panelSettings.Enabled = false;
        }

        
        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            textBoxRegUtente.Text = "";
            textBoxRegPassword.Text = "";
            textBoxRegConfermaPassword.Text = "";
            panelRegistrati.Visible = false;
            panelRegistrati.Enabled = false;
            panelLogin.Visible = true;
            panelLogin.Enabled = true;
        }

        
        
        private void buttonRegistrazione_Click(object sender, EventArgs e)
        {

            textBoxLoginUtente.Text = "";
            textBoxLoginPassword.Text = "";
            

            panelRegistrati.Visible = true;
            panelRegistrati.Enabled = true;
            panelLogin.Visible = false;
            panelLogin.Enabled = false;
        }

        

        private void buttonCreateNewCryptSetting_Click(object sender, EventArgs e)
        {
            panelNewCryptoSettings.Visible = true;

        }

        private void buttonDiscardNewCryptoSettings_Click(object sender, EventArgs e)
        {
            panelNewCryptoSettings.Visible = false;
        }

       
        private void comboBoxValTransp_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void comboBoxValTransp_MouseEnter(object sender, EventArgs e)
        {
            if (comboBoxKey.Items.Count > 0)
            {
                reverseTranspVal(comboBoxValTransp.Text);
                textBoxValK.Text = currentKey;
            }
        }

        private void textBoxValK_MouseEnter(object sender, EventArgs e)
        {
            if (comboBoxKey.Items.Count > 0)
            {
                reverseTranspVal(comboBoxValTransp.Text);
                textBoxValK.Text = currentKey;
            }
        }
    }
}


/* 
 string sql = "SELECT IDrilevazione,statoLuce,Data FROM controlloluce WHERE Data>='" + mese.ToString()+"' AND Data<='"+mese.Year.ToString()+"-"+ mese.Month.ToString()+"-"+ DateTime.DaysInMonth(mese.Year,mese.Month)+" "+"23:59:59'" +";";
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

while (rdr.Read())
                {lastcock = rdr[1].ToString();

 */