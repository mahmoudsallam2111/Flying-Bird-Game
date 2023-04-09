namespace flappy_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ground = new PictureBox();
            flybird = new PictureBox();
            pipebottom = new PictureBox();
            pipetop = new PictureBox();
            txt_score = new Label();
            gametimer = new System.Windows.Forms.Timer(components);
            txt_con = new Label();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flybird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipebottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipetop).BeginInit();
            SuspendLayout();
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-5, 491);
            ground.Name = "ground";
            ground.Size = new Size(597, 101);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 0;
            ground.TabStop = false;
            // 
            // flybird
            // 
            flybird.BackColor = Color.Transparent;
            flybird.Image = (Image)resources.GetObject("flybird.Image");
            flybird.Location = new Point(67, 188);
            flybird.Name = "flybird";
            flybird.Size = new Size(80, 61);
            flybird.TabIndex = 1;
            flybird.TabStop = false;
            // 
            // pipebottom
            // 
            pipebottom.Image = Properties.Resources.pipe;
            pipebottom.Location = new Point(309, 333);
            pipebottom.Name = "pipebottom";
            pipebottom.Size = new Size(94, 159);
            pipebottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipebottom.TabIndex = 2;
            pipebottom.TabStop = false;
            // 
            // pipetop
            // 
            pipetop.Image = Properties.Resources.pipedown;
            pipetop.Location = new Point(430, 0);
            pipetop.Name = "pipetop";
            pipetop.Size = new Size(107, 183);
            pipetop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipetop.TabIndex = 3;
            pipetop.TabStop = false;
            // 
            // txt_score
            // 
            txt_score.AutoSize = true;
            txt_score.BackColor = Color.FromArgb(255, 255, 128);
            txt_score.Font = new Font("Simplified Arabic Fixed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_score.Location = new Point(227, 519);
            txt_score.Name = "txt_score";
            txt_score.Size = new Size(147, 28);
            txt_score.TabIndex = 4;
            txt_score.Text = "Score : 0";
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += gametimerevent;
            // 
            // txt_con
            // 
            txt_con.AutoSize = true;
            txt_con.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_con.Location = new Point(67, 30);
            txt_con.Name = "txt_con";
            txt_con.Size = new Size(210, 25);
            txt_con.TabIndex = 5;
            txt_con.Text = "Congratulations 💪💪 ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(584, 591);
            Controls.Add(txt_con);
            Controls.Add(txt_score);
            Controls.Add(pipetop);
            Controls.Add(pipebottom);
            Controls.Add(flybird);
            Controls.Add(ground);
            Name = "Form1";
            Text = "flappy game";
            KeyDown += gamekeydown;
            KeyUp += gamekeyup;
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)flybird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipebottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipetop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ground;
        private PictureBox flybird;
        private PictureBox pipebottom;
        private PictureBox pipetop;
        private Label txt_score;
        private System.Windows.Forms.Timer gametimer;
        private Label txt_con;
    }
}