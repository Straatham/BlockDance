namespace FormsSideScrollerGame
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Help = new System.Windows.Forms.Button();
            this.btn_Options = new System.Windows.Forms.Button();
            this.btn_PlayerEdit = new System.Windows.Forms.Button();
            this.btn_LvlScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Formula1 Display Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1300, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Formula1 Display Bold", 70F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(705, 113);
            this.label2.TabIndex = 2;
            this.label2.Text = "Block Dance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Help
            // 
            this.btn_Help.Font = new System.Drawing.Font("Formula1 Display Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.Location = new System.Drawing.Point(1280, 540);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(170, 38);
            this.btn_Help.TabIndex = 3;
            this.btn_Help.Text = "Help";
            this.btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // btn_Options
            // 
            this.btn_Options.Font = new System.Drawing.Font("Formula1 Display Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Options.Location = new System.Drawing.Point(1260, 480);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(190, 38);
            this.btn_Options.TabIndex = 4;
            this.btn_Options.Text = "Options";
            this.btn_Options.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Options.UseVisualStyleBackColor = true;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // btn_PlayerEdit
            // 
            this.btn_PlayerEdit.Font = new System.Drawing.Font("Formula1 Display Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayerEdit.Location = new System.Drawing.Point(1240, 420);
            this.btn_PlayerEdit.Name = "btn_PlayerEdit";
            this.btn_PlayerEdit.Size = new System.Drawing.Size(210, 38);
            this.btn_PlayerEdit.TabIndex = 5;
            this.btn_PlayerEdit.Text = "Player";
            this.btn_PlayerEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_PlayerEdit.UseVisualStyleBackColor = true;
            this.btn_PlayerEdit.Click += new System.EventHandler(this.btn_PlayerEdit_Click);
            // 
            // btn_LvlScreen
            // 
            this.btn_LvlScreen.Font = new System.Drawing.Font("Formula1 Display Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LvlScreen.Location = new System.Drawing.Point(1220, 360);
            this.btn_LvlScreen.Name = "btn_LvlScreen";
            this.btn_LvlScreen.Size = new System.Drawing.Size(230, 38);
            this.btn_LvlScreen.TabIndex = 6;
            this.btn_LvlScreen.Text = "Level Screen";
            this.btn_LvlScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_LvlScreen.UseVisualStyleBackColor = true;
            this.btn_LvlScreen.Click += new System.EventHandler(this.btn_LvlScreen_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 681);
            this.Controls.Add(this.btn_LvlScreen);
            this.Controls.Add(this.btn_PlayerEdit);
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.Button btn_PlayerEdit;
        private System.Windows.Forms.Button btn_LvlScreen;
    }
}