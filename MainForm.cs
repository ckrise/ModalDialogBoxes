using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialogBoxes
{
    public partial class MainForm : Form
    {
        private Options.BeverageType beverageType = Options.BeverageType.CocaCola;
        private Options.SweetenerType sweetenerType = Options.SweetenerType.CornSyrup;

        public MainForm()
        {
            InitializeComponent();
        }

        private void optionButton_Click(object sender, EventArgs e)
        {
            Options optionsForm = new Options
            {
                SelectedBeverage = beverageType,
                SelectedSweetener = sweetenerType
            };
            
            if (optionsForm.ShowDialog() == DialogResult.OK)
            {
                beverageType = optionsForm.SelectedBeverage;
                sweetenerType = optionsForm.SelectedSweetener;

                displaySodaType();                
            }
        }

        private void displaySodaType()
        {
            if (beverageType == Options.BeverageType.CocaCola)
            {
                if (sweetenerType == Options.SweetenerType.Aspertame)
                    sodaNameLabel.Text = "Diet Coke";
                else if (sweetenerType == Options.SweetenerType.CaneSugar)
                    sodaNameLabel.Text = "Mexican Coke";
                else
                    sodaNameLabel.Text = "Coca-Cola";
            }
            else if (beverageType == Options.BeverageType.Sprite)
            {
                if (sweetenerType == Options.SweetenerType.Aspertame)
                    sodaNameLabel.Text = "Sprite Zero";
                else if (sweetenerType == Options.SweetenerType.CaneSugar)
                    sodaNameLabel.Text = "Mexican Sprite";
                else
                    sodaNameLabel.Text = "Sprite";
            }
            else
            {
                if (sweetenerType == Options.SweetenerType.Aspertame)
                    sodaNameLabel.Text = "Fanta Zero";
                else if (sweetenerType == Options.SweetenerType.CaneSugar)
                    sodaNameLabel.Text = "Mexican Fanta";
                else
                    sodaNameLabel.Text = "Fanta";
            }
        }

    }
}
