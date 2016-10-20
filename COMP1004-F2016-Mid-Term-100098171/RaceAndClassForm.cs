using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
/// Creates a form that allows a user to select race. 
/// </summary>

namespace COMP1004_F2016_Mid_Term_100098171
{
    public partial class RaceAndClassForm : Form
    {
        //sets up some defaults
        public AbilityGeneratorForm previousForm;
        private string _selectedRace = "Human"; //default value added

        /// <summary>
        /// boots up the program. 
        /// </summary>
        public RaceAndClassForm()
        {
            InitializeComponent();
            Program.character.Race = this._selectedRace;
        }

        /// <summary>
        /// returns to the previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        /// <summary>
        /// changes the race and race picture upon changing the race radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
            RacePictureShow();
        }
        /// <summary>
        /// Shows the race picture based on selection
        /// </summary>
        private void RacePictureShow ()
        {
            if (this._selectedRace.Equals("Human"))
            {
                this.RacePictureBox.BackgroundImage = global::COMP1004_F2016_Mid_Term_100098171.Properties.Resources.Human_Male;

            } else if (this._selectedRace.Equals("Elf"))
            {
                this.RacePictureBox.BackgroundImage = global::COMP1004_F2016_Mid_Term_100098171.Properties.Resources.Elf_Female;

            } else if (this._selectedRace.Equals("Dwarf"))
            {
                this.RacePictureBox.BackgroundImage = global::COMP1004_F2016_Mid_Term_100098171.Properties.Resources.Dwarf_Male;
            }
            else if (this._selectedRace.Equals("Halfling"))
            {
                this.RacePictureBox.BackgroundImage = global::COMP1004_F2016_Mid_Term_100098171.Properties.Resources.Halfling_Female;
            }      
                
        }

        /// <summary>
        /// moves along to the next for, in this case the final form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            
            Program.character.Race = this._selectedRace;
            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;
            finalForm.Show();
            this.Hide();
        }

        /// <summary>
        /// brings in the previously selected race if selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RaceAndClassForm_Load(object sender, EventArgs e)
        {
            this._selectedRace = Program.character.Race;
            if (_selectedRace.Equals("Human"))
            {
                this.HumanRadioButton.Checked = true;
            } else if (_selectedRace.Equals("Elf"))
            {
                this.ElfRadioButton.Checked = true;
            }
            else if (_selectedRace.Equals("Dwarf"))
            {
                this.DwarfRadioButton.Checked = true;
            }
            else if (_selectedRace.Equals("Halfling"))
            {
                this.HalflingRadioButton.Checked = true;
            }


        }
    }
}
