namespace ModalDialogBoxes
{
    partial class Options
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
            this.sugarRadioButton = new System.Windows.Forms.RadioButton();
            this.aspertameRadioButton = new System.Windows.Forms.RadioButton();
            this.cornSyrupRadioButton = new System.Windows.Forms.RadioButton();
            this.beverageDropDown = new System.Windows.Forms.ComboBox();
            this.beverageSelectLabel = new System.Windows.Forms.Label();
            this.sweetSelectLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sugarRadioButton
            // 
            this.sugarRadioButton.AutoSize = true;
            this.sugarRadioButton.Location = new System.Drawing.Point(214, 72);
            this.sugarRadioButton.Name = "sugarRadioButton";
            this.sugarRadioButton.Size = new System.Drawing.Size(77, 24);
            this.sugarRadioButton.TabIndex = 0;
            this.sugarRadioButton.TabStop = true;
            this.sugarRadioButton.Text = "Sugar";
            this.sugarRadioButton.UseVisualStyleBackColor = true;
            this.sugarRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // aspertameRadioButton
            // 
            this.aspertameRadioButton.AutoSize = true;
            this.aspertameRadioButton.Location = new System.Drawing.Point(214, 132);
            this.aspertameRadioButton.Name = "aspertameRadioButton";
            this.aspertameRadioButton.Size = new System.Drawing.Size(112, 24);
            this.aspertameRadioButton.TabIndex = 0;
            this.aspertameRadioButton.TabStop = true;
            this.aspertameRadioButton.Text = "Aspertame";
            this.aspertameRadioButton.UseVisualStyleBackColor = true;
            this.aspertameRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cornSyrupRadioButton
            // 
            this.cornSyrupRadioButton.AutoSize = true;
            this.cornSyrupRadioButton.Location = new System.Drawing.Point(214, 102);
            this.cornSyrupRadioButton.Name = "cornSyrupRadioButton";
            this.cornSyrupRadioButton.Size = new System.Drawing.Size(113, 24);
            this.cornSyrupRadioButton.TabIndex = 0;
            this.cornSyrupRadioButton.TabStop = true;
            this.cornSyrupRadioButton.Text = "Corn Syrup";
            this.cornSyrupRadioButton.UseVisualStyleBackColor = true;
            // 
            // beverageDropDown
            // 
            this.beverageDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beverageDropDown.FormattingEnabled = true;
            this.beverageDropDown.Items.AddRange(new object[] {
            "Coca-Cola",
            "Sprite",
            "Fanta"});
            this.beverageDropDown.Location = new System.Drawing.Point(32, 68);
            this.beverageDropDown.Name = "beverageDropDown";
            this.beverageDropDown.Size = new System.Drawing.Size(121, 28);
            this.beverageDropDown.TabIndex = 1;
            this.beverageDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // beverageSelectLabel
            // 
            this.beverageSelectLabel.AutoSize = true;
            this.beverageSelectLabel.Location = new System.Drawing.Point(28, 45);
            this.beverageSelectLabel.Name = "beverageSelectLabel";
            this.beverageSelectLabel.Size = new System.Drawing.Size(143, 20);
            this.beverageSelectLabel.TabIndex = 2;
            this.beverageSelectLabel.Text = "Select a Beverage:";
            // 
            // sweetSelectLabel
            // 
            this.sweetSelectLabel.AutoSize = true;
            this.sweetSelectLabel.Location = new System.Drawing.Point(210, 45);
            this.sweetSelectLabel.Name = "sweetSelectLabel";
            this.sweetSelectLabel.Size = new System.Drawing.Size(152, 20);
            this.sweetSelectLabel.TabIndex = 2;
            this.sweetSelectLabel.Text = "Select a Sweetener:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(87, 184);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 38);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(227, 184);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 38);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 234);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sweetSelectLabel);
            this.Controls.Add(this.beverageSelectLabel);
            this.Controls.Add(this.beverageDropDown);
            this.Controls.Add(this.cornSyrupRadioButton);
            this.Controls.Add(this.aspertameRadioButton);
            this.Controls.Add(this.sugarRadioButton);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sugarRadioButton;
        private System.Windows.Forms.RadioButton aspertameRadioButton;
        private System.Windows.Forms.ComboBox beverageDropDown;
        private System.Windows.Forms.RadioButton cornSyrupRadioButton;
        private System.Windows.Forms.Label beverageSelectLabel;
        private System.Windows.Forms.Label sweetSelectLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}