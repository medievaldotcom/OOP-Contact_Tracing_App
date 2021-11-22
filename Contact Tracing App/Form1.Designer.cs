
namespace Contact_Tracing_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.MI = new System.Windows.Forms.TextBox();
            this.Temperature = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.FirstName.Location = new System.Drawing.Point(80, 20);
            this.FirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(303, 34);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            this.FirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.FirstName.Enter += new System.EventHandler(this.textBox1_Enter);
            this.FirstName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Surname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Surname.Location = new System.Drawing.Point(80, 67);
            this.Surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(215, 34);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            this.Surname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Surname.Enter += new System.EventHandler(this.textBox2_Enter);
            this.Surname.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // MI
            // 
            this.MI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MI.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.MI.Location = new System.Drawing.Point(303, 67);
            this.MI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MI.Name = "MI";
            this.MI.Size = new System.Drawing.Size(81, 34);
            this.MI.TabIndex = 3;
            this.MI.Text = "M.I";
            this.MI.Enter += new System.EventHandler(this.textBox3_Enter);
            this.MI.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // Temperature
            // 
            this.Temperature.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Temperature.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Temperature.Location = new System.Drawing.Point(131, 113);
            this.Temperature.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(252, 34);
            this.Temperature.TabIndex = 4;
            this.Temperature.Text = "37.5";
            this.Temperature.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.Temperature.Enter += new System.EventHandler(this.textBox4_Enter);
            this.Temperature.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.email.Location = new System.Drawing.Point(463, 76);
            this.email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(301, 34);
            this.email.TabIndex = 5;
            this.email.Text = "Username@gmail.com";
            this.email.Enter += new System.EventHandler(this.textBox5_Enter);
            this.email.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(390, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(390, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(389, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 56);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mobile#/\r\nPhone#";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(530, 175);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 69);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "Clear All";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(649, 175);
            this.Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(113, 69);
            this.Submit.TabIndex = 11;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.address.Location = new System.Drawing.Point(477, 118);
            this.address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(287, 34);
            this.address.TabIndex = 12;
            this.address.Text = "House no., Street, Brgy, City";
            this.address.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.address.Enter += new System.EventHandler(this.textBox6_Enter);
            this.address.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Number.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Number.Location = new System.Drawing.Point(489, 29);
            this.Number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(261, 34);
            this.Number.TabIndex = 13;
            this.Number.Tag = "";
            this.Number.Text = "639XXXXXXXXX";
            this.Number.Enter += new System.EventHandler(this.textBox7_Enter);
            this.Number.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 262);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.address);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.MI);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Contact Tracing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox MI;
        private System.Windows.Forms.TextBox Temperature;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox Number;
    }
}

