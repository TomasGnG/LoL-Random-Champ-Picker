namespace League_of_Legends_Champion_Randomizer
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
            this.allButton = new System.Windows.Forms.Button();
            this.topButton = new System.Windows.Forms.Button();
            this.jglButton = new System.Windows.Forms.Button();
            this.midButton = new System.Windows.Forms.Button();
            this.adcButton = new System.Windows.Forms.Button();
            this.suppButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rndChampNameLabel = new System.Windows.Forms.Label();
            this.lastChampPicks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // allButton
            // 
            this.allButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.allButton.Location = new System.Drawing.Point(176, 624);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(138, 39);
            this.allButton.TabIndex = 0;
            this.allButton.Text = "All Champs";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.buttonClickEvent);
            // 
            // topButton
            // 
            this.topButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topButton.Location = new System.Drawing.Point(320, 624);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(138, 39);
            this.topButton.TabIndex = 1;
            this.topButton.UseVisualStyleBackColor = true;
            this.topButton.Click += new System.EventHandler(this.buttonClickEvent);
            // 
            // jglButton
            // 
            this.jglButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jglButton.Location = new System.Drawing.Point(464, 624);
            this.jglButton.Name = "jglButton";
            this.jglButton.Size = new System.Drawing.Size(138, 39);
            this.jglButton.TabIndex = 2;
            this.jglButton.UseVisualStyleBackColor = true;
            this.jglButton.Click += new System.EventHandler(this.buttonClickEvent);
            // 
            // midButton
            // 
            this.midButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midButton.Location = new System.Drawing.Point(608, 624);
            this.midButton.Name = "midButton";
            this.midButton.Size = new System.Drawing.Size(138, 39);
            this.midButton.TabIndex = 3;
            this.midButton.UseVisualStyleBackColor = true;
            this.midButton.Click += new System.EventHandler(this.buttonClickEvent);
            // 
            // adcButton
            // 
            this.adcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adcButton.Location = new System.Drawing.Point(752, 624);
            this.adcButton.Name = "adcButton";
            this.adcButton.Size = new System.Drawing.Size(138, 39);
            this.adcButton.TabIndex = 4;
            this.adcButton.UseVisualStyleBackColor = true;
            this.adcButton.Click += new System.EventHandler(this.buttonClickEvent);
            // 
            // suppButton
            // 
            this.suppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppButton.Location = new System.Drawing.Point(896, 624);
            this.suppButton.Name = "suppButton";
            this.suppButton.Size = new System.Drawing.Size(138, 39);
            this.suppButton.TabIndex = 5;
            this.suppButton.UseVisualStyleBackColor = true;
            this.suppButton.Click += new System.EventHandler(this.buttonClickEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Location = new System.Drawing.Point(399, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 463);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1132, 78);
            this.label1.TabIndex = 7;
            this.label1.Text = "League of Legends Random Champion Generator\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // rndChampNameLabel
            // 
            this.rndChampNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rndChampNameLabel.Location = new System.Drawing.Point(399, 551);
            this.rndChampNameLabel.Name = "rndChampNameLabel";
            this.rndChampNameLabel.Size = new System.Drawing.Size(408, 47);
            this.rndChampNameLabel.TabIndex = 8;
            this.rndChampNameLabel.Text = "Champion Name...";
            this.rndChampNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastChampPicks
            // 
            this.lastChampPicks.BackColor = System.Drawing.Color.Transparent;
            this.lastChampPicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastChampPicks.ForeColor = System.Drawing.Color.White;
            this.lastChampPicks.Location = new System.Drawing.Point(35, 138);
            this.lastChampPicks.Name = "lastChampPicks";
            this.lastChampPicks.Size = new System.Drawing.Size(224, 432);
            this.lastChampPicks.TabIndex = 9;
            this.lastChampPicks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Random Champ History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastChampPicks);
            this.Controls.Add(this.rndChampNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.suppButton);
            this.Controls.Add(this.adcButton);
            this.Controls.Add(this.midButton);
            this.Controls.Add(this.jglButton);
            this.Controls.Add(this.topButton);
            this.Controls.Add(this.allButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "LoL Random Champion Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.Button jglButton;
        private System.Windows.Forms.Button midButton;
        private System.Windows.Forms.Button adcButton;
        private System.Windows.Forms.Button suppButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rndChampNameLabel;
        private System.Windows.Forms.Label lastChampPicks;
        private System.Windows.Forms.Label label2;
    }
}

