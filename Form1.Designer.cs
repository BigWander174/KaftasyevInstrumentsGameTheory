namespace KaftasyevInstrumentsGameTheory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.BNumerics = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ANumerics = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.mainView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.simpleView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumerics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANumerics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(764, 359);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(252, 27);
            this.textBoxB.TabIndex = 23;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(764, 321);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(252, 27);
            this.textBoxA.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(711, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(711, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Упрощенная матрица";
            // 
            // simpleView
            // 
            this.simpleView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.simpleView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simpleView.Location = new System.Drawing.Point(711, 82);
            this.simpleView.Name = "simpleView";
            this.simpleView.RowHeadersWidth = 51;
            this.simpleView.RowTemplate.Height = 29;
            this.simpleView.Size = new System.Drawing.Size(390, 210);
            this.simpleView.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 77);
            this.button1.TabIndex = 17;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BNumerics
            // 
            this.BNumerics.Location = new System.Drawing.Point(37, 40);
            this.BNumerics.Name = "BNumerics";
            this.BNumerics.Size = new System.Drawing.Size(150, 27);
            this.BNumerics.TabIndex = 16;
            this.BNumerics.ValueChanged += new System.EventHandler(this.BNumerics_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "B";
            // 
            // ANumerics
            // 
            this.ANumerics.Location = new System.Drawing.Point(37, 7);
            this.ANumerics.Name = "ANumerics";
            this.ANumerics.Size = new System.Drawing.Size(150, 27);
            this.ANumerics.TabIndex = 14;
            this.ANumerics.ValueChanged += new System.EventHandler(this.ANumerics_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "A";
            // 
            // mainView
            // 
            this.mainView.AllowUserToAddRows = false;
            this.mainView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.mainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainView.Location = new System.Drawing.Point(12, 82);
            this.mainView.Name = "mainView";
            this.mainView.RowHeadersWidth = 75;
            this.mainView.RowTemplate.Height = 29;
            this.mainView.Size = new System.Drawing.Size(496, 290);
            this.mainView.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simpleView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BNumerics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ANumerics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.simpleView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BNumerics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ANumerics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView simpleView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown BNumerics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ANumerics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mainView;
    }
}
