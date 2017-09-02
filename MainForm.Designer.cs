namespace ModalDialogBoxes
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
            this.optionsButton = new System.Windows.Forms.Button();
            this.sodaNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optionsButton
            // 
            this.optionsButton.Location = new System.Drawing.Point(314, 346);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(125, 41);
            this.optionsButton.TabIndex = 0;
            this.optionsButton.Text = "Options";
            this.optionsButton.UseVisualStyleBackColor = true;
            this.optionsButton.Click += new System.EventHandler(this.optionButton_Click);
            // 
            // sodaNameLabel
            // 
            this.sodaNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sodaNameLabel.Location = new System.Drawing.Point(-1, 115);
            this.sodaNameLabel.Name = "sodaNameLabel";
            this.sodaNameLabel.Size = new System.Drawing.Size(757, 163);
            this.sodaNameLabel.TabIndex = 1;
            this.sodaNameLabel.Text = "Soda";
            this.sodaNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 441);
            this.Controls.Add(this.sodaNameLabel);
            this.Controls.Add(this.optionsButton);
            this.Name = "MainForm";
            this.Text = "Soda Picker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Label sodaNameLabel;
    }
}

