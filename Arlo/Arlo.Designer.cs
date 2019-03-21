namespace Arlo {
    partial class Arlo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.Log = new System.Windows.Forms.TextBox();
            this.StartStop = new System.Windows.Forms.Button();
            this.StartFrom = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PassesTextBox = new System.Windows.Forms.TextBox();
            this.PassesLabel = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.SpeedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Log.Location = new System.Drawing.Point(24, 23);
            this.Log.Margin = new System.Windows.Forms.Padding(6);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log.Size = new System.Drawing.Size(630, 512);
            this.Log.TabIndex = 0;
            // 
            // StartStop
            // 
            this.StartStop.Location = new System.Drawing.Point(24, 550);
            this.StartStop.Margin = new System.Windows.Forms.Padding(6);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(150, 44);
            this.StartStop.TabIndex = 1;
            this.StartStop.Text = "Start";
            this.StartStop.UseVisualStyleBackColor = true;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // StartFrom
            // 
            this.StartFrom.Location = new System.Drawing.Point(186, 556);
            this.StartFrom.Margin = new System.Windows.Forms.Padding(6);
            this.StartFrom.Name = "StartFrom";
            this.StartFrom.Size = new System.Drawing.Size(196, 31);
            this.StartFrom.TabIndex = 2;
            this.StartFrom.Text = "Enter a number...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PassesTextBox
            // 
            this.PassesTextBox.Location = new System.Drawing.Point(31, 756);
            this.PassesTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PassesTextBox.Name = "PassesTextBox";
            this.PassesTextBox.ReadOnly = true;
            this.PassesTextBox.Size = new System.Drawing.Size(156, 31);
            this.PassesTextBox.TabIndex = 3;
            // 
            // PassesLabel
            // 
            this.PassesLabel.AutoSize = true;
            this.PassesLabel.Location = new System.Drawing.Point(26, 725);
            this.PassesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PassesLabel.Name = "PassesLabel";
            this.PassesLabel.Size = new System.Drawing.Size(161, 25);
            this.PassesLabel.TabIndex = 4;
            this.PassesLabel.Text = "Largest Passes";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(203, 725);
            this.Number.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(87, 25);
            this.Number.TabIndex = 5;
            this.Number.Text = "Number";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(208, 756);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(428, 31);
            this.NumberTextBox.TabIndex = 6;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(494, 550);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(160, 44);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SpeedBar
            // 
            this.SpeedBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedBar.Location = new System.Drawing.Point(12, 632);
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.Size = new System.Drawing.Size(642, 90);
            this.SpeedBar.TabIndex = 8;
            this.SpeedBar.TickFrequency = 10;
            this.SpeedBar.Value = 5;
            this.SpeedBar.Scroll += new System.EventHandler(this.SpeedBar_Scroll);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(295, 678);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(74, 25);
            this.SpeedLabel.TabIndex = 9;
            this.SpeedLabel.Text = "Speed";
            // 
            // Arlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 802);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.PassesLabel);
            this.Controls.Add(this.PassesTextBox);
            this.Controls.Add(this.StartFrom);
            this.Controls.Add(this.StartStop);
            this.Controls.Add(this.Log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Arlo";
            this.Text = "Arlo";
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.TextBox StartFrom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox PassesTextBox;
        private System.Windows.Forms.Label PassesLabel;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.Label SpeedLabel;
    }
}

