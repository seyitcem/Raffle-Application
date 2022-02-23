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
    public partial class Participants_Form : Form
    {
        List<string> list;
        public Participants_Form(List<string> list)
        {
            this.list = list;
            InitializeComponent();
        }

        private void AddParticipant_Load(object sender, EventArgs e)
        {
            if(list == null)
            {
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != "")
                {
                    Participants_DataGridView.Rows.Add(list[i]);
                }
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

        private void AddParticipant_Button_Click(object sender, EventArgs e)
        {
            AddParticipant_Form addParticipant = new AddParticipant_Form(list);
            addParticipant.ShowDialog();
            Participants_DataGridView.Rows.Clear();
            for(int i = 0; i < list.Count; i++)
            {
                Participants_DataGridView.Rows.Add(list[i]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Participants_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteParticipant_Button_Click(object sender, EventArgs e)
        {
            if(list == null || list.Count == 0)
            {
                return;
            }
            list.RemoveAt(Participants_DataGridView.SelectedRows[0].Index);
            Participants_DataGridView.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Participants_DataGridView.Rows.Add(list[i]);
            }
        }
    }
}
