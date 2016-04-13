using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SQFEncrypt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //Global vars 
        public static class GlobVars
        {
            public static string inputFile { get; set; }
            public static int encryptNum { get; set; }
            public static string pVarName { get; set; }
            public static string fileRead { get; set; }
            public static string asciiStr { get; set; }
        }

        //Browse Btn
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "SQF Files(.sqf) | *.sqf";
            fileDialog.FilterIndex = 1;
            fileDialog.Multiselect = false;
            DialogResult result = fileDialog.ShowDialog();

            //Only try to open the file if the user selected a file and clicked ok to prevent System.IO exception
            if (result == DialogResult.OK)
            {
                outputBox.Text = "";
                String fileName = fileDialog.FileName;
                GlobVars.inputFile = fileName;
                FileInputBox.Text = fileName;
                openFile(fileName);
            }
        }

        //Encrypt Btn
        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(FileInputBox.Text)))
            {
                byte[] ascii = Encoding.ASCII.GetBytes(GlobVars.fileRead);
                int asciiCount = Encoding.ASCII.GetByteCount(GlobVars.fileRead);
                int count = 0;
                GlobVars.asciiStr = "";
                foreach (byte b in System.Text.Encoding.UTF8.GetBytes(GlobVars.fileRead.ToCharArray()))
                {
                    if (!(string.IsNullOrWhiteSpace(EncryptNumBox.Text)))
                    {
                        int numPlus = GlobVars.encryptNum + b;
                        GlobVars.asciiStr = GlobVars.asciiStr + numPlus;
                        if (count < asciiCount - 1)
                        {
                            GlobVars.asciiStr = GlobVars.asciiStr + ",";
                        }
                    }
                    else
                    {
                        GlobVars.asciiStr = GlobVars.asciiStr + b.ToString();
                        if (count < asciiCount - 1)
                        {
                            GlobVars.asciiStr = GlobVars.asciiStr + ",";
                        }
                    }
                    count = count + 1;
                }
                GlobVars.asciiStr = "_code = [" + GlobVars.asciiStr + "];";
                outputBox.Text = GlobVars.asciiStr;
            }
            else
            {
                MessageBox.Show("Yeah... \nIt Might help if you had a file loaded!", "You Went full Retard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (CopyToClipboardCheck.Checked)
            {
                Clipboard.SetText(GlobVars.asciiStr);
            }
        }

        //Generate Pvar Btn
        private void GeneratePVarbtn_Click(object sender, EventArgs e)
        {
            //make sure that the pvar name and encryptNum !Null
            if (!(string.IsNullOrWhiteSpace(EncryptNumBox.Text) || string.IsNullOrWhiteSpace(PvarNameBox.Text)))
            {
                string pVarName = PvarNameBox.Text;
                int pVarVale = GlobVars.encryptNum;
                Clipboard.SetText(pVarName + " = " + pVarVale + ";\npublicVariable " + "''" + pVarName + "'';");
                MessageBox.Show("Public Variable Code has been coppied to your clipboard", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Either your Encrypt Number or PublicVariableName is blank", "Pleb.exe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Generate to string Btn
        private void GenToStringBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PvarNameBox.Text))
            {
                string toString = "";
                toString = toString + "_codeToRun = [];\n{\n";
                toString = toString + "_num = _x - " + GlobVars.pVarName + ";\n";
                toString = toString + "} forEach _code;\n";
                toString = toString + "call compile toString _codeToRun;";
                Clipboard.SetText(toString);
                MessageBox.Show("toString Code has been coppied to your clipboard", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You Need to set a public Variable name first", "You Went Full Retard", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void openFile(string fileName)
        {
            bool delNextLine = false;
            string curLine;

            System.IO.StreamReader file = new StreamReader(fileName);
            while ((curLine = file.ReadLine()) != null)
            {
                if (stripComments.Checked)
                {
                    if (delNextLine == false)
                    {
                        if (curLine.Contains("/*"))
                        {
                            delNextLine = true;
                        }
                        else
                        {
                            if (!curLine.Contains("//"))
                            {
                                outputBox.AppendText("\n" + curLine);
                                GlobVars.fileRead = GlobVars.fileRead + curLine;
                            }
                        }
                    }
                    else
                    {
                        if (curLine.StartsWith("*/"))
                        {
                            delNextLine = false;
                        }
                    }
                }
                else
                {
                    outputBox.AppendText("\n" + curLine);
                    GlobVars.fileRead = GlobVars.fileRead + curLine;
                }
            }
        }

        private void EncryptNumBox_TextChanged(object sender, EventArgs e)
        {
            //Throw an error if user is dumb enough to enter a char 
            if (System.Text.RegularExpressions.Regex.IsMatch(EncryptNumBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Its called Encrypt Number. \nEnter a number you pleb not a char.", "You went full Retard", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EncryptNumBox.Text = EncryptNumBox.Text.Substring(0, EncryptNumBox.Text.Length - 1);
                EncryptNumBox.SelectionStart = EncryptNumBox.Text.Length;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(EncryptNumBox.Text))
                {
                    string EncryptNumS = EncryptNumBox.Text;
                    int EncryptNum = int.Parse(EncryptNumS);
                    GlobVars.encryptNum = EncryptNum;
                }
            }
        }

        private void PvarNameBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PvarNameBox.Text))
            {
                GlobVars.pVarName = PvarNameBox.Text;
            }
            if ((PvarNameBox.Text.ToLower().Contains("gr8") || PvarNameBox.Text.ToLower().Contains("gg")))
            {
                MessageBox.Show("Fuck off Gr8 this is to stop people like you from stealing", "TWAT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void FileInputBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FileInputBox.Text))
            {
                GlobVars.inputFile = FileInputBox.Text;
            }
        }
    }
}
