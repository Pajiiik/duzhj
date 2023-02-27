using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace idk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog otevirac = new OpenFileDialog();
            otevirac.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            if (otevirac.ShowDialog() == DialogResult.OK)
            {
                ListBox listboxik = new ListBox();
                listboxik.Width = 120;
                listboxik.Height = 120;
                listboxik.Location = new Point(10,10);
                listboxik.Enabled = true;
                listboxik.Visible = true;
                this.Controls.Add(listboxik);
                using (StreamReader ctenar = new StreamReader(otevirac.FileName))
                {
                    while (!ctenar.EndOfStream)
                    {
                        listboxik.Items.Add(ctenar.ReadLine());
                    }
                }
            }
        }
    }
}
