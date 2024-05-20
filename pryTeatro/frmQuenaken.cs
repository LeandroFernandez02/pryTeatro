using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTeatro
{
    public partial class frmQuenaken : Form
    {
        public frmQuenaken()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Lista para almacenar las posiciones seleccionadas
            List<string> posicionesSeleccionadas = new List<string>();

            // Recorrer solo los CheckBox en el formulario
            foreach (CheckBox checkBox in Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    // Obtener el nombre del CheckBox que contiene la posición del asiento
                    string posicion = checkBox.Name;
                    posicionesSeleccionadas.Add(posicion);
                }
            }

            // Mostrar las posiciones seleccionadas en el Label
            lblSeleccionado.Text = string.Join(", ", posicionesSeleccionadas);
        }
    }
}
