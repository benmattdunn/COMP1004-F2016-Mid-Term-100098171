using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_100098171
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {

            InitializeComponent();
            
            
        }
        /// <summary>
        /// generates a random name
        /// </summary>
        private void GenerateName ()
        {
            Random random = new Random();
            int randomNumberOne = random.Next(1, FirstNameListBox.Items.Count);
            int randomNumberTwo = random.Next(1, LastNameListBox.Items.Count);
            
            

            FirstNameListBox.Select();
            FirstNameListBox.SelectedItem = FirstNameListBox.Items[randomNumberOne];

            LastNameListBox.Select();
            LastNameListBox.SelectedItem = LastNameListBox.Items[randomNumberTwo];
            this.FirstNameTextBox.Text = FirstNameListBox.GetItemText(FirstNameListBox.SelectedItem);
            this.LastNameTextBox.Text = LastNameListBox.GetItemText(LastNameListBox.SelectedItem);
            Program.character.firstName = this.FirstNameTextBox.Text;
            Program.character.lastName = this.LastNameTextBox.Text;
        }
        /// <summary>
        /// /calls the generate name procedure
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateName();
        }

        /// <summary>
        /// calls the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.previousForm = this;
            this.Hide();
            abilityGeneratorForm.Show();

        }

        /// <summary>
        /// calls the generation of random names on next
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateName();
        }
    }
}
