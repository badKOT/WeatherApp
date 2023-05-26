
namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblWeather = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblTempValue = new System.Windows.Forms.Label();
            this.lblWindValue = new System.Windows.Forms.Label();
            this.lblWeatherValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(295, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.Black;
            this.lblCity.Location = new System.Drawing.Point(69, 53);
            this.lblCity.Name = "lblCity";
            this.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCity.Size = new System.Drawing.Size(52, 23);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City:";
            // 
            // tbCity
            // 
            this.tbCity.BackColor = System.Drawing.Color.OldLace;
            this.tbCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCity.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCity.Location = new System.Drawing.Point(127, 53);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(162, 23);
            this.tbCity.TabIndex = 2;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.Color.Black;
            this.lblTemp.Location = new System.Drawing.Point(69, 103);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTemp.Size = new System.Drawing.Size(127, 23);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "Temperature";
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.BackColor = System.Drawing.Color.Transparent;
            this.lblWeather.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.ForeColor = System.Drawing.Color.Black;
            this.lblWeather.Location = new System.Drawing.Point(69, 144);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeather.Size = new System.Drawing.Size(87, 23);
            this.lblWeather.TabIndex = 5;
            this.lblWeather.Text = "Weather";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.BackColor = System.Drawing.Color.Transparent;
            this.lblWind.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.ForeColor = System.Drawing.Color.Black;
            this.lblWind.Location = new System.Drawing.Point(69, 182);
            this.lblWind.Name = "lblWind";
            this.lblWind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWind.Size = new System.Drawing.Size(56, 23);
            this.lblWind.TabIndex = 6;
            this.lblWind.Text = "Wind";
            // 
            // lblTempValue
            // 
            this.lblTempValue.AutoSize = true;
            this.lblTempValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTempValue.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempValue.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTempValue.Location = new System.Drawing.Point(220, 103);
            this.lblTempValue.Name = "lblTempValue";
            this.lblTempValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTempValue.Size = new System.Drawing.Size(253, 23);
            this.lblTempValue.TabIndex = 7;
            this.lblTempValue.Text = "Try searching for some city";
            // 
            // lblWindValue
            // 
            this.lblWindValue.AutoSize = true;
            this.lblWindValue.BackColor = System.Drawing.Color.Transparent;
            this.lblWindValue.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindValue.ForeColor = System.Drawing.Color.DarkGray;
            this.lblWindValue.Location = new System.Drawing.Point(220, 182);
            this.lblWindValue.Name = "lblWindValue";
            this.lblWindValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWindValue.Size = new System.Drawing.Size(253, 23);
            this.lblWindValue.TabIndex = 8;
            this.lblWindValue.Text = "Try searching for some city";
            // 
            // lblWeatherValue
            // 
            this.lblWeatherValue.AutoSize = true;
            this.lblWeatherValue.BackColor = System.Drawing.Color.Transparent;
            this.lblWeatherValue.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherValue.ForeColor = System.Drawing.Color.DarkGray;
            this.lblWeatherValue.Location = new System.Drawing.Point(220, 144);
            this.lblWeatherValue.Name = "lblWeatherValue";
            this.lblWeatherValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWeatherValue.Size = new System.Drawing.Size(253, 23);
            this.lblWeatherValue.TabIndex = 9;
            this.lblWeatherValue.Text = "Try searching for some city";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 265);
            this.Controls.Add(this.lblWeatherValue);
            this.Controls.Add(this.lblWindValue);
            this.Controls.Add(this.lblTempValue);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnSearch);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblTempValue;
        private System.Windows.Forms.Label lblWindValue;
        private System.Windows.Forms.Label lblWeatherValue;
    }
}

