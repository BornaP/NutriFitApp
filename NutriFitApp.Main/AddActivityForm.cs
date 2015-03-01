using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NutriFitApp.Common;
namespace NutriFitApp.Main
{
    public partial class AddActivityForm : Form, IAddNewActivity
    {
        public AddActivityForm()
        {
            InitializeComponent();
        }

        public bool Show()
        {
            DialogResult res = this.ShowDialog();

            if (res == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ActivityName
        {
            get { return textBoxActivityName.Text; }
        }

        public int CaloriesLost
        {
            get { return Convert.ToInt32(numericUpDownCalLost.Value); }
        }

        public string ActivityType
        {
            get { return comboBoxActiType.Text.ToString(); }
        }
    }
}
