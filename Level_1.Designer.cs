namespace FormsSideScrollerGame
{
    partial class Level_1
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BlockSide = new System.Windows.Forms.PictureBox();
            this.Block_3 = new System.Windows.Forms.PictureBox();
            this.Block_2 = new System.Windows.Forms.PictureBox();
            this.Spike_2 = new System.Windows.Forms.PictureBox();
            this.Small_Spike = new System.Windows.Forms.PictureBox();
            this.Spike = new System.Windows.Forms.PictureBox();
            this.Block = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.background_lvl1 = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.EndOfLevel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockSide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spike_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Small_Spike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_lvl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndOfLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimer);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(3180, 460);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 90);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "BlockSide";
            // 
            // BlockSide
            // 
            this.BlockSide.BackColor = System.Drawing.Color.Transparent;
            this.BlockSide.Location = new System.Drawing.Point(2997, 510);
            this.BlockSide.Name = "BlockSide";
            this.BlockSide.Size = new System.Drawing.Size(1, 40);
            this.BlockSide.TabIndex = 16;
            this.BlockSide.TabStop = false;
            this.BlockSide.Tag = "BlockSide";
            // 
            // Block_3
            // 
            this.Block_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Block_3.Image = global::FormsSideScrollerGame.Properties.Resources.Block1;
            this.Block_3.Location = new System.Drawing.Point(3180, 443);
            this.Block_3.Name = "Block_3";
            this.Block_3.Size = new System.Drawing.Size(54, 54);
            this.Block_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Block_3.TabIndex = 15;
            this.Block_3.TabStop = false;
            this.Block_3.Tag = "Block";
            // 
            // Block_2
            // 
            this.Block_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Block_2.Image = global::FormsSideScrollerGame.Properties.Resources.Block1;
            this.Block_2.Location = new System.Drawing.Point(3180, 496);
            this.Block_2.Name = "Block_2";
            this.Block_2.Size = new System.Drawing.Size(54, 54);
            this.Block_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Block_2.TabIndex = 14;
            this.Block_2.TabStop = false;
            this.Block_2.Tag = "Block";
            // 
            // Spike_2
            // 
            this.Spike_2.BackColor = System.Drawing.Color.Black;
            this.Spike_2.BackgroundImage = global::FormsSideScrollerGame.Properties.Resources.Spike1;
            this.Spike_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Spike_2.Location = new System.Drawing.Point(1602, 496);
            this.Spike_2.Name = "Spike_2";
            this.Spike_2.Size = new System.Drawing.Size(54, 54);
            this.Spike_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spike_2.TabIndex = 13;
            this.Spike_2.TabStop = false;
            this.Spike_2.Tag = "Spike";
            // 
            // Small_Spike
            // 
            this.Small_Spike.BackColor = System.Drawing.Color.Black;
            this.Small_Spike.Image = global::FormsSideScrollerGame.Properties.Resources.Spike2;
            this.Small_Spike.Location = new System.Drawing.Point(1548, 496);
            this.Small_Spike.Name = "Small_Spike";
            this.Small_Spike.Size = new System.Drawing.Size(54, 54);
            this.Small_Spike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Small_Spike.TabIndex = 12;
            this.Small_Spike.TabStop = false;
            this.Small_Spike.Tag = "Spike";
            // 
            // Spike
            // 
            this.Spike.BackColor = System.Drawing.Color.Black;
            this.Spike.BackgroundImage = global::FormsSideScrollerGame.Properties.Resources.Spike1;
            this.Spike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Spike.Location = new System.Drawing.Point(857, 496);
            this.Spike.Name = "Spike";
            this.Spike.Size = new System.Drawing.Size(54, 54);
            this.Spike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spike.TabIndex = 11;
            this.Spike.TabStop = false;
            this.Spike.Tag = "Spike";
            // 
            // Block
            // 
            this.Block.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Block.Image = global::FormsSideScrollerGame.Properties.Resources.Block1;
            this.Block.Location = new System.Drawing.Point(2997, 496);
            this.Block.Name = "Block";
            this.Block.Size = new System.Drawing.Size(54, 54);
            this.Block.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Block.TabIndex = 10;
            this.Block.TabStop = false;
            this.Block.Tag = "Block";
            // 
            // player
            // 
            this.player.Image = global::FormsSideScrollerGame.Properties.Resources.Player_5Icon;
            this.player.Location = new System.Drawing.Point(128, 499);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(52, 52);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 9;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // background_lvl1
            // 
            this.background_lvl1.BackColor = System.Drawing.Color.Transparent;
            this.background_lvl1.Image = global::FormsSideScrollerGame.Properties.Resources.Background;
            this.background_lvl1.Location = new System.Drawing.Point(0, 0);
            this.background_lvl1.Name = "background_lvl1";
            this.background_lvl1.Size = new System.Drawing.Size(1000, 549);
            this.background_lvl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background_lvl1.TabIndex = 8;
            this.background_lvl1.TabStop = false;
            this.background_lvl1.Tag = "background_lvl1";
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Transparent;
            this.Ground.BackgroundImage = global::FormsSideScrollerGame.Properties.Resources.Ground;
            this.Ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ground.Location = new System.Drawing.Point(0, 547);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1000, 135);
            this.Ground.TabIndex = 3;
            this.Ground.TabStop = false;
            this.Ground.Tag = "Ground";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BackgroundImage = global::FormsSideScrollerGame.Properties.Resources.Spike1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(3234, 496);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Spike";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImage = global::FormsSideScrollerGame.Properties.Resources.Spike1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(2216, 495);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Spike";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.BackgroundImage = global::FormsSideScrollerGame.Properties.Resources.Spike1;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(2272, 495);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(54, 54);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 27;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "Spike";
            // 
            // EndOfLevel
            // 
            this.EndOfLevel.BackColor = System.Drawing.Color.Transparent;
            this.EndOfLevel.Location = new System.Drawing.Point(3788, 304);
            this.EndOfLevel.Name = "EndOfLevel";
            this.EndOfLevel.Size = new System.Drawing.Size(14, 247);
            this.EndOfLevel.TabIndex = 28;
            this.EndOfLevel.TabStop = false;
            this.EndOfLevel.Tag = "EndOfLevel";
            // 
            // Level_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 681);
            this.Controls.Add(this.EndOfLevel);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BlockSide);
            this.Controls.Add(this.Block_3);
            this.Controls.Add(this.Block_2);
            this.Controls.Add(this.Spike_2);
            this.Controls.Add(this.Small_Spike);
            this.Controls.Add(this.Spike);
            this.Controls.Add(this.Block);
            this.Controls.Add(this.player);
            this.Controls.Add(this.background_lvl1);
            this.Controls.Add(this.Ground);
            this.DoubleBuffered = true;
            this.Name = "Level_1";
            this.Tag = "Background";
            this.Text = "Level 1 : Säkkijärven Polkka";
            this.Load += new System.EventHandler(this.Level_1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlockSide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spike_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Small_Spike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Block)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background_lvl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndOfLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox background_lvl1;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Block;
        private System.Windows.Forms.PictureBox Spike;
        private System.Windows.Forms.PictureBox Small_Spike;
        private System.Windows.Forms.PictureBox Spike_2;
        private System.Windows.Forms.PictureBox Block_2;
        private System.Windows.Forms.PictureBox Block_3;
        private System.Windows.Forms.PictureBox BlockSide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox EndOfLevel;
    }
}