namespace RPGui {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.lPlayer = new System.Windows.Forms.Label();
            this.lEnemy = new System.Windows.Forms.Label();
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.bConfirm = new System.Windows.Forms.Button();
            this.rbThird = new System.Windows.Forms.RadioButton();
            this.rbSecond = new System.Windows.Forms.RadioButton();
            this.rbFirst = new System.Windows.Forms.RadioButton();
            this.gbEnemy = new System.Windows.Forms.GroupBox();
            this.ltext = new System.Windows.Forms.Label();
            this.pPlayer = new System.Windows.Forms.PictureBox();
            this.pEnemy = new System.Windows.Forms.PictureBox();
            this.gbPlayer.SuspendLayout();
            this.gbEnemy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // lPlayer
            // 
            this.lPlayer.AutoSize = true;
            this.lPlayer.Location = new System.Drawing.Point(115, 9);
            this.lPlayer.Name = "lPlayer";
            this.lPlayer.Size = new System.Drawing.Size(51, 20);
            this.lPlayer.TabIndex = 2;
            this.lPlayer.Text = "label1";
            // 
            // lEnemy
            // 
            this.lEnemy.AutoSize = true;
            this.lEnemy.Location = new System.Drawing.Point(651, 9);
            this.lEnemy.Name = "lEnemy";
            this.lEnemy.Size = new System.Drawing.Size(51, 20);
            this.lEnemy.TabIndex = 3;
            this.lEnemy.Text = "label2";
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.bConfirm);
            this.gbPlayer.Controls.Add(this.rbThird);
            this.gbPlayer.Controls.Add(this.rbSecond);
            this.gbPlayer.Controls.Add(this.rbFirst);
            this.gbPlayer.Location = new System.Drawing.Point(34, 285);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(483, 135);
            this.gbPlayer.TabIndex = 4;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "groupBox1";
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(363, 54);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(105, 39);
            this.bConfirm.TabIndex = 3;
            this.bConfirm.Text = "button1";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // rbThird
            // 
            this.rbThird.AutoSize = true;
            this.rbThird.Location = new System.Drawing.Point(6, 99);
            this.rbThird.Name = "rbThird";
            this.rbThird.Size = new System.Drawing.Size(126, 24);
            this.rbThird.TabIndex = 2;
            this.rbThird.TabStop = true;
            this.rbThird.Text = "radioButton3";
            this.rbThird.UseVisualStyleBackColor = true;
            // 
            // rbSecond
            // 
            this.rbSecond.AutoSize = true;
            this.rbSecond.Location = new System.Drawing.Point(6, 69);
            this.rbSecond.Name = "rbSecond";
            this.rbSecond.Size = new System.Drawing.Size(126, 24);
            this.rbSecond.TabIndex = 1;
            this.rbSecond.TabStop = true;
            this.rbSecond.Text = "radioButton2";
            this.rbSecond.UseVisualStyleBackColor = true;
            // 
            // rbFirst
            // 
            this.rbFirst.AutoSize = true;
            this.rbFirst.Location = new System.Drawing.Point(6, 39);
            this.rbFirst.Name = "rbFirst";
            this.rbFirst.Size = new System.Drawing.Size(126, 24);
            this.rbFirst.TabIndex = 0;
            this.rbFirst.TabStop = true;
            this.rbFirst.Text = "radioButton1";
            this.rbFirst.UseVisualStyleBackColor = true;
            // 
            // gbEnemy
            // 
            this.gbEnemy.Controls.Add(this.ltext);
            this.gbEnemy.Location = new System.Drawing.Point(564, 285);
            this.gbEnemy.Name = "gbEnemy";
            this.gbEnemy.Size = new System.Drawing.Size(200, 153);
            this.gbEnemy.TabIndex = 5;
            this.gbEnemy.TabStop = false;
            this.gbEnemy.Text = "groupBox2";
            // 
            // ltext
            // 
            this.ltext.AutoSize = true;
            this.ltext.Location = new System.Drawing.Point(6, 22);
            this.ltext.Name = "ltext";
            this.ltext.Size = new System.Drawing.Size(51, 20);
            this.ltext.TabIndex = 0;
            this.ltext.Text = "label3";
            // 
            // pPlayer
            // 
            this.pPlayer.Location = new System.Drawing.Point(53, 32);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(254, 247);
            this.pPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPlayer.TabIndex = 1;
            this.pPlayer.TabStop = false;
            // 
            // pEnemy
            // 
            this.pEnemy.Location = new System.Drawing.Point(533, 32);
            this.pEnemy.Name = "pEnemy";
            this.pEnemy.Size = new System.Drawing.Size(255, 247);
            this.pEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pEnemy.TabIndex = 0;
            this.pEnemy.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEnemy);
            this.Controls.Add(this.gbPlayer);
            this.Controls.Add(this.lEnemy);
            this.Controls.Add(this.lPlayer);
            this.Controls.Add(this.pPlayer);
            this.Controls.Add(this.pEnemy);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayer.PerformLayout();
            this.gbEnemy.ResumeLayout(false);
            this.gbEnemy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pEnemy;
        private System.Windows.Forms.PictureBox pPlayer;
        private System.Windows.Forms.Label lPlayer;
        private System.Windows.Forms.Label lEnemy;
        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.GroupBox gbEnemy;
        private System.Windows.Forms.Label ltext;
        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.RadioButton rbThird;
        private System.Windows.Forms.RadioButton rbSecond;
        private System.Windows.Forms.RadioButton rbFirst;
    }
}