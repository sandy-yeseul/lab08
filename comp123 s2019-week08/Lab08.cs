using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Yeseul Kang #301029474
namespace comp123_s2019_week08
{
    public partial class Lab08 : Form
    {
       public string UserName { get; set; }
        public float UserAge { get; set; }
        /// <summary>
        /// this is the constructor
        /// </summary>
        public Lab08()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// tgus us tge event handler for the submitButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            UserName = NameTextBox.Text;
            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;

            NameTextBox.Text = string.Empty; //better than ="";
            AgeTextBox.Text = string.Empty;
            
            
        }

        /// <summary>
        /// This is the event handler for the lab8form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08_Load(object sender, EventArgs e)
        {
            SubmitButton.Enabled = false;
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = true;
        }
    }
}
