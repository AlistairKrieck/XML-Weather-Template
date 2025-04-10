namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weatherOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.current = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enterCityInputButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.ForestGreen;
            this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.White;
            this.currentLabel.Location = new System.Drawing.Point(28, 18);
            this.currentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(109, 34);
            this.currentLabel.TabIndex = 40;
            this.currentLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.ForestGreen;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(188, 18);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(109, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 33);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weatherOutput
            // 
            this.weatherOutput.BackColor = System.Drawing.Color.White;
            this.weatherOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.weatherOutput.Location = new System.Drawing.Point(25, 286);
            this.weatherOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weatherOutput.Name = "weatherOutput";
            this.weatherOutput.Size = new System.Drawing.Size(322, 39);
            this.weatherOutput.TabIndex = 74;
            this.weatherOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(34, 167);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(116, 58);
            this.minLabel.TabIndex = 73;
            this.minLabel.Text = "Low:";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.minOutput.Location = new System.Drawing.Point(157, 167);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(92, 62);
            this.minOutput.TabIndex = 72;
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxLabel
            // 
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(34, 123);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(116, 58);
            this.maxLabel.TabIndex = 71;
            this.maxLabel.Text = "High:";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.maxOutput.Location = new System.Drawing.Point(157, 123);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(92, 62);
            this.maxOutput.TabIndex = 69;
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.White;
            this.currentOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.currentOutput.Location = new System.Drawing.Point(157, 213);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(92, 62);
            this.currentOutput.TabIndex = 75;
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.Location = new System.Drawing.Point(0, 65);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1280, 668);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 99;
            this.picBox.TabStop = false;
            // 
            // current
            // 
            this.current.BackColor = System.Drawing.Color.Transparent;
            this.current.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.current.ForeColor = System.Drawing.Color.White;
            this.current.Location = new System.Drawing.Point(10, 213);
            this.current.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(150, 58);
            this.current.TabIndex = 76;
            this.current.Text = "Current:";
            this.current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityInput
            // 
            this.cityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cityInput.Location = new System.Drawing.Point(879, 17);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(243, 30);
            this.cityInput.TabIndex = 112;
            this.cityInput.Text = "Stratford,CA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(405, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 490);
            this.panel2.TabIndex = 99;
            // 
            // enterCityInputButton
            // 
            this.enterCityInputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCityInputButton.ForeColor = System.Drawing.Color.Black;
            this.enterCityInputButton.Location = new System.Drawing.Point(1130, 17);
            this.enterCityInputButton.Name = "enterCityInputButton";
            this.enterCityInputButton.Size = new System.Drawing.Size(93, 34);
            this.enterCityInputButton.TabIndex = 113;
            this.enterCityInputButton.Text = "Enter";
            this.enterCityInputButton.UseVisualStyleBackColor = true;
            this.enterCityInputButton.Click += new System.EventHandler(this.enterCityInputButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.enterCityInputButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cityInput);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 65);
            this.panel1.TabIndex = 98;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(450, 200);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(575, 58);
            this.date.TabIndex = 100;
            this.date.Text = "date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.date);
            this.Controls.Add(this.current);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.weatherOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label weatherOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button enterCityInputButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label date;
    }
}
