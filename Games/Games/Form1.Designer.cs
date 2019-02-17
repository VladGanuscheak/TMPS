namespace Games
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 146);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(128, 23);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Battleship";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.MyEventHandler);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(215, 146);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(128, 23);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "Kangaroo";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.MyEventHandler);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(417, 146);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(128, 23);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "Matches";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.MyEventHandler);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb3.BackgroundImage = global::Games.Properties.Resources.img_Matches;
            this.pb3.Location = new System.Drawing.Point(417, 12);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(128, 128);
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb2.BackgroundImage = global::Games.Properties.Resources.img_Kangaroo;
            this.pb2.Location = new System.Drawing.Point(215, 12);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(128, 128);
            this.pb2.TabIndex = 4;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb1.BackgroundImage = global::Games.Properties.Resources.logo_Battleship;
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(128, 128);
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "Form1";
            this.Text = "Puzzle Empire";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
    }
}

