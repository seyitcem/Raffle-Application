using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Raffle_App.Program;
namespace Raffle_App
{
    public partial class Home : Form
    {
        public bool raffling = false;
        public List<string> list = new List<string>();
        public List<object> results = new List<object>();
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
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

        private async void RaffleThread()
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                if (Result.InvokeRequired)
                {
                    Result.Invoke(new MethodInvoker(delegate
                    {
                        Result.ForeColor = Color.Red;
                        Result.Text = list[random.Next(0, list.Count)];
                    }));
                }
                await Task.Delay(120);
            }
            Result.ForeColor = Color.Lime;
            raffling = false;
            results.Add(new string[] { RaffleName_Textbox.Text, Result.Text });
        }
        private void AddParticipant_Button_Click(object sender, EventArgs e)
        {
            if (raffling)
            {
                return;
            }
            Participants_Form participants_Form = new Participants_Form(list);
            participants_Form.ShowDialog();
            if(list == null)
            {
                return;
            }
            Participants_DataGridView.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != "")
                {
                    Participants_DataGridView.Rows.Add(list[i]);
                }
            }
        }

        private void Raffle_Button_Click(object sender, EventArgs e)
        {
            if (raffling)
            {
                return;
            }
            if(RaffleName_Textbox.Text == "")
            {
                return;
            }
            if(list.Count == 0)
            {
                return;
            }
            raffling = true;
            Thread t = new Thread(new ThreadStart(RaffleThread));
            t.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Results_Button_Click(object sender, EventArgs e)
        {
            if (raffling)
            {
                return;
            }
            Results_Form results_Form = new Results_Form(results);
            results_Form.ShowDialog();
        }
    }
}
