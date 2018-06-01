namespace Voting_System_Overlay
{
    partial class Form2
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.f2_vote1 = new System.Windows.Forms.Label();
            this.f2_vote3 = new System.Windows.Forms.Label();
            this.f2_vote2 = new System.Windows.Forms.Label();
            this.picoboxPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picoboxPB)).BeginInit();
            this.SuspendLayout();
            // 
            // f2_vote1
            // 
            this.f2_vote1.AutoSize = true;
            this.f2_vote1.BackColor = System.Drawing.SystemColors.Info;
            this.f2_vote1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2_vote1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2_vote1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f2_vote1.Location = new System.Drawing.Point(63, 15);
            this.f2_vote1.Name = "f2_vote1";
            this.f2_vote1.Size = new System.Drawing.Size(63, 21);
            this.f2_vote1.TabIndex = 0;
            this.f2_vote1.Text = "Vote #1";
            this.f2_vote1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f2_vote3
            // 
            this.f2_vote3.AutoSize = true;
            this.f2_vote3.BackColor = System.Drawing.SystemColors.Info;
            this.f2_vote3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2_vote3.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2_vote3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f2_vote3.Location = new System.Drawing.Point(276, 15);
            this.f2_vote3.Name = "f2_vote3";
            this.f2_vote3.Size = new System.Drawing.Size(66, 21);
            this.f2_vote3.TabIndex = 1;
            this.f2_vote3.Text = "Vote #3";
            this.f2_vote3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f2_vote2
            // 
            this.f2_vote2.AutoSize = true;
            this.f2_vote2.BackColor = System.Drawing.SystemColors.Info;
            this.f2_vote2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.f2_vote2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2_vote2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.f2_vote2.Location = new System.Drawing.Point(164, 15);
            this.f2_vote2.Name = "f2_vote2";
            this.f2_vote2.Size = new System.Drawing.Size(66, 21);
            this.f2_vote2.TabIndex = 2;
            this.f2_vote2.Text = "Vote #2";
            this.f2_vote2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picoboxPB
            // 
            this.picoboxPB.Location = new System.Drawing.Point(0, 44);
            this.picoboxPB.Name = "picoboxPB";
            this.picoboxPB.Size = new System.Drawing.Size(1920, 5);
            this.picoboxPB.TabIndex = 3;
            this.picoboxPB.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1920, 50);
            this.Controls.Add(this.picoboxPB);
            this.Controls.Add(this.f2_vote2);
            this.Controls.Add(this.f2_vote3);
            this.Controls.Add(this.f2_vote1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Greenscreen";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picoboxPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label f2_vote1;
        public System.Windows.Forms.Label f2_vote3;
        public System.Windows.Forms.Label f2_vote2;
        private System.Windows.Forms.PictureBox picoboxPB;
    }
}