namespace mini
{
    partial class Button2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Button2));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Home = new System.Windows.Forms.Button();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.Continue = new System.Windows.Forms.Button();
            this.labelname = new System.Windows.Forms.Label();
            this.labelyear = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Home.Location = new System.Drawing.Point(151, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(95, 38);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.home);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackColor = System.Drawing.Color.Transparent;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.male.Location = new System.Drawing.Point(95, 112);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(57, 19);
            this.male.TabIndex = 1;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = false;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.BackColor = System.Drawing.Color.Transparent;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.female.Location = new System.Drawing.Point(95, 153);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(73, 19);
            this.female.TabIndex = 2;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = false;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(95, 75);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 3;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(287, 75);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 4;
            this.year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.year_KeyPress);
            // 
            // Continue
            // 
            this.Continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Continue.BackgroundImage")));
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Continue.Location = new System.Drawing.Point(95, 193);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(151, 38);
            this.Continue.TabIndex = 5;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.cont);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelname.Location = new System.Drawing.Point(26, 80);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(49, 17);
            this.labelname.TabIndex = 11;
            this.labelname.Text = "Name";
            // 
            // labelyear
            // 
            this.labelyear.AutoSize = true;
            this.labelyear.BackColor = System.Drawing.Color.Transparent;
            this.labelyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelyear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelyear.Location = new System.Drawing.Point(227, 78);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(42, 17);
            this.labelyear.TabIndex = 12;
            this.labelyear.Text = "Year";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(393, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(473, 286);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // Button2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 313);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelyear);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.year);
            this.Controls.Add(this.name);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.Home);
            this.MaximizeBox = false;
            this.Name = "Button2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Popularity of a Name";
            this.Load += new System.EventHandler(this.Button2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelyear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}