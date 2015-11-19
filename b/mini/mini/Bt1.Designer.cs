namespace mini
{
    partial class Bt1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bt1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labeltop = new System.Windows.Forms.Label();
            this.labelyear = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.TextBox();
            this.Continue = new System.Windows.Forms.Button();
            this.year = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.Button();
            this.both = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 256);
            this.dataGridView1.TabIndex = 22;
            // 
            // labeltop
            // 
            this.labeltop.AutoSize = true;
            this.labeltop.BackColor = System.Drawing.Color.Transparent;
            this.labeltop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltop.ForeColor = System.Drawing.Color.Transparent;
            this.labeltop.Location = new System.Drawing.Point(706, 97);
            this.labeltop.Name = "labeltop";
            this.labeltop.Size = new System.Drawing.Size(36, 17);
            this.labeltop.TabIndex = 21;
            this.labeltop.Text = "Top";
            // 
            // labelyear
            // 
            this.labelyear.AutoSize = true;
            this.labelyear.BackColor = System.Drawing.Color.Transparent;
            this.labelyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelyear.ForeColor = System.Drawing.Color.Transparent;
            this.labelyear.Location = new System.Drawing.Point(536, 97);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(42, 17);
            this.labelyear.TabIndex = 20;
            this.labelyear.Text = "Year";
            // 
            // top
            // 
            this.top.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.top.Location = new System.Drawing.Point(750, 94);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(100, 20);
            this.top.TabIndex = 19;
            this.top.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.top_KeyPress);
            // 
            // Continue
            // 
            this.Continue.AutoSize = true;
            this.Continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Continue.BackgroundImage")));
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.Transparent;
            this.Continue.Location = new System.Drawing.Point(608, 230);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(131, 38);
            this.Continue.TabIndex = 18;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // year
            // 
            this.year.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.year.Location = new System.Drawing.Point(580, 94);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 20);
            this.year.TabIndex = 17;
            this.year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.year_KeyPress);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Home.BackgroundImage")));
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.Transparent;
            this.Home.Location = new System.Drawing.Point(685, 30);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(95, 38);
            this.Home.TabIndex = 16;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // both
            // 
            this.both.AutoSize = true;
            this.both.BackColor = System.Drawing.Color.Transparent;
            this.both.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.both.ForeColor = System.Drawing.Color.Transparent;
            this.both.Location = new System.Drawing.Point(608, 203);
            this.both.Name = "both";
            this.both.Size = new System.Drawing.Size(170, 19);
            this.both.TabIndex = 15;
            this.both.TabStop = true;
            this.both.Text = "Both Male and Female";
            this.both.UseVisualStyleBackColor = false;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.BackColor = System.Drawing.Color.Transparent;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.ForeColor = System.Drawing.Color.Transparent;
            this.female.Location = new System.Drawing.Point(608, 166);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(105, 19);
            this.female.TabIndex = 14;
            this.female.TabStop = true;
            this.female.Text = "Only Female";
            this.female.UseVisualStyleBackColor = false;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackColor = System.Drawing.Color.Transparent;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.ForeColor = System.Drawing.Color.Transparent;
            this.male.Location = new System.Drawing.Point(608, 132);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(89, 19);
            this.male.TabIndex = 13;
            this.male.TabStop = true;
            this.male.Text = "Only Male";
            this.male.UseVisualStyleBackColor = false;
            // 
            // Bt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 301);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labeltop);
            this.Controls.Add(this.labelyear);
            this.Controls.Add(this.top);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.year);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.both);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Name = "Bt1";
            this.Text = "Popular Name";
            this.Load += new System.EventHandler(this.Bt1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labeltop;
        private System.Windows.Forms.Label labelyear;
        private System.Windows.Forms.TextBox top;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.RadioButton both;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
    }
}