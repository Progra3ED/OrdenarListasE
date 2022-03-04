using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdenarListasE
{
    public partial class Form1 : Form
    {
        List<Dato> datos = new List<Dato>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //Busca el valor del textbox en la lista y devuelve en que
            //posición lo encontró
            int posicion = datos.FindIndex(t => t.texto == textBox1.Text);

            //sino lo encuentra devuelve -1
            if (posicion == -1)
            {
                Dato dato = new Dato();
                dato.texto = textBox1.Text;
                dato.numero = (int)numericUpDown1.Value;
                dato.fecha = dateTimePicker1.Value;

                datos.Add(dato);
            }
            //SI lo encontro, le cambiamos los valores
            else 
            {
                datos[posicion].numero++;
                datos[posicion].fecha = DateTime.Now;
            }

        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = datos;
            dataGridView1.Refresh();
        }

        private void buttonOrdenarNumero_Click(object sender, EventArgs e)
        {
            datos = datos.OrderBy(x => x.numero).ToList();
            Mostrar();
        }

        private void buttonOrdenarFecha_Click(object sender, EventArgs e)
        {
            datos = datos.OrderBy(f => f.fecha).ToList();
            Mostrar();
        }

        private void buttonOrdenAlfabetico_Click(object sender, EventArgs e)
        {
            datos = datos.OrderByDescending(a => a.texto).ToList();
            Mostrar();
        }
    }
}
