using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezM_controlTiempo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        int tiempo = 0;

        private void btnTrabajo_Click(object sender, EventArgs e)
        {
            if (btnTrabajo.Text == "Trabajo")
            {
                btnTrabajo.Text = "Finalizar";
                btnTrabajo.BackColor = Color.Red;
                timerTrab.Enabled = true;
                
            }
            else if (btnTrabajo.Text == "Finalizar")
            {
                btnTrabajo.Text = "Trabajo";
                btnTrabajo.BackColor = Color.DarkGreen;
                timerTrab.Enabled = false;
                toolStripStatuslblResul.Text = (tiempo).ToString();
                
            }
        }

        private void timerTrab_Tick(object sender, EventArgs e)
        {
            toolStripStatuslblTiempo.Text = (tiempo++).ToString();
            toolStripStatuslblTiempo.Text = (tiempo).ToString();

        }


    }
}
