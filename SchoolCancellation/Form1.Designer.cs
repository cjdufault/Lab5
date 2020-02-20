namespace SchoolCancellation
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
            this.numTemp = new System.Windows.Forms.NumericUpDown();
            this.numWindChill = new System.Windows.Forms.NumericUpDown();
            this.numSnowfall = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblCancelled = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindChill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnowfall)).BeginInit();
            this.SuspendLayout();
            // 
            // numTemp
            // 
            this.numTemp.Location = new System.Drawing.Point(617, 131);
            this.numTemp.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numTemp.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numTemp.Name = "numTemp";
            this.numTemp.Size = new System.Drawing.Size(78, 20);
            this.numTemp.TabIndex = 0;
            // 
            // numWindChill
            // 
            this.numWindChill.Location = new System.Drawing.Point(617, 213);
            this.numWindChill.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numWindChill.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.numWindChill.Name = "numWindChill";
            this.numWindChill.Size = new System.Drawing.Size(78, 20);
            this.numWindChill.TabIndex = 1;
            // 
            // numSnowfall
            // 
            this.numSnowfall.DecimalPlaces = 1;
            this.numSnowfall.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numSnowfall.Location = new System.Drawing.Point(617, 303);
            this.numSnowfall.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSnowfall.Name = "numSnowfall";
            this.numSnowfall.Size = new System.Drawing.Size(78, 20);
            this.numSnowfall.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temperature (°F)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wind Chill (°F)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Snowfall (inches)";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(471, 393);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblCancelled
            // 
            this.lblCancelled.AutoSize = true;
            this.lblCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelled.Location = new System.Drawing.Point(614, 398);
            this.lblCancelled.Name = "lblCancelled";
            this.lblCancelled.Size = new System.Drawing.Size(0, 13);
            this.lblCancelled.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(931, 710);
            this.Controls.Add(this.lblCancelled);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSnowfall);
            this.Controls.Add(this.numWindChill);
            this.Controls.Add(this.numTemp);
            this.Name = "Form1";
            this.Text = "School Cancellations";
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindChill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnowfall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTemp;
        private System.Windows.Forms.NumericUpDown numWindChill;
        private System.Windows.Forms.NumericUpDown numSnowfall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblCancelled;
    }
}

