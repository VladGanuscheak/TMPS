namespace Games
{
    partial class Form_Battleship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Battleship));
            this.lbl1 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(315, 61);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(149, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Choose the mode of the game";
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(434, 100);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(200, 50);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "Player vs Player";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.OnClickHandler);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(434, 183);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(200, 50);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "Player vs AI";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.OnClickHandler);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(434, 273);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(200, 50);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "AI vs AI";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.OnClickHandler);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(69, 61);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(86, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Choose the level";
            // 
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1.FormattingEnabled = true;
            this.lb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lb1.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6"});
            this.lb1.Location = new System.Drawing.Point(72, 100);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(62, 95);
            this.lb1.TabIndex = 6;
            this.lb1.Click += new System.EventHandler(this.OnClickHandler);
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6"});
            this.lb2.Location = new System.Drawing.Point(72, 273);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(62, 95);
            this.lb2.TabIndex = 7;
            this.lb2.Click += new System.EventHandler(this.OnClickHandler);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(99, 84);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(35, 13);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "For AI";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(61, 257);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(73, 13);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "For second AI";
            // 
            // Form_Battleship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Games.Properties.Resources.Background_Game_Battleship;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "Form_Battleship";
            this.Text = "Form_Battleship";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Battleship_FormClosing);
            this.Load += new System.EventHandler(this.Form_Battleship_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}