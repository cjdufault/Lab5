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
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picWeather = new System.Windows.Forms.PictureBox();
            this.lblWeather = new System.Windows.Forms.Label();
            this.cmboStates = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.Location = new System.Drawing.Point(541, 32);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(107, 23);
            this.btnGetWeather.TabIndex = 2;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = true;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(140, 35);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(149, 20);
            this.txtCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "State/Territory:";
            // 
            // picWeather
            // 
            this.picWeather.Location = new System.Drawing.Point(80, 95);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(595, 350);
            this.picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWeather.TabIndex = 5;
            this.picWeather.TabStop = false;
            // 
            // lblWeather
            // 
            this.lblWeather.Location = new System.Drawing.Point(224, 127);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(324, 67);
            this.lblWeather.TabIndex = 6;
            this.lblWeather.Text = "Enter city and state to get a weather forcast";
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmboStates
            // 
            this.cmboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboStates.FormattingEnabled = true;
            this.cmboStates.Location = new System.Drawing.Point(374, 33);
            this.cmboStates.Name = "cmboStates";
            this.cmboStates.Size = new System.Drawing.Size(147, 21);
            this.cmboStates.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGetWeather;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 513);
            this.Controls.Add(this.cmboStates);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.picWeather);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnGetWeather);
            this.Name = "Form1";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picWeather;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.ComboBox cmboStates;
    }
}

