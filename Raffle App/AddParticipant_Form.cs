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
    public partial class AddParticipant_Form : Form
    {
        public List<string> list;
        public AddParticipant_Form(List <string> list)
        {
            this.list = list;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddParticipant_Form_Load(object sender, EventArgs e)
        {

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

        private void AddParticipant_Button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Participants_TextBox.Lines.Length; i++)
            {
                if(Participants_TextBox.Lines[i] != "")
                {
                    list.Add(Participants_TextBox.Lines[i]);
                }
            }
            this.Close();
        }
    }
}
