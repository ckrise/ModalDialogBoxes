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
            this.optionsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sodaNameLabel
            // 
            this.sodaNameLabel.AutoSize = true;
            this.sodaNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sodaNameLabel.Location = new System.Drawing.Point(180, 107);
            this.sodaNameLabel.Name = "sodaNameLabel";
            this.sodaNameLabel.Size = new System.Drawing.Size(405, 163);
            this.sodaNameLabel.TabIndex = 1;
            this.sodaNameLabel.Text = "Soda";
            this.sodaNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sodaNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 441);
            this.Controls.Add(this.sodaNameLabel);
            this.Controls.Add(this.optionsButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionsButton;
        private System.Windows.Forms.Label sodaNameLabel;
    }
}

