using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;

using TypingMonkey.Control;
using TypingMonkey.Entity;

namespace TypingMonkey
{
    /// <summary>
    /// A Few commonly understood enumerations.
    /// </summary>
    enum InputType
    { 
        PopulationSize = 0,
        InputText
    };

    enum PreyType
    { 
        EvoString = 0
    };

    enum PredatorType
    { 
        EvoStringPredator = 0
    };


    public partial class MainForm : Form
    {
        /// <summary>
        /// Declare and initialize InputValidator Member.
        /// </summary>
        private InputValidator validator = new InputValidator();

        /// <summary>
        /// Evolution Manager Control Object - needs to be instatiated each time evolution starts.
        /// </summary>
        private EvolutionManager evolutionManager = null;

        public MainForm()
        {
            InitializeComponent();
            PopSizeNumUpDown_ValueChanged(this, null);
        }

        private void EvolveButton_Click(object sender, EventArgs e)
        {
            this.EnableUIInput(false);

            List<Object> errorList = this.validator.ValidateInput((int)this.PopSizeNumUpDown.Value, this.InputBox.Text);

            this.ClearOutputConsole();
            this.PrintToOutputConsole("-- Start Of Process --" + System.Environment.NewLine);

            try
            {
                // Throws an exception if any problem.
                this.CheckErrorList(errorList);

                this.PrintToOutputConsole("-- Start Evolution --");

                // Main Bulk of functionality Starts here.
                this.GuideEvolution();

                this.PrintToOutputConsole("-- End of Evolution --" + System.Environment.NewLine);
            }
            catch (InvalidInputException invalidInputException)
            {
                this.PrintToOutputConsole("Validation Error: " + invalidInputException.Message + System.Environment.NewLine);
            }
            catch (Exception genericException)
            {
                this.PrintToOutputConsole("Generic Error: " + genericException.Message + System.Environment.NewLine);
            }
            finally 
            {
                this.PrintToOutputConsole("-- End Of Process --");
                this.ScrollOutputConsoleToEnd();
                this.EnableUIInput(true);
            }
        }

        private void PopSizeNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.DisclaimerLabel.Text = String.Format(AppResources.Disclaimer, this.PopSizeNumUpDown.Value);
        }

        private void GuideEvolution()
        {
            // Instatiate Evolution Manager - setup Evolution.
            this.evolutionManager = new EvolutionManager((int)this.PopSizeNumUpDown.Value, this.InputBox.Text);

            IPrey mostFit = this.evolutionManager.GetMostFit();

            while ((mostFit != null) && (mostFit.ToString() != this.InputBox.Text))
            {
                int generationNo = this.evolutionManager.IterationCount;
                
                this.PrintToOutputConsole(String.Format("Best: {0} ({1})",mostFit.ToString(), generationNo));

                // Evolve next generation.
                mostFit = this.evolutionManager.EvolveGeneration();

                this.ScrollOutputConsoleToEnd();

                // Necessary Evil!
                Application.DoEvents();
            }

            if (mostFit != null)
            {
                // Final result.
                this.PrintToOutputConsole(String.Format("Best: {0} ({1})", mostFit.ToString(), this.evolutionManager.IterationCount));
            }
            else
            {
                // Generation Limit Reached.
                this.PrintToOutputConsole(String.Format("Generation Limit Reached: {0}", this.evolutionManager.IterationCount));
            }
        }

        /// <summary>
        /// Checks errorList and throws and exception if any invalid result.
        /// </summary>
        /// <param name="errorList"></param>
        private void CheckErrorList(List<Object> errorList)
        {
            /// Unboxing - from Object (reference type) to bool (value built-in type)
            bool isPopulationSizeValid = (bool)errorList[(int)InputType.PopulationSize];
            bool isInputTextLengthValid = (bool)errorList[(int)InputType.InputText];

            string errorMsg = string.Empty;

            /// Throwing specialised exception with custom errorMessage
            if (!isPopulationSizeValid && !isInputTextLengthValid)
            { 
                errorMsg = String.Format("Population Size ({0}-{1}) and Input Text Lenght ({2}-{3}) are invalid", 
                                         this.validator.MinPopulationSize, this.validator.MaxPopulationSize,
                                         this.validator.MinInputText, this.validator.MaxInputText);

                throw new InvalidInputException(errorMsg);
            }
            else if (!isPopulationSizeValid)
            {
                errorMsg = String.Format("Population Size ({0}-{1}) is invalid",
                                         this.validator.MinPopulationSize, this.validator.MaxPopulationSize);

                throw new InvalidInputException(errorMsg);
            }
            else if (!isInputTextLengthValid)
            {
                errorMsg = String.Format("Input Text Lenght ({0}-{1}) is invalid",
                                         this.validator.MinInputText, this.validator.MaxInputText);

                throw new InvalidInputException(errorMsg);
            }
        }

        void ClearOutputConsole()
        {
            this.OutputBox.Text = string.Empty;
        }

        void PrintToOutputConsole(string message)
        {
            string messageLine = message + System.Environment.NewLine;
            this.OutputBox.Text += messageLine;
        }

        void ScrollOutputConsoleToEnd()
        {
            this.OutputBox.SelectionStart = this.OutputBox.Text.Length - 1;
            this.OutputBox.ScrollToCaret();
        }

        void EnableUIInput(bool enable)
        {
            this.InputBox.Enabled = enable;
            this.OutputBox.Enabled = enable;
            this.PopSizeNumUpDown.Enabled = enable;
            this.EvolveButton.Enabled = enable;
            this.toolTipHelp.Active = enable;
        }
    }
}
