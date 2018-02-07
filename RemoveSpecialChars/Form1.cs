using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace RemoveSpecialChars
{
    public partial class Form1 : Form
    {
        int gbLoadPreviousHeight = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lRemoveChars_Click(object sender, EventArgs e)
        {

        }

        private void lOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            String newValue = "";

            //Check if we have typed in data
            if (tbxOG.Text != "")
            {
                newValue = tbxOG.Text;
            }
            //checked if we have a file path
            else if (tbxFilePathSource.Text != "")
            {
                newValue = System.IO.File.ReadAllText(tbxFilePathSource.Text);
            }

            if (newValue != "")
            {
                //Remove characters
                if (cbxNewLine.Checked)
                {
                    newValue = newValue.Replace("\n", "");
                }
                if (cbxTab.Checked)
                {
                    newValue = newValue.Replace("\t", "");
                }
                if (cbxCarriageReturn.Checked)
                {
                    newValue = newValue.Replace("\r", "");
                }
                if (cbxEmptySpace.Checked)
                {
                    newValue = newValue.Replace(" ", "");
                }

                if (cbxRemoveSpecificChars.Checked)
                {
                    removeBetweenSpecificChars(ref newValue);
                }


                //Add characters
                //Add '\n' after specified end tag
                if (cbxEndTag.Checked)
                {
                    int current = 0;
                    while ((current = newValue.IndexOf(txbEndTag.Text, current)) != -1)
                    {
                        newValue = newValue.Insert(current, "\n");
                        current = (current + txbEndTag.TextLength);
                    }
                }

                // Add '\'
                if (cbxAddforwardSlash.Checked)
                {
                    string tmp = "";
                    foreach (char character in newValue)
                    {
                        if (character == '"')
                        {

                            tmp = tmp.Insert(tmp.Length, "\\");
                        }
                        tmp += character;
                    }
                    newValue = tmp;
                }

                //Add ' ' '
                if (cbxApostrophe.Checked)
                {
                    string tmp = "";
                    foreach (char character in newValue)
                    {
                        if (character == '\'')
                        {

                            tmp = tmp.Insert(tmp.Length, "'");
                        }
                        tmp += character;
                    }
                    newValue = tmp;
                }

                tbxOutput.Text = newValue;

                if (tbxFilePathOutput.Text != "")
                {
                    writeToFile();
                }
            }
        }

        private void removeBetweenSpecificChars(ref string data)
        {
            bool found = false;
            int index = 0;
            foreach (char start in data)
            {
                if ((start == ' ') && (!found))
                {

                    data = data.Remove(index, 1);
                    continue;
                }

                if (start == tbxSpecificchar.Text[0])
                {
                    if (!found)
                        found = true;
                    else
                        found = false;
                }
                ++index;
            }
        }


        private void writeToFile()
        {
            // Write the stream contents to a new file named "AllTxtFiles.txt".
            using (StreamWriter outfile = new StreamWriter(tbxFilePathOutput.Text))
            {
                outfile.Write(tbxOutput.Text.ToString());
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxFilePathSource.Text = openFileDialog1.FileName;

                //Set as default
                //Get format
                String format = Path.GetExtension(openFileDialog1.FileName);

                //Remove format
                openFileDialog1.FileName = openFileDialog1.FileName.Remove((openFileDialog1.FileName.Length - format.Length), format.Length);

                //Change name
                openFileDialog1.FileName = openFileDialog1.FileName + "_2";

                //Add format back
                openFileDialog1.FileName = openFileDialog1.FileName + format;


                tbxFilePathOutput.Text = openFileDialog1.FileName;
            }


        }

        private void btnSetOutput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxFilePathOutput.Text = openFileDialog1.FileName;
            }

        }

        private void cbxRemoveSpecificChars_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxOG.Text = "";
            tbxOutput.Text = "";
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbxOutput.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbxOG_TextChanged(object sender, EventArgs e)
        {

        }

        private void txboxBase64_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            String filePath = fileList[0].ToString();

            Thread newThread = new Thread(toBase64String);
            newThread.Start(filePath);
        }

        public void toBase64String(object filePath)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                if (InvokeRequired)
                {
                    this.Invoke(new Action<string>(toBase64String), new object[] { filePath });
                    return;
                }

                if (((String)filePath).Length > 0)
                {
                    Image image = Image.FromFile(((String)filePath).ToString());

                    // Convert Image to byte[]
                    image.Save(ms, image.RawFormat);
                    byte[] imageBytes = ms.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    txboxBase64.Text = base64String;
                }
            }
        }

        private void txboxBase64_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txboxBase64_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
                e.Handled = true;
            }
        }

        private void loadFileMinimise_Click(object sender, EventArgs e)
        {
            int temp = gbxLoadData.Height;

            gbxLoadData.Height = (gbxLoadData.Height != loadFileMinimise.Height) ? loadFileMinimise.Height : gbLoadPreviousHeight;

            gbLoadPreviousHeight = temp;

            loadFileMinimise.Text = loadFileMinimise.Text.Equals("+") ? "-" : "+";
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                cbxNewLine.Checked = true;
                cbxCarriageReturn.Checked = true;
                cbxTab.Checked = true;
                cbxEmptySpace.Checked = false;
                tbxSpecificchar.Text = "\"";
                cbxRemoveSpecificChars.Checked = true;
                cbxApostrophe.Checked = true;
            }
            else
            {
                cbxNewLine.Checked = false;
                cbxCarriageReturn.Checked = false;
                cbxTab.Checked = false;
                cbxEmptySpace.Checked = false;
                tbxSpecificchar.Text = "";
                cbxRemoveSpecificChars.Checked = false;
                cbxApostrophe.Checked = false;
            }

        }
    }
}
