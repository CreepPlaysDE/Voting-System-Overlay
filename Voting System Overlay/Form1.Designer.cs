namespace Voting_System_Overlay
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_v1 = new System.Windows.Forms.TextBox();
            this.text_v2 = new System.Windows.Forms.TextBox();
            this.text_v3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_time = new System.Windows.Forms.NumericUpDown();
            this.b_start = new System.Windows.Forms.Button();
            this.b_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tB_time)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vote #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vote #2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vote #3";
            // 
            // text_v1
            // 
            this.text_v1.Location = new System.Drawing.Point(105, 34);
            this.text_v1.Name = "text_v1";
            this.text_v1.Size = new System.Drawing.Size(132, 20);
            this.text_v1.TabIndex = 3;
            // 
            // text_v2
            // 
            this.text_v2.Location = new System.Drawing.Point(105, 63);
            this.text_v2.Name = "text_v2";
            this.text_v2.Size = new System.Drawing.Size(132, 20);
            this.text_v2.TabIndex = 4;
            // 
            // text_v3
            // 
            this.text_v3.Location = new System.Drawing.Point(105, 92);
            this.text_v3.Name = "text_v3";
            this.text_v3.Size = new System.Drawing.Size(132, 20);
            this.text_v3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time [Minutes]";
            // 
            // tB_time
            // 
            this.tB_time.Location = new System.Drawing.Point(275, 33);
            this.tB_time.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.tB_time.Name = "tB_time";
            this.tB_time.Size = new System.Drawing.Size(45, 20);
            this.tB_time.TabIndex = 7;
            this.tB_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_start
            // 
            this.b_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_start.Location = new System.Drawing.Point(275, 90);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(75, 23);
            this.b_start.TabIndex = 8;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // b_stop
            // 
            this.b_stop.Enabled = false;
            this.b_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_stop.Location = new System.Drawing.Point(365, 90);
            this.b_stop.Name = "b_stop";
            this.b_stop.Size = new System.Drawing.Size(75, 23);
            this.b_stop.TabIndex = 9;
            this.b_stop.Text = "Stop";
            this.b_stop.UseVisualStyleBackColor = true;
            this.b_stop.Click += new System.EventHandler(this.b_stop_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(470, 152);
            this.Controls.Add(this.b_stop);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.tB_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_v3);
            this.Controls.Add(this.text_v2);
            this.Controls.Add(this.text_v1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Design";
            ((System.ComponentModel.ISupportInitialize)(this.tB_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_v1;
        private System.Windows.Forms.TextBox text_v2;
        private System.Windows.Forms.TextBox text_v3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tB_time;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Button b_stop;
    }
}

