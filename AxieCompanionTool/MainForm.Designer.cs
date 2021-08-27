
namespace AxieCompanionTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblEnergy = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblCards = new System.Windows.Forms.Label();
            this.LblTest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbWins = new System.Windows.Forms.TextBox();
            this.TbDraws = new System.Windows.Forms.TextBox();
            this.TbLoses = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AxieCompanionTool.Properties.Resources.frame_energy_ball;
            this.pictureBox1.Location = new System.Drawing.Point(10, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblEnergy
            // 
            this.LblEnergy.AutoSize = true;
            this.LblEnergy.BackColor = System.Drawing.Color.Transparent;
            this.LblEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnergy.ForeColor = System.Drawing.Color.White;
            this.LblEnergy.Location = new System.Drawing.Point(82, 102);
            this.LblEnergy.Name = "LblEnergy";
            this.LblEnergy.Size = new System.Drawing.Size(153, 108);
            this.LblEnergy.TabIndex = 1;
            this.LblEnergy.Text = "60";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AxieCompanionTool.Properties.Resources.hand_opponent_collapsed;
            this.pictureBox2.Location = new System.Drawing.Point(230, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // LblCards
            // 
            this.LblCards.AutoSize = true;
            this.LblCards.BackColor = System.Drawing.Color.Transparent;
            this.LblCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCards.ForeColor = System.Drawing.Color.White;
            this.LblCards.Location = new System.Drawing.Point(302, 102);
            this.LblCards.Name = "LblCards";
            this.LblCards.Size = new System.Drawing.Size(153, 108);
            this.LblCards.TabIndex = 3;
            this.LblCards.Text = "60";
            // 
            // LblTest
            // 
            this.LblTest.AutoSize = true;
            this.LblTest.Location = new System.Drawing.Point(41, 269);
            this.LblTest.Name = "LblTest";
            this.LblTest.Size = new System.Drawing.Size(35, 13);
            this.LblTest.TabIndex = 8;
            this.LblTest.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "W";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "D";
            // 
            // TbWins
            // 
            this.TbWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbWins.Location = new System.Drawing.Point(130, 16);
            this.TbWins.Name = "TbWins";
            this.TbWins.Size = new System.Drawing.Size(45, 47);
            this.TbWins.TabIndex = 12;
            this.TbWins.TabStop = false;
            this.TbWins.Text = "99";
            this.TbWins.DoubleClick += new System.EventHandler(this.AddWin);
            // 
            // TbDraws
            // 
            this.TbDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbDraws.Location = new System.Drawing.Point(234, 16);
            this.TbDraws.Name = "TbDraws";
            this.TbDraws.Size = new System.Drawing.Size(45, 47);
            this.TbDraws.TabIndex = 13;
            this.TbDraws.TabStop = false;
            this.TbDraws.Text = "99";
            this.TbDraws.DoubleClick += new System.EventHandler(this.AddDraw);
            // 
            // TbLoses
            // 
            this.TbLoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbLoses.Location = new System.Drawing.Point(339, 16);
            this.TbLoses.Name = "TbLoses";
            this.TbLoses.Size = new System.Drawing.Size(45, 47);
            this.TbLoses.TabIndex = 14;
            this.TbLoses.TabStop = false;
            this.TbLoses.Text = "99";
            this.TbLoses.DoubleClick += new System.EventHandler(this.AddLose);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AxieCompanionTool.Properties.Resources.bg_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 309);
            this.Controls.Add(this.TbLoses);
            this.Controls.Add(this.TbDraws);
            this.Controls.Add(this.TbWins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTest);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LblCards);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblEnergy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Axie Arena Companion Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblEnergy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LblCards;
        private System.Windows.Forms.Label LblTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbWins;
        private System.Windows.Forms.TextBox TbDraws;
        private System.Windows.Forms.TextBox TbLoses;
    }
}

