using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// DND character generator
/// Tom T. & Ben Dunn
/// Created 2016, oct 20
/// 
/// Creates a form that is a splash screen for program load
/// </summary>
namespace COMP1004_F2016_Mid_Term_100098171
{
    
    public partial class SplashForm : Form
    {
        //declare scope variables
        private bool OnlyOnce = true;
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// triggers the load of the other forms after displaying a splash screen for a limited
        /// amounf of time. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (OnlyOnce) {
                this.Hide();
                //generate all the forms, but do not show them. 
                GenerateNameForm nameForm = new GenerateNameForm();
                
                nameForm.Show();
                OnlyOnce = false;
                //this.Close(); // dispose after hiding. was having slight issue, hid instead. 
            }
            
            

        }
    }
}
