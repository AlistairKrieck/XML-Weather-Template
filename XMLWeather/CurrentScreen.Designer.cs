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
            this.label2 = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.current = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.White;
            this.currentLabel.Location = new System.Drawing.Point(28, 18);
            this.currentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(110, 34);
            this.currentLabel.TabIndex = 40;
            this.currentLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(188, 18);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 31);
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
            this.weatherOutput.Location = new System.Drawing.Point(51, 286);
            this.weatherOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weatherOutput.Name = "weatherOutput";
            this.weatherOutput.Size = new System.Drawing.Size(186, 29);
            this.weatherOutput.TabIndex = 74;
            this.weatherOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 73;
            this.label2.Text = "Low:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(157, 200);
            this.minOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(50, 29);
            this.minOutput.TabIndex = 72;
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 71;
            this.label1.Text = "High:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityOutput
            // 
            this.cityOutput.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(28, 87);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(1222, 57);
            this.cityOutput.TabIndex = 70;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(157, 155);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(50, 29);
            this.maxOutput.TabIndex = 69;
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current
            // 
            this.current.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.ForeColor = System.Drawing.Color.White;
            this.current.Location = new System.Drawing.Point(51, 245);
            this.current.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(98, 26);
            this.current.TabIndex = 76;
            this.current.Text = "Current:";
            this.current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(157, 245);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(50, 29);
            this.currentOutput.TabIndex = 75;
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.current);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.weatherOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(1280, 720);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label weatherOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label currentOutput;
    }
}
