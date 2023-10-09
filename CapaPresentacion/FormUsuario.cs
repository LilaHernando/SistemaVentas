using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Consumimos Utilidades
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            //Agregamos Items al Combo Estado por medio del Objeto OpcionCombo ubicado en la carpeta Utilidades
            comboEstado.Items.Add(new OpcionCombo()
            {
                //La clase OpcionCombo maneja dos atributos, "Valor" que es de tipo object t "Texto" que es de tipo string
                Valor = 1,
                Texto = "Activo"
            });
            comboEstado.Items.Add(new OpcionCombo()
            {
                Valor = 0,
                Texto = "Inactivo"
            });
            comboEstado.DisplayMember = "Texto"; //De manera visual (En el Formulario) se vera el Texto
            comboEstado.ValueMember = "Valor"; // Y como valor del campo (Atras, en la logica) maneja Valor
            comboEstado.SelectedIndex = 0; // Inicia en 0, o sea la primera opción, que seria "Activo"
        }
    }
}
