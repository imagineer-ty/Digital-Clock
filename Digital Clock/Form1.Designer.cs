namespace Digital_Clock
{
    partial class digitalClock
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
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.greyButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.style1Button = new System.Windows.Forms.Button();
            this.style3Button = new System.Windows.Forms.Button();
            this.style2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clockLabel.Location = new System.Drawing.Point(5, 6);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(593, 164);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "Refreshing...";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clockLabel.Click += new System.EventHandler(this.clockLabel_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // greyButton
            // 
            this.greyButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.greyButton.Location = new System.Drawing.Point(1, 304);
            this.greyButton.Name = "greyButton";
            this.greyButton.Size = new System.Drawing.Size(29, 23);
            this.greyButton.TabIndex = 1;
            this.greyButton.UseVisualStyleBackColor = false;
            this.greyButton.Click += new System.EventHandler(this.greyButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.Location = new System.Drawing.Point(36, 304);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(29, 23);
            this.whiteButton.TabIndex = 2;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.redButton.Location = new System.Drawing.Point(71, 304);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(29, 23);
            this.redButton.TabIndex = 3;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.blueButton.Location = new System.Drawing.Point(106, 304);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(29, 23);
            this.blueButton.TabIndex = 4;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenButton.Location = new System.Drawing.Point(141, 304);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(29, 23);
            this.greenButton.TabIndex = 5;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // style1Button
            // 
            this.style1Button.Location = new System.Drawing.Point(369, 304);
            this.style1Button.Name = "style1Button";
            this.style1Button.Size = new System.Drawing.Size(75, 23);
            this.style1Button.TabIndex = 6;
            this.style1Button.Text = "Style 1";
            this.style1Button.UseVisualStyleBackColor = true;
            this.style1Button.Click += new System.EventHandler(this.style1Button_Click);
            // 
            // style3Button
            // 
            this.style3Button.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.style3Button.Location = new System.Drawing.Point(531, 304);
            this.style3Button.Name = "style3Button";
            this.style3Button.Size = new System.Drawing.Size(75, 23);
            this.style3Button.TabIndex = 7;
            this.style3Button.Text = "Style 3";
            this.style3Button.UseVisualStyleBackColor = true;
            this.style3Button.Click += new System.EventHandler(this.style3Button_Click);
            // 
            // style2Button
            // 
            this.style2Button.Font = new System.Drawing.Font("Edwardian Script ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.style2Button.Location = new System.Drawing.Point(450, 304);
            this.style2Button.Name = "style2Button";
            this.style2Button.Size = new System.Drawing.Size(75, 23);
            this.style2Button.TabIndex = 8;
            this.style2Button.Text = "Style 2";
            this.style2Button.UseVisualStyleBackColor = true;
            this.style2Button.Click += new System.EventHandler(this.style2Button_Click);
            // 
            // digitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(610, 328);
            this.Controls.Add(this.style2Button);
            this.Controls.Add(this.style3Button);
            this.Controls.Add(this.style1Button);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.greyButton);
            this.Controls.Add(this.clockLabel);
            this.Name = "digitalClock";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.digitalClock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button greyButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button style1Button;
        private System.Windows.Forms.Button style3Button;
        private System.Windows.Forms.Button style2Button;
    }
}

