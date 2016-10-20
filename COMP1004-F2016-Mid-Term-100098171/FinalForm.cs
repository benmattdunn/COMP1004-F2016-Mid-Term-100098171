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
    public partial class FinalForm : Form
    {
        /// <summary>
        /// declares private variables
        /// </summary>
        private string _selectedRace; 
        public RaceAndClassForm previousForm { get; set; }

        /// <summary>
        /// intitalizes instance
        /// </summary>
        public FinalForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// calls the about button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }


        /// <summary>
        /// brings back the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        /// <summary>
        /// exits the aplication
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// shows the final values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalForm_Load(object sender, EventArgs e)
        {
            this.FirstNameTextBox.Text = Program.character.firstName;
            this.LastNameTextBox.Text = Program.character.lastName;
            this.StrengthTextBox.Text = Program.character.Strength;
            this.DexterityTextBox.Text = Program.character.Dexterity;
            this.ConstitutionTextBox.Text = Program.character.Constitution;
            this.WisdomTextBox.Text = Program.character.Wisdom;
            this.IntelligenceTextBox.Text = Program.character.Intelligence;
            this.CharismaTextBox.Text = Program.character.Charisma;
            this.RaceTextBox.Text = Program.character.Race;
            this._selectedRace = Program.character.Race;
            RacePictureShow();
        }

        /// <summary>
        /// Shows the race picture based on selection
        /// </summary>
        private void RacePictureShow()
        {
            if (this._selectedRace.Equals("Human"))
            {
                this.RacePictureBox.BackgroundImage = global::COMP1004_F2016_Mid_Term_100098171.Properties.Resources.Human_Male;

            }
            else if (this._selectedRace.Equals("Elf"))
            {
                this.RacePictureBox.BackgroundImage = global::COMP1004_F2016_Mid_Term_100098171.Properties.Resources.Elf_Female;

            }
            else if (this._selectedRace.Equals("Dwarf"))
            {
                this.RacePictureBox.BackgroundImage = global::COMP1004_F2016_Mid_Term_100098171.Properties.Resources.Dwarf_Male;
            }
            else if (this._selectedRace.Equals("Halfling"))
            {
                this.RacePictureBox.BackgroundImage = global::COMP1004_F2016_Mid_Term_100098171.Properties.Resources.Halfling_Female;
            }

        }
    }
}
