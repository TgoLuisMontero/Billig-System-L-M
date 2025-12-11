using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace Billig_System_L_M
{
    public partial class frmProductos : Form
    {
        private CN_Producto negocio = new CN_Producto();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void txtProductoBuscar_TextChanged(object sender, EventArgs e)
        {
            tbProductos.DataSource = negocio.CN_buscar_Producto(txtProductoBuscar.Text);
        }
    }
}
