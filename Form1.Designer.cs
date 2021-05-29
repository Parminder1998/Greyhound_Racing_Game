
namespace Greyhound_Racing_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLockIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBettor = new System.Windows.Forms.Label();
            this.lblJashan = new System.Windows.Forms.Label();
            this.lblJaskaran = new System.Windows.Forms.Label();
            this.lblParminder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.udBoxDog = new System.Windows.Forms.NumericUpDown();
            this.udBoxBet = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.rbJashan = new System.Windows.Forms.RadioButton();
            this.rbJaskaran = new System.Windows.Forms.RadioButton();
            this.rbParmindeer = new System.Windows.Forms.RadioButton();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbDog4 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbRaceTrack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLockIn
            // 
            this.btnLockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLockIn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLockIn.Location = new System.Drawing.Point(559, 521);
            this.btnLockIn.Name = "btnLockIn";
            this.btnLockIn.Size = new System.Drawing.Size(176, 57);
            this.btnLockIn.TabIndex = 48;
            this.btnLockIn.Text = "Confirm Bet";
            this.btnLockIn.UseVisualStyleBackColor = false;
            this.btnLockIn.Click += new System.EventHandler(this.btnLockIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Bettor:";
            // 
            // lblBettor
            // 
            this.lblBettor.AutoSize = true;
            this.lblBettor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBettor.Location = new System.Drawing.Point(44, 332);
            this.lblBettor.Name = "lblBettor";
            this.lblBettor.Size = new System.Drawing.Size(50, 19);
            this.lblBettor.TabIndex = 46;
            this.lblBettor.Text = "label4";
            // 
            // lblJashan
            // 
            this.lblJashan.Location = new System.Drawing.Point(527, 457);
            this.lblJashan.Name = "lblJashan";
            this.lblJashan.Size = new System.Drawing.Size(407, 28);
            this.lblJashan.TabIndex = 45;
            this.lblJashan.Text = "label6";
            // 
            // lblJaskaran
            // 
            this.lblJaskaran.Location = new System.Drawing.Point(527, 424);
            this.lblJaskaran.Name = "lblJaskaran";
            this.lblJaskaran.Size = new System.Drawing.Size(407, 28);
            this.lblJaskaran.TabIndex = 44;
            this.lblJaskaran.Text = "label5";
            // 
            // lblParminder
            // 
            this.lblParminder.Location = new System.Drawing.Point(527, 394);
            this.lblParminder.Name = "lblParminder";
            this.lblParminder.Size = new System.Drawing.Size(407, 28);
            this.lblParminder.TabIndex = 43;
            this.lblParminder.Text = "label4";
            this.lblParminder.Click += new System.EventHandler(this.lblParminder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Bettor Name:     Cash Available:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Dog  #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Bet  $";
            // 
            // btnRace
            // 
            this.btnRace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRace.Enabled = false;
            this.btnRace.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.ForeColor = System.Drawing.Color.White;
            this.btnRace.Location = new System.Drawing.Point(784, 520);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(171, 58);
            this.btnRace.TabIndex = 34;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = false;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // udBoxDog
            // 
            this.udBoxDog.Location = new System.Drawing.Point(219, 579);
            this.udBoxDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udBoxDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udBoxDog.Name = "udBoxDog";
            this.udBoxDog.Size = new System.Drawing.Size(75, 25);
            this.udBoxDog.TabIndex = 33;
            this.udBoxDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udBoxBet
            // 
            this.udBoxBet.Location = new System.Drawing.Point(219, 511);
            this.udBoxBet.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udBoxBet.Name = "udBoxBet";
            this.udBoxBet.Size = new System.Drawing.Size(75, 25);
            this.udBoxBet.TabIndex = 32;
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBet.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBet.Location = new System.Drawing.Point(327, 521);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(176, 57);
            this.btnBet.TabIndex = 31;
            this.btnBet.Text = "Place Bet!";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // rbJashan
            // 
            this.rbJashan.AutoSize = true;
            this.rbJashan.Location = new System.Drawing.Point(141, 457);
            this.rbJashan.Name = "rbJashan";
            this.rbJashan.Size = new System.Drawing.Size(71, 23);
            this.rbJashan.TabIndex = 30;
            this.rbJashan.TabStop = true;
            this.rbJashan.Text = "Jashan";
            this.rbJashan.UseVisualStyleBackColor = true;
            this.rbJashan.CheckedChanged += new System.EventHandler(this.rbJashan_CheckedChanged);
            // 
            // rbJaskaran
            // 
            this.rbJaskaran.AutoSize = true;
            this.rbJaskaran.Location = new System.Drawing.Point(141, 424);
            this.rbJaskaran.Name = "rbJaskaran";
            this.rbJaskaran.Size = new System.Drawing.Size(85, 23);
            this.rbJaskaran.TabIndex = 29;
            this.rbJaskaran.TabStop = true;
            this.rbJaskaran.Text = "Jaskaran";
            this.rbJaskaran.UseVisualStyleBackColor = true;
            this.rbJaskaran.CheckedChanged += new System.EventHandler(this.rbJaskaran_CheckedChanged);
            // 
            // rbParmindeer
            // 
            this.rbParmindeer.AutoSize = true;
            this.rbParmindeer.Location = new System.Drawing.Point(141, 392);
            this.rbParmindeer.Name = "rbParmindeer";
            this.rbParmindeer.Size = new System.Drawing.Size(98, 23);
            this.rbParmindeer.TabIndex = 28;
            this.rbParmindeer.TabStop = true;
            this.rbParmindeer.Text = "Parminder";
            this.rbParmindeer.UseVisualStyleBackColor = true;
            this.rbParmindeer.CheckedChanged += new System.EventHandler(this.rbParmindeer_CheckedChanged);
            // 
            // pbDog1
            // 
            this.pbDog1.BackColor = System.Drawing.Color.Transparent;
            this.pbDog1.Image = global::Greyhound_Racing_Game.Properties.Resources.puppy1;
            this.pbDog1.Location = new System.Drawing.Point(109, 12);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(81, 55);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog1.TabIndex = 38;
            this.pbDog1.TabStop = false;
            // 
            // pbDog4
            // 
            this.pbDog4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbDog4.Image = global::Greyhound_Racing_Game.Properties.Resources.puppy4;
            this.pbDog4.Location = new System.Drawing.Point(109, 257);
            this.pbDog4.Name = "pbDog4";
            this.pbDog4.Size = new System.Drawing.Size(81, 52);
            this.pbDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog4.TabIndex = 41;
            this.pbDog4.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbDog3.Image = global::Greyhound_Racing_Game.Properties.Resources.puppy3;
            this.pbDog3.Location = new System.Drawing.Point(109, 172);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(81, 54);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog3.TabIndex = 40;
            this.pbDog3.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbDog2.Image = global::Greyhound_Racing_Game.Properties.Resources.puppy2;
            this.pbDog2.Location = new System.Drawing.Point(109, 92);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(81, 51);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDog2.TabIndex = 39;
            this.pbDog2.TabStop = false;
            // 
            // pbRaceTrack
            // 
            this.pbRaceTrack.BackColor = System.Drawing.Color.DarkRed;
            this.pbRaceTrack.Image = global::Greyhound_Racing_Game.Properties.Resources.bg1;
            this.pbRaceTrack.Location = new System.Drawing.Point(100, 0);
            this.pbRaceTrack.Name = "pbRaceTrack";
            this.pbRaceTrack.Size = new System.Drawing.Size(924, 329);
            this.pbRaceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRaceTrack.TabIndex = 42;
            this.pbRaceTrack.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.btnLockIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBettor);
            this.Controls.Add(this.lblJashan);
            this.Controls.Add(this.lblJaskaran);
            this.Controls.Add(this.lblParminder);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbDog4);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.udBoxDog);
            this.Controls.Add(this.udBoxBet);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.rbJashan);
            this.Controls.Add(this.rbJaskaran);
            this.Controls.Add(this.rbParmindeer);
            this.Controls.Add(this.pbRaceTrack);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udBoxDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoxBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRaceTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLockIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBettor;
        private System.Windows.Forms.Label lblJashan;
        private System.Windows.Forms.Label lblJaskaran;
        private System.Windows.Forms.Label lblParminder;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog4;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.NumericUpDown udBoxDog;
        private System.Windows.Forms.NumericUpDown udBoxBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.RadioButton rbJashan;
        private System.Windows.Forms.RadioButton rbJaskaran;
        private System.Windows.Forms.RadioButton rbParmindeer;
        private System.Windows.Forms.PictureBox pbRaceTrack;
    }
}

