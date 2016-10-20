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
using FontAwesome.Sharp;


/// <summary>
/// 
/// <summary>
/// DND character generator
/// Tom T. & Ben Dunn
/// Created 2016, oct 20
/// 
/// Creates a form that allows a user to generate abilites
/// </summary>
/// </summary>

namespace COMP1004_F2016_Mid_Term_100098171
{
    public partial class AbilityGeneratorForm : Form
    {
        // private Instance Object
        private Random _random;
        public GenerateNameForm previousForm; 

        /// <summary>
        /// starts every thing up
        /// </summary>
        public AbilityGeneratorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// roll function for generating abilites
        /// </summary>
        /// <returns></returns>
        private Int32 Roll()
        {
            // create new empty list
            List<Int32> numbers = new List<Int32>();
            int result = 0;

            // roll 4 dice
            for (int count = 0; count < 4; count++)
            {
                int generatedNumber = this._random.Next(0, 6) + 1;
                numbers.Add(generatedNumber);
            }

            // drop the lowest die
            numbers.Remove(numbers.Min());

            // add the numbers to the result

            foreach (int number in numbers)
            {
                result += number;
            }

            // lambda expression equivalent
            //result = numbers.Sum(number => number);

            return result;
        }

        /// <summary>
        /// attaches rolls to text boxews
        /// </summary>
        private void GenerateAbilities()
        {
            StrengthTextBox.Text = this.Roll().ToString();
            DexterityTextBox.Text = this.Roll().ToString();
            ConstitutionTextBox.Text = this.Roll().ToString();
            IntelligenceTextBox.Text = this.Roll().ToString();
            WisdomTextBox.Text = this.Roll().ToString();
            CharismaTextBox.Text = this.Roll().ToString();
        }

        /// <summary>
        /// calls the random ability generate upon button select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();
        }


        /// <summary>
        /// calls the generate abilies upon load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            this._random = new Random(); // initialize random number object

            GenerateAbilities();

        }

        /// <summary>
        /// moves the values of the character into the memmorry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Strength = StrengthTextBox.Text;
            character.Dexterity = DexterityTextBox.Text;
            character.Constitution = ConstitutionTextBox.Text;
            character.Intelligence = IntelligenceTextBox.Text;
            character.Wisdom = WisdomTextBox.Text;
            character.Charisma = CharismaTextBox.Text;

            // Step 1 - Hide the parent form
            this.Hide();

            // Step 2 - Instantiate an object for the form type
            // you are going to next
            RaceAndClassForm raceAndClassForm = new RaceAndClassForm();
            

            // Step 3 - create a property in the next form that 
            // we will use to point to this form
            // e.g. public AbilityGeneratorForm previousForm;

            // Step 4 - point this form to the parent Form 
            // property in the next form
            raceAndClassForm.previousForm = this;

            // Step 5 - Show the next form
            raceAndClassForm.Show();
        }

        /// <summary>
        /// calls the back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();

        }
        /// <summary>
        /// Calls the switch function and switches the selected items. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchButton_Click(object sender, EventArgs e)
        {
            string firstSwitch = switchAbilitesFirst();
            string secondSwitch = switchAbilitesSecond();

            //MessageBox.Show(firstSwitch + secondSwitch);

            if (!firstSwitch.Equals("null") || !secondSwitch.Equals("null"))
            {
                if (this.SwitchFromBox.SelectedIndex == 0)
                {
                    this.StrengthTextBox.Text = secondSwitch;
                }
                else if (this.SwitchFromBox.SelectedIndex == 1)
                {
                    this.DexterityTextBox.Text = secondSwitch;
                }
                else if (this.SwitchFromBox.SelectedIndex == 2)
                {
                    this.ConstitutionTextBox.Text = secondSwitch;
                }
                else if (this.SwitchFromBox.SelectedIndex == 3)
                {
                    this.IntelligenceTextBox.Text = secondSwitch;
                }
                else if (this.SwitchFromBox.SelectedIndex == 4)
                {
                    this.WisdomTextBox.Text = secondSwitch;
                }
                else if (this.SwitchFromBox.SelectedIndex == 5)
                {
                    this.IntelligenceTextBox.Text = secondSwitch;
                }

                if (this.SwitchTwoBox.SelectedIndex == 0)
                {
                    this.StrengthTextBox.Text = firstSwitch;
                }
                else if (this.SwitchTwoBox.SelectedIndex == 1)
                {
                    this.DexterityTextBox.Text = firstSwitch;
                }
                else if (this.SwitchTwoBox.SelectedIndex == 2)
                {
                    this.ConstitutionTextBox.Text = firstSwitch;
                }
                else if (this.SwitchTwoBox.SelectedIndex == 3)
                {
                    this.IntelligenceTextBox.Text = firstSwitch;
                }
                else if (this.SwitchTwoBox.SelectedIndex == 4)
                {
                    this.WisdomTextBox.Text = firstSwitch;
                }
                else if (this.SwitchTwoBox.SelectedIndex == 5)
                {
                    this.IntelligenceTextBox.Text = firstSwitch;
                }

            }
        }

        /// <summary>
        /// switches the abilities arround, first step
        /// </summary>
        private string switchAbilitesFirst ()
        {
            string switchFrom = "null";
            
            if (this.SwitchFromBox.SelectedIndex == 0)
            {
                switchFrom = this.StrengthTextBox.Text;
            } else if (this.SwitchFromBox.SelectedIndex == 1)
            {
                switchFrom = this.DexterityTextBox.Text;
            }
            else if (this.SwitchFromBox.SelectedIndex == 2)
            {
                switchFrom = this.ConstitutionTextBox.Text;
            }
            else if (this.SwitchFromBox.SelectedIndex == 3)
            {
                switchFrom = this.IntelligenceTextBox.Text;
            }
            else if (this.SwitchFromBox.SelectedIndex == 4)
            {
                switchFrom = this.WisdomTextBox.Text;
            } else if(this.SwitchFromBox.SelectedIndex == 5)
            {
                switchFrom = this.IntelligenceTextBox.Text;
            }
            return switchFrom;
        }

        /// <summary>
        /// switches the abilities arround, first step
        /// </summary>
        private string switchAbilitesSecond()
        {
            string switchFrom = "null";

            if (this.SwitchTwoBox.SelectedIndex == 0)
            {
                switchFrom = this.StrengthTextBox.Text;
            }
            else if (this.SwitchTwoBox.SelectedIndex == 1)
            {
                switchFrom = this.DexterityTextBox.Text;
            }
            else if (this.SwitchTwoBox.SelectedIndex == 2)
            {
                switchFrom = this.ConstitutionTextBox.Text;
            }
            else if (this.SwitchTwoBox.SelectedIndex == 3)
            {
                switchFrom = this.IntelligenceTextBox.Text;
            }
            else if (this.SwitchTwoBox.SelectedIndex == 4)
            {
                switchFrom = this.WisdomTextBox.Text;
            }
            else if (this.SwitchTwoBox.SelectedIndex == 5)
            {
                switchFrom = this.IntelligenceTextBox.Text;
            }

            return switchFrom;

        }
    }
}
