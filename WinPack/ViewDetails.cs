using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPack
{
    public partial class ViewDetails : Form
    {
        public ViewDetails()
        {
            InitializeComponent();
        }

        public string CompressionInfo
        {
            set
            {
                txtDetails.Text = value;
            }
        }
    }
}
