using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceDistribution
{
    public partial class FormDiceDistrubtion : Form
    {
        public FormDiceDistrubtion()
        {
            InitializeComponent();
        }

        private void FormDiceDistrubtion_Load(object sender, EventArgs e)
        {

        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfThrows;
                int numberOfDice;
                // NumberOfThrows
                try
                {
                    numberOfThrows = Convert.ToInt32(textBoxNumberOfThrows.Text.Trim());
                }
                catch
                {
                    throw new Exception(" NumberOfThrows: " + textBoxNumberOfThrows.Text.Trim() + ", must be a valid integer.");     // error trapping for numberOfThrows if not valid int
                }
                if (numberOfThrows < 0)
                {
                    // used this for more elagant error trapping
                    // https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exceptions
                    throw new Exception("Number entered in 'NumberOfThrows' can not be less than 0");                  // throwing exeption on a validation error for numberOfThrows
                }

                // NumberOfDice
                try
                {
                    numberOfDice = Convert.ToInt32(textBoxNumberOfDice.Text.Trim());
                }
                catch
                {
                    throw new Exception(" NumberOfDice: " + textBoxNumberOfDice.Text.Trim() + ", must be a valid integer.");     // error trapping for numberOfDice if not valid int
                }
                if (numberOfDice < 0)
                {
                    throw new Exception("Number entered in 'NumberOfDice' can not be less than 0");                  // throwing exeption on a validation error for numberOfDice
                }

                KMCDiceRoller diceRoller = new KMCDiceRoller(numberOfThrows);
                String[] rows = diceRoller.Throw(numberOfDice);

                // clear list each time you click button
                listBoxResults.Items.Clear();
                for (int i = 0; i < rows.Length; i++)
                {
                    listBoxResults.Items.Add(rows[i]);
                }
            }
            // catching all validation and program errors for display in a message box
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
