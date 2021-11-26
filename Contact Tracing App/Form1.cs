using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
     
        private void Submit_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            String date = File.GetCreationTime("output.txt").ToLongDateString();
            outputFile = File.AppendText(date);
            outputFile.WriteLine(FirstName.Text);
            outputFile.WriteLine(Surname.Text);
            outputFile.WriteLine(MI.Text);
            outputFile.WriteLine(Temperature.Text);
            outputFile.WriteLine(email.Text);
            outputFile.WriteLine(address.Text);
            outputFile.WriteLine(Number.Text);
            outputFile.WriteLine("****************************");
            outputFile.Close();
            MessageBox.Show("Submitted", date, MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Your Code for submit 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "First Name";
            Surname.Text = "Surname";
            MI.Text = "M.I";
            Temperature.Text = "37.5";
            email.Text = "Username@gmail.com";
            address.Text = "House no., Street, Brgy, City";
            Number.Text = "639XXXXXXXXX";
            FirstName.ForeColor = Color.Silver;
            Surname.ForeColor = Color.Silver;
            MI.ForeColor = Color.Silver;
            Temperature.ForeColor = Color.Silver;
            email.ForeColor = Color.Silver;
            address.ForeColor = Color.Silver;
            Number.ForeColor = Color.Silver;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (FirstName.Text == "First Name")
            {
                FirstName.Text = "";
                FirstName.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "Surname")
            {
                Surname.Text = "";
                Surname.ForeColor = Color.Black;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (MI.Text == "M.I")
            {
                MI.Text = "";
                MI.ForeColor = Color.Black;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (Temperature.Text == "37.5")
            {
                Temperature.Text = "";
                Temperature.ForeColor = Color.Black;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Username@gmail.com")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (address.Text == "House no., Street, Brgy, City")
            {
                address.Text = "";
                address.ForeColor = Color.Black;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (Number.Text == "639XXXXXXXXX")
            {
                Number.Text = "";
                Number.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                FirstName.Text = "First Name";
                FirstName.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "Surname";
                Surname.ForeColor = Color.Silver;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (MI.Text == "")
            {
                MI.Text = "M.I";
                MI.ForeColor = Color.Silver;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (Temperature.Text == "")
            {
                Temperature.Text = "37.5";
                Temperature.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Username@gmail.com";
                email.ForeColor = Color.Silver;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (address.Text == "")
            {
                address.Text = "House no., Street, Brgy, City";
                address.ForeColor = Color.Silver;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (Number.Text == "")
            {
                Number.Text = "639XXXXXXXXX";
                Number.ForeColor = Color.Silver;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
