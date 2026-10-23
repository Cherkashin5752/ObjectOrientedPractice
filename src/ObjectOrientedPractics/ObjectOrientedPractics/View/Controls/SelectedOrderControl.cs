using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class SelectedOrderControl : UserControl
    {
        public SelectedOrderControl()
        {
            InitializeComponent();

            addressControl1.ReadOnly = true;
        }
    }
}
