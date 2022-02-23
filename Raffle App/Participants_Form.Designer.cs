namespace Raffle_App
{
    partial class Participants_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddParticipant_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteParticipant_Button = new System.Windows.Forms.Button();
            this.Participants_DataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Participants_Names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Participants_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddParticipant_Button
            // 
            this.AddParticipant_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.AddParticipant_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddParticipant_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddParticipant_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddParticipant_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddParticipant_Button.Location = new System.Drawing.Point(20, 463);
            this.AddParticipant_Button.Name = "AddParticipant_Button";
            this.AddParticipant_Button.Size = new System.Drawing.Size(200, 51);
            this.AddParticipant_Button.TabIndex = 30;
            this.AddParticipant_Button.Text = "Add Participant";
            this.AddParticipant_Button.UseVisualStyleBackColor = false;
            this.AddParticipant_Button.Click += new System.EventHandler(this.AddParticipant_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 48);
            this.label1.TabIndex = 35;
            this.label1.Text = "Participant Names";
            // 
            // DeleteParticipant_Button
            // 
            this.DeleteParticipant_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.DeleteParticipant_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteParticipant_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteParticipant_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteParticipant_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteParticipant_Button.Location = new System.Drawing.Point(250, 463);
            this.DeleteParticipant_Button.Name = "DeleteParticipant_Button";
            this.DeleteParticipant_Button.Size = new System.Drawing.Size(212, 51);
            this.DeleteParticipant_Button.TabIndex = 36;
            this.DeleteParticipant_Button.Text = "Delete Participant";
            this.DeleteParticipant_Button.UseVisualStyleBackColor = false;
            this.DeleteParticipant_Button.Click += new System.EventHandler(this.DeleteParticipant_Button_Click);
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
            this.Participants_DataGridView.Location = new System.Drawing.Point(20, 60);
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
            this.Participants_DataGridView.Size = new System.Drawing.Size(442, 397);
            this.Participants_DataGridView.TabIndex = 37;
            this.Participants_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Participants_DataGridView_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Raffle_App.Properties.Resources.x_white;
            this.pictureBox1.Location = new System.Drawing.Point(414, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Participants_Names
            // 
            this.Participants_Names.HeaderText = "Participants";
            this.Participants_Names.MinimumWidth = 6;
            this.Participants_Names.Name = "Participants_Names";
            this.Participants_Names.ReadOnly = true;
            this.Participants_Names.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Participants_Names.Width = 440;
            // 
            // Participants_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(483, 526);
            this.Controls.Add(this.Participants_DataGridView);
            this.Controls.Add(this.DeleteParticipant_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddParticipant_Button);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Participants_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AddParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Participants_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddParticipant_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteParticipant_Button;
        private System.Windows.Forms.DataGridView Participants_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Participants_Names;
    }
}