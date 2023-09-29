namespace NewProject
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
            this.Internaldoorx = new System.Windows.Forms.TextBox();
            this.internaldoory = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.AddCordin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.obstacleX = new System.Windows.Forms.TextBox();
            this.obstacleY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Internaldoorx
            // 
            this.Internaldoorx.Location = new System.Drawing.Point(123, 65);
            this.Internaldoorx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Internaldoorx.Name = "Internaldoorx";
            this.Internaldoorx.Size = new System.Drawing.Size(54, 23);
            this.Internaldoorx.TabIndex = 0;
            // 
            // internaldoory
            // 
            this.internaldoory.Location = new System.Drawing.Point(123, 130);
            this.internaldoory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.internaldoory.Name = "internaldoory";
            this.internaldoory.Size = new System.Drawing.Size(51, 23);
            this.internaldoory.TabIndex = 1;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(123, 215);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(83, 22);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "Submmit";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // AddCordin
            // 
            this.AddCordin.Location = new System.Drawing.Point(338, 215);
            this.AddCordin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCordin.Name = "AddCordin";
            this.AddCordin.Size = new System.Drawing.Size(103, 22);
            this.AddCordin.TabIndex = 3;
            this.AddCordin.Text = "Addcordinates";
            this.AddCordin.UseVisualStyleBackColor = true;
            this.AddCordin.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "doorX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "doorY";
            // 
            // obstacleX
            // 
            this.obstacleX.Location = new System.Drawing.Point(380, 68);
            this.obstacleX.Name = "obstacleX";
            this.obstacleX.Size = new System.Drawing.Size(61, 23);
            this.obstacleX.TabIndex = 7;
            // 
            // obstacleY
            // 
            this.obstacleY.Location = new System.Drawing.Point(380, 139);
            this.obstacleY.Name = "obstacleY";
            this.obstacleY.Size = new System.Drawing.Size(57, 23);
            this.obstacleY.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "obstacleX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "obstacleY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.obstacleY);
            this.Controls.Add(this.obstacleX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCordin);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.internaldoory);
            this.Controls.Add(this.Internaldoorx);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Internaldoorx;
        private System.Windows.Forms.TextBox internaldoory;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button AddCordin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox obstacleX;
        private System.Windows.Forms.TextBox obstacleY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}