namespace Raffle_App
{
    partial class AddParticipant_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddParticipant_Button = new System.Windows.Forms.Button();
            this.Participants_TextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Raffle_App.Properties.Resources.x_white;
            this.pictureBox1.Location = new System.Drawing.Point(414, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 48);
            this.label1.TabIndex = 37;
            this.label1.Text = "Add Participants";
            // 
            // AddParticipant_Button
            // 
            this.AddParticipant_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.AddParticipant_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddParticipant_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddParticipant_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddParticipant_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddParticipant_Button.Location = new System.Drawing.Point(20, 471);
            this.AddParticipant_Button.Name = "AddParticipant_Button";
            this.AddParticipant_Button.Size = new System.Drawing.Size(442, 51);
            this.AddParticipant_Button.TabIndex = 38;
            this.AddParticipant_Button.Text = "Confirm";
            this.AddParticipant_Button.UseVisualStyleBackColor = false;
            this.AddParticipant_Button.Click += new System.EventHandler(this.AddParticipant_Button_Click);
            // 
            // Participants_TextBox
            // 
            this.Participants_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Participants_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Participants_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Participants_TextBox.ForeColor = System.Drawing.Color.White;
            this.Participants_TextBox.Location = new System.Drawing.Point(20, 68);
            this.Participants_TextBox.Name = "Participants_TextBox";
            this.Participants_TextBox.Size = new System.Drawing.Size(442, 397);
            this.Participants_TextBox.TabIndex = 39;
            this.Participants_TextBox.Text = "";
            // 
            // AddParticipant_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(481, 544);
            this.Controls.Add(this.Participants_TextBox);
            this.Controls.Add(this.AddParticipant_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddParticipant_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddParticipant_Form";
            this.Load += new System.EventHandler(this.AddParticipant_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddParticipant_Button;
        private System.Windows.Forms.RichTextBox Participants_TextBox;
    }
}