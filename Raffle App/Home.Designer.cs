namespace Raffle_App
{
    partial class Home
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddParticipant_Button = new System.Windows.Forms.Button();
            this.Raffle_Button = new System.Windows.Forms.Button();
            this.RaffleName_Textbox = new System.Windows.Forms.TextBox();
            this.Participants_DataGridView = new System.Windows.Forms.DataGridView();
            this.Participants_Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.Label();
            this.Results_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Participants_DataGridView)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raffle Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Raffle Name:";
            // 
            // AddParticipant_Button
            // 
            this.AddParticipant_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.AddParticipant_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddParticipant_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddParticipant_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddParticipant_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddParticipant_Button.Location = new System.Drawing.Point(439, 417);
            this.AddParticipant_Button.Name = "AddParticipant_Button";
            this.AddParticipant_Button.Size = new System.Drawing.Size(189, 51);
            this.AddParticipant_Button.TabIndex = 29;
            this.AddParticipant_Button.Text = "Add Participant";
            this.AddParticipant_Button.UseVisualStyleBackColor = false;
            this.AddParticipant_Button.Click += new System.EventHandler(this.AddParticipant_Button_Click);
            // 
            // Raffle_Button
            // 
            this.Raffle_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Raffle_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Raffle_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Raffle_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Raffle_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Raffle_Button.Location = new System.Drawing.Point(20, 417);
            this.Raffle_Button.Name = "Raffle_Button";
            this.Raffle_Button.Size = new System.Drawing.Size(189, 51);
            this.Raffle_Button.TabIndex = 31;
            this.Raffle_Button.Text = "Raffle";
            this.Raffle_Button.UseVisualStyleBackColor = false;
            this.Raffle_Button.Click += new System.EventHandler(this.Raffle_Button_Click);
            // 
            // RaffleName_Textbox
            // 
            this.RaffleName_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.RaffleName_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RaffleName_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RaffleName_Textbox.ForeColor = System.Drawing.Color.White;
            this.RaffleName_Textbox.Location = new System.Drawing.Point(199, 101);
            this.RaffleName_Textbox.MaxLength = 32;
            this.RaffleName_Textbox.Name = "RaffleName_Textbox";
            this.RaffleName_Textbox.Size = new System.Drawing.Size(429, 36);
            this.RaffleName_Textbox.TabIndex = 32;
            // 
            // Participants_DataGridView
            // 
            this.Participants_DataGridView.AllowUserToAddRows = false;
            this.Participants_DataGridView.AllowUserToDeleteRows = false;
            this.Participants_DataGridView.AllowUserToResizeColumns = false;
            this.Participants_DataGridView.AllowUserToResizeRows = false;
            this.Participants_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Participants_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Participants_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Participants_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Participants_DataGridView.ColumnHeadersHeight = 35;
            this.Participants_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Participants_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Participants_Names});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Participants_DataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.Participants_DataGridView.EnableHeadersVisualStyles = false;
            this.Participants_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Participants_DataGridView.Location = new System.Drawing.Point(711, 71);
            this.Participants_DataGridView.MultiSelect = false;
            this.Participants_DataGridView.Name = "Participants_DataGridView";
            this.Participants_DataGridView.ReadOnly = true;
            this.Participants_DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Participants_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Participants_DataGridView.RowHeadersVisible = false;
            this.Participants_DataGridView.RowHeadersWidth = 30;
            this.Participants_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Participants_DataGridView.RowTemplate.Height = 30;
            this.Participants_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Participants_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Participants_DataGridView.Size = new System.Drawing.Size(303, 397);
            this.Participants_DataGridView.TabIndex = 34;
            this.Participants_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Orders_CellContentClick);
            // 
            // Participants_Names
            // 
            this.Participants_Names.HeaderText = "Participants";
            this.Participants_Names.MinimumWidth = 6;
            this.Participants_Names.Name = "Participants_Names";
            this.Participants_Names.ReadOnly = true;
            this.Participants_Names.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Participants_Names.Width = 300;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel8.Controls.Add(this.Result);
            this.panel8.Location = new System.Drawing.Point(20, 175);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(608, 227);
            this.panel8.TabIndex = 35;
            // 
            // Result
            // 
            this.Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Result.ForeColor = System.Drawing.Color.Lime;
            this.Result.Location = new System.Drawing.Point(20, 23);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(567, 182);
            this.Result.TabIndex = 0;
            this.Result.Text = "Result";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Results_Button
            // 
            this.Results_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Results_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Results_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Results_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Results_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Results_Button.Location = new System.Drawing.Point(231, 417);
            this.Results_Button.Name = "Results_Button";
            this.Results_Button.Size = new System.Drawing.Size(189, 51);
            this.Results_Button.TabIndex = 36;
            this.Results_Button.Text = "Results";
            this.Results_Button.UseVisualStyleBackColor = false;
            this.Results_Button.Click += new System.EventHandler(this.Results_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Raffle_App.Properties.Resources.x_white;
            this.pictureBox1.Location = new System.Drawing.Point(966, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1036, 506);
            this.Controls.Add(this.Results_Button);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.Participants_DataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RaffleName_Textbox);
            this.Controls.Add(this.Raffle_Button);
            this.Controls.Add(this.AddParticipant_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Participants_DataGridView)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddParticipant_Button;
        private System.Windows.Forms.Button Raffle_Button;
        private System.Windows.Forms.TextBox RaffleName_Textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Participants_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participants_Names;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Results_Button;
    }
}

