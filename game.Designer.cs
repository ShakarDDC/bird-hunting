
namespace bird
{
    partial class game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_missed = new System.Windows.Forms.Label();
            this.easy_btn = new System.Windows.Forms.RadioButton();
            this.meduim_btn = new System.Windows.Forms.RadioButton();
            this.hard_btn = new System.Windows.Forms.RadioButton();
            this.lbl_kill = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.p_2 = new System.Windows.Forms.PictureBox();
            this.p_3 = new System.Windows.Forms.PictureBox();
            this.p_1 = new System.Windows.Forms.PictureBox();
            this.lbl_over = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.p_5 = new System.Windows.Forms.PictureBox();
            this.p_6 = new System.Windows.Forms.PictureBox();
            this.p_4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.seconds);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_missed);
            this.panel1.Controls.Add(this.easy_btn);
            this.panel1.Controls.Add(this.meduim_btn);
            this.panel1.Controls.Add(this.hard_btn);
            this.panel1.Controls.Add(this.lbl_kill);
            this.panel1.Controls.Add(this.start_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 43);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.seconds.Location = new System.Drawing.Point(1158, 14);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(117, 25);
            this.seconds.TabIndex = 10;
            this.seconds.Text = " 0 seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "rc_0 group";
            // 
            // lbl_missed
            // 
            this.lbl_missed.AutoSize = true;
            this.lbl_missed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_missed.Location = new System.Drawing.Point(971, 15);
            this.lbl_missed.Name = "lbl_missed";
            this.lbl_missed.Size = new System.Drawing.Size(111, 25);
            this.lbl_missed.TabIndex = 8;
            this.lbl_missed.Text = "missed : 0";
            // 
            // easy_btn
            // 
            this.easy_btn.AutoSize = true;
            this.easy_btn.Location = new System.Drawing.Point(600, 15);
            this.easy_btn.Name = "easy_btn";
            this.easy_btn.Size = new System.Drawing.Size(59, 21);
            this.easy_btn.TabIndex = 5;
            this.easy_btn.Text = "easy";
            this.easy_btn.UseVisualStyleBackColor = true;
            this.easy_btn.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // meduim_btn
            // 
            this.meduim_btn.AutoSize = true;
            this.meduim_btn.Location = new System.Drawing.Point(493, 15);
            this.meduim_btn.Name = "meduim_btn";
            this.meduim_btn.Size = new System.Drawing.Size(78, 21);
            this.meduim_btn.TabIndex = 4;
            this.meduim_btn.Text = "meduim";
            this.meduim_btn.UseVisualStyleBackColor = true;
            this.meduim_btn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // hard_btn
            // 
            this.hard_btn.AutoSize = true;
            this.hard_btn.Location = new System.Drawing.Point(406, 14);
            this.hard_btn.Name = "hard_btn";
            this.hard_btn.Size = new System.Drawing.Size(58, 21);
            this.hard_btn.TabIndex = 3;
            this.hard_btn.Text = "hard";
            this.hard_btn.UseVisualStyleBackColor = true;
            this.hard_btn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbl_kill
            // 
            this.lbl_kill.AutoSize = true;
            this.lbl_kill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kill.Location = new System.Drawing.Point(843, 15);
            this.lbl_kill.Name = "lbl_kill";
            this.lbl_kill.Size = new System.Drawing.Size(93, 25);
            this.lbl_kill.TabIndex = 2;
            this.lbl_kill.Text = "killed : 0";
            // 
            // start_btn
            // 
            this.start_btn.ForeColor = System.Drawing.Color.Red;
            this.start_btn.Location = new System.Drawing.Point(256, 3);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(105, 40);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcome :";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::bird.Properties.Resources.reeds;
            this.pictureBox4.Location = new System.Drawing.Point(687, 453);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(614, 50);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::bird.Properties.Resources.reeds;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 453);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(749, 50);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bird.Properties.Resources.grnd;
            this.pictureBox2.Location = new System.Drawing.Point(724, 498);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(577, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bird.Properties.Resources.grnd;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 498);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // p_2
            // 
            this.p_2.Image = global::bird.Properties.Resources.bird_2;
            this.p_2.Location = new System.Drawing.Point(151, 393);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(59, 54);
            this.p_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_2.TabIndex = 3;
            this.p_2.TabStop = false;
            this.p_2.Visible = false;
            this.p_2.Click += new System.EventHandler(this.p_2_Click);
            // 
            // p_3
            // 
            this.p_3.BackColor = System.Drawing.Color.Transparent;
            this.p_3.Image = global::bird.Properties.Resources.bird_2;
            this.p_3.Location = new System.Drawing.Point(1175, 347);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(59, 54);
            this.p_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_3.TabIndex = 2;
            this.p_3.TabStop = false;
            this.p_3.Visible = false;
            this.p_3.Click += new System.EventHandler(this.p_3_Click);
            // 
            // p_1
            // 
            this.p_1.Image = global::bird.Properties.Resources.bird_2;
            this.p_1.Location = new System.Drawing.Point(133, 96);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(59, 54);
            this.p_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_1.TabIndex = 1;
            this.p_1.TabStop = false;
            this.p_1.Visible = false;
            this.p_1.Click += new System.EventHandler(this.p_1_Click);
            // 
            // lbl_over
            // 
            this.lbl_over.AutoSize = true;
            this.lbl_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_over.ForeColor = System.Drawing.Color.Red;
            this.lbl_over.Location = new System.Drawing.Point(493, 199);
            this.lbl_over.Name = "lbl_over";
            this.lbl_over.Size = new System.Drawing.Size(320, 69);
            this.lbl_over.TabIndex = 8;
            this.lbl_over.Text = "game over";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(499, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "play agian";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // p_5
            // 
            this.p_5.Image = global::bird.Properties.Resources.bird_2;
            this.p_5.Location = new System.Drawing.Point(499, 199);
            this.p_5.Name = "p_5";
            this.p_5.Size = new System.Drawing.Size(59, 54);
            this.p_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_5.TabIndex = 11;
            this.p_5.TabStop = false;
            this.p_5.Visible = false;
            this.p_5.Click += new System.EventHandler(this.p_5_Click);
            // 
            // p_6
            // 
            this.p_6.Image = global::bird.Properties.Resources.bird_2;
            this.p_6.Location = new System.Drawing.Point(1175, 171);
            this.p_6.Name = "p_6";
            this.p_6.Size = new System.Drawing.Size(59, 54);
            this.p_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_6.TabIndex = 12;
            this.p_6.TabStop = false;
            this.p_6.Visible = false;
            this.p_6.Click += new System.EventHandler(this.p_6_Click);
            // 
            // p_4
            // 
            this.p_4.Image = global::bird.Properties.Resources.bird_2;
            this.p_4.Location = new System.Drawing.Point(749, 366);
            this.p_4.Name = "p_4";
            this.p_4.Size = new System.Drawing.Size(64, 50);
            this.p_4.TabIndex = 10;
            this.p_4.TabStop = false;
            this.p_4.Visible = false;
            this.p_4.Click += new System.EventHandler(this.p_4_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1303, 548);
            this.Controls.Add(this.p_6);
            this.Controls.Add(this.p_5);
            this.Controls.Add(this.p_4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_over);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_1);
            this.Controls.Add(this.panel1);
            this.Name = "game";
            this.Text = "game";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.game_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.PictureBox p_1;
        private System.Windows.Forms.PictureBox p_3;
        private System.Windows.Forms.PictureBox p_2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton easy_btn;
        private System.Windows.Forms.RadioButton meduim_btn;
        private System.Windows.Forms.RadioButton hard_btn;
        private System.Windows.Forms.Label lbl_kill;
        private System.Windows.Forms.Label lbl_missed;
        private System.Windows.Forms.Label lbl_over;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox p_5;
        private System.Windows.Forms.PictureBox p_6;
        private System.Windows.Forms.PictureBox p_4;
    }
}