using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace SistemaBibliosfera
{
    public partial class FrmDashboard : Form
    {
        ManejadorDashboard Md;
        public FrmDashboard()
        {
            InitializeComponent();

            Md = new ManejadorDashboard();
        }
    }
}
