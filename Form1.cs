using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultrawide_Cutscene_Fix
{
    public partial class Form1 : Form
    {
        string filename = "";
        byte[] fileBytes;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Select File Button
        {
            bool b = false;
            OpenFileDialog openfil = new OpenFileDialog();
            openfil.Title = "Select game exe file...";
            openfil.Filter = "EXE files|*.exe";
            openfil.InitialDirectory = @"C:\";

            if (openfil.ShowDialog() == DialogResult.OK)
            {
                filename = openfil.FileName;
                b = true;
            }

            if (b == true)
            {
                using (FileStream fs = File.OpenRead(filename))
                {
                    using (BinaryReader bin = new BinaryReader(fs))
                    {
                        fileBytes = bin.ReadBytes((int)fs.Length);
                    }
                }
                label1.Visible = true;
                listBox1.Visible = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) // Begin button
        {
            button1.Enabled = false;
            listBox1.Enabled = false;
            button2.Enabled = false;
            bool changes = false;
            string selectedListItem = listBox1.GetItemText(listBox1.SelectedItem);

            if (selectedListItem == "1024x768")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x00;
                                    fileBytes[j] = 0x04;
                                    fileBytes[k] = 0x00;
                                    fileBytes[L] = 0x03;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1152x864")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x80;
                                    fileBytes[j] = 0x04;
                                    fileBytes[k] = 0x60;
                                    fileBytes[L] = 0x03;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1280x720")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x00;
                                    fileBytes[j] = 0x05;
                                    fileBytes[k] = 0xD0;
                                    fileBytes[L] = 0x02;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1280x800")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x00;
                                    fileBytes[j] = 0x05;
                                    fileBytes[k] = 0x20;
                                    fileBytes[L] = 0x03;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1280x960")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x00;
                                    fileBytes[j] = 0x05;
                                    fileBytes[k] = 0xC0;
                                    fileBytes[L] = 0x03;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1280x1024")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x00;
                                    fileBytes[j] = 0x05;
                                    fileBytes[k] = 0x00;
                                    fileBytes[L] = 0x04;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1360x768")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x50;
                                    fileBytes[j] = 0x05;
                                    fileBytes[k] = 0x00;
                                    fileBytes[L] = 0x03;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1366x768")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x56;
                                    fileBytes[j] = 0x05;
                                    fileBytes[k] = 0x00;
                                    fileBytes[L] = 0x03;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1440x900")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0xA0;
                                    fileBytes[j] = 0x05;
                                    fileBytes[k] = 0x84;
                                    fileBytes[L] = 0x03;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1600x900")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x40;
                                    fileBytes[j] = 0x06;
                                    fileBytes[k] = 0x84;
                                    fileBytes[L] = 0x03;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1600x1200")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x40;
                                    fileBytes[j] = 0x06;
                                    fileBytes[k] = 0xB0;
                                    fileBytes[L] = 0x04;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1680x1050")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x90;
                                    fileBytes[j] = 0x06;
                                    fileBytes[k] = 0x1A;
                                    fileBytes[L] = 0x04;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1920x1080")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x80;
                                    fileBytes[j] = 0x07;
                                    fileBytes[k] = 0x38;
                                    fileBytes[L] = 0x04;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "1920x1200")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x80;
                                    fileBytes[j] = 0x07;
                                    fileBytes[k] = 0xB0;
                                    fileBytes[L] = 0x04;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "2560x1080")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x26;
                                    fileBytes[j] = 0xB4;
                                    fileBytes[k] = 0x17;
                                    fileBytes[L] = 0x40;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "2560x1440")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x00;
                                    fileBytes[j] = 0x0A;
                                    fileBytes[k] = 0xA0;
                                    fileBytes[L] = 0x05;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "3440x1440")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x8E;
                                    fileBytes[j] = 0xE3;
                                    fileBytes[k] = 0x18;
                                    fileBytes[L] = 0x40;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "3840x1600")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x9A;
                                    fileBytes[j] = 0x99;
                                    fileBytes[k] = 0x19;
                                    fileBytes[L] = 0x40;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "5120x2160")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x26;
                                    fileBytes[j] = 0xB4;
                                    fileBytes[k] = 0x17;
                                    fileBytes[L] = 0x40;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "6880x2880")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x8E;
                                    fileBytes[j] = 0xE3;
                                    fileBytes[k] = 0x18;
                                    fileBytes[L] = 0x40;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "3840x1080")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x39;
                                    fileBytes[j] = 0x8E;
                                    fileBytes[k] = 0x63;
                                    fileBytes[L] = 0x40;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "3840x1440")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0xAB;
                                    fileBytes[j] = 0xAA;
                                    fileBytes[k] = 0x2A;
                                    fileBytes[L] = 0x40;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "5120x1440")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0x39;
                                    fileBytes[j] = 0x8E;
                                    fileBytes[k] = 0x63;
                                    fileBytes[L] = 0x40;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }
            else if (selectedListItem == "3840x1200")
            {
                for (int i = 0; i < fileBytes.Length; i++)
                {
                    if (fileBytes[i] == 0x39)
                    {
                        int j = i + 1;

                        if (fileBytes[j] == 0x8E)
                        {
                            int k = j + 1;

                            if (fileBytes[k] == 0xE3)
                            {
                                int L = k + 1;

                                if (fileBytes[L] == 0x3F)
                                {
                                    fileBytes[i] = 0xCD;
                                    fileBytes[j] = 0xCC;
                                    fileBytes[k] = 0x4C;
                                    fileBytes[L] = 0x40;
                                    changes = true;
                                }
                            }
                        }
                    }
                }
            }

            if (changes == true)
            {
                File.Copy(filename, filename + " - Copy.exe");
                File.WriteAllBytes(filename, fileBytes);
                MessageBox.Show("Completed! Changes were found and made.");
            }
            else if (changes == false)
            {
                MessageBox.Show("Completed! No changes were made.");
            }
        }
    }
}
