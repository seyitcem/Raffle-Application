using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raffle_App
{
    public partial class Results_Form : Form
    {
        List<object> results = new List<object>();
        public Results_Form(List<object> results)
        {
            this.results = results;
            InitializeComponent();
            for(int i = 0; i < results.Count; i++)
            {
                Results_DataGridView.Rows.Add();
                Results_DataGridView.Rows[i].Cells["Raffle_Name"].Value = ((string[])results[i])[0].ToString();
                Results_DataGridView.Rows[i].Cells["Winner"].Value = ((string[])results[i])[1].ToString();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Results_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
