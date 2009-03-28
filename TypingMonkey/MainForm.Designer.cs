namespace TypingMonkey
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.EvolveButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.PopSizeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.PopSizeLabel = new System.Windows.Forms.Label();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopSizeNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // EvolveButton
            // 
            this.EvolveButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvolveButton.Location = new System.Drawing.Point(1, 619);
            this.EvolveButton.Name = "EvolveButton";
            this.EvolveButton.Size = new System.Drawing.Size(434, 50);
            this.EvolveButton.TabIndex = 0;
            this.EvolveButton.Text = "Evolve Input text!";
            this.EvolveButton.UseVisualStyleBackColor = true;
            this.EvolveButton.Click += new System.EventHandler(this.EvolveButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(1, 405);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputBox.Size = new System.Drawing.Size(434, 208);
            this.OutputBox.TabIndex = 1;
            this.OutputBox.Text = "Output Console";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 280);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.toolTipHelp.SetToolTip(this.pictureBox1, "TypingMonkey is a very nice app that will evolve your input text using a super-co" +
                    "ol genetic algorithm,\r\nstarting from a population of randomly generated strings " +
                    "(typed by me - the monkey)!");
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(1, 331);
            this.InputBox.MaxLength = 1000;
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(434, 68);
            this.InputBox.TabIndex = 3;
            this.InputBox.Text = "Put text to evolve here";
            this.toolTipHelp.SetToolTip(this.InputBox, "If your input is quite long make sure to go out for lunch. \r\nAnd make it a big on" +
                    "e!");
            // 
            // PopSizeNumUpDown
            // 
            this.PopSizeNumUpDown.Location = new System.Drawing.Point(292, 306);
            this.PopSizeNumUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PopSizeNumUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PopSizeNumUpDown.Name = "PopSizeNumUpDown";
            this.PopSizeNumUpDown.Size = new System.Drawing.Size(143, 23);
            this.PopSizeNumUpDown.TabIndex = 4;
            this.toolTipHelp.SetToolTip(this.PopSizeNumUpDown, "The longer your input text the bigger the population should be! \r\nFor 10 characte" +
                    "r strings an ideal popualtion is around 2000");
            this.PopSizeNumUpDown.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.PopSizeNumUpDown.ValueChanged += new System.EventHandler(this.PopSizeNumUpDown_ValueChanged);
            // 
            // PopSizeLabel
            // 
            this.PopSizeLabel.AutoSize = true;
            this.PopSizeLabel.Location = new System.Drawing.Point(289, 285);
            this.PopSizeLabel.Name = "PopSizeLabel";
            this.PopSizeLabel.Size = new System.Drawing.Size(146, 18);
            this.PopSizeLabel.TabIndex = 5;
            this.PopSizeLabel.Text = "Initial Population Size";
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisclaimerLabel.Location = new System.Drawing.Point(1, 285);
            this.DisclaimerLabel.MaximumSize = new System.Drawing.Size(290, 0);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(198, 18);
            this.DisclaimerLabel.TabIndex = 6;
            this.DisclaimerLabel.Text = "Typing Monkey ROCKS HARD!";
            // 
            // toolTipHelp
            // 
            this.toolTipHelp.AutoPopDelay = 10000;
            this.toolTipHelp.InitialDelay = 500;
            this.toolTipHelp.IsBalloon = true;
            this.toolTipHelp.ReshowDelay = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 672);
            this.Controls.Add(this.DisclaimerLabel);
            this.Controls.Add(this.PopSizeLabel);
            this.Controls.Add(this.PopSizeNumUpDown);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.EvolveButton);
            this.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(454, 715);
            this.MinimumSize = new System.Drawing.Size(454, 715);
            this.Name = "MainForm";
            this.Text = "TypingMonkey";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopSizeNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EvolveButton;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.NumericUpDown PopSizeNumUpDown;
        private System.Windows.Forms.Label PopSizeLabel;
        private System.Windows.Forms.Label DisclaimerLabel;
        private System.Windows.Forms.ToolTip toolTipHelp;
    }
}

