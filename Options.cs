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
    public partial class Options : Form
    {
        public enum BeverageType { CocaCola, Sprite, Fanta };
        public enum SweetenerType { CaneSugar, CornSyrup, Aspertame};

        public BeverageType SelectedBeverage
        {
            get
            {
                if (beverageDropDown.SelectedItem.ToString() == "Coca-Cola")
                    return BeverageType.CocaCola;
                else if (beverageDropDown.SelectedItem.ToString() == "Sprite")
                    return BeverageType.Sprite;
                else
                    return BeverageType.Fanta;
            }

            set
            {
                if (value == BeverageType.CocaCola)
                    beverageDropDown.SelectedItem = "Coca-Cola";
                else if (value == BeverageType.Sprite)
                    beverageDropDown.SelectedItem = "Sprite";
                else
                    beverageDropDown.SelectedItem = "Fanta";
            }
        }


        public SweetenerType SelectedSweetener
        {
            get
            {
                if (caneSugarRadioButton.Checked == true)
                    return SweetenerType.CaneSugar;
                else if (cornSyrupRadioButton.Checked == true)
                    return SweetenerType.CornSyrup;
                else
                    return SweetenerType.Aspertame;
            }

            set
            {
                if (value == SweetenerType.CaneSugar)
                    caneSugarRadioButton.Checked = true;
                else if (value == SweetenerType.CornSyrup)
                    cornSyrupRadioButton.Checked = true;
                else
                    aspertameRadioButton.Checked = true;
            }
        }

        public Options()
        {
            InitializeComponent();
        }
    }
}
