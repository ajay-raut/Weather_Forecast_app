namespace Weather_Application
{
    partial class ForecastUC
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
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labDT = new System.Windows.Forms.Label();
            this.labMainWeather = new System.Windows.Forms.Label();
            this.labWeatherDescription = new System.Windows.Forms.Label();
            this.labForecastTemp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(3, 3);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(58, 68);
            this.picWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // labDT
            // 
            this.labDT.AutoSize = true;
            this.labDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labDT.Location = new System.Drawing.Point(174, 3);
            this.labDT.Name = "labDT";
            this.labDT.Size = new System.Drawing.Size(57, 16);
            this.labDT.TabIndex = 1;
            this.labDT.Text = "sunday";
            // 
            // labMainWeather
            // 
            this.labMainWeather.AutoSize = true;
            this.labMainWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainWeather.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labMainWeather.Location = new System.Drawing.Point(67, 55);
            this.labMainWeather.Name = "labMainWeather";
            this.labMainWeather.Size = new System.Drawing.Size(42, 16);
            this.labMainWeather.TabIndex = 2;
            this.labMainWeather.Text = "clear";
            // 
            // labWeatherDescription
            // 
            this.labWeatherDescription.AutoSize = true;
            this.labWeatherDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherDescription.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labWeatherDescription.Location = new System.Drawing.Point(174, 55);
            this.labWeatherDescription.Name = "labWeatherDescription";
            this.labWeatherDescription.Size = new System.Drawing.Size(86, 16);
            this.labWeatherDescription.TabIndex = 3;
            this.labWeatherDescription.Text = "Description";
            // 
            // labForecastTemp
            // 
            this.labForecastTemp.AutoSize = true;
            this.labForecastTemp.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labForecastTemp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labForecastTemp.Location = new System.Drawing.Point(96, 19);
            this.labForecastTemp.Name = "labForecastTemp";
            this.labForecastTemp.Size = new System.Drawing.Size(36, 27);
            this.labForecastTemp.TabIndex = 4;
            this.labForecastTemp.Text = "23";
            this.labForecastTemp.Click += new System.EventHandler(this.labForecastTemp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Weather_Application.Properties.Resources.thermometer;
            this.pictureBox1.Location = new System.Drawing.Point(67, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ForecastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labForecastTemp);
            this.Controls.Add(this.labWeatherDescription);
            this.Controls.Add(this.labMainWeather);
            this.Controls.Add(this.labDT);
            this.Controls.Add(this.picWeatherIcon);
            this.Name = "ForecastUC";
            this.Size = new System.Drawing.Size(279, 78);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label labDT;
        public System.Windows.Forms.Label labMainWeather;
        public System.Windows.Forms.Label labWeatherDescription;
        public System.Windows.Forms.Label labForecastTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
