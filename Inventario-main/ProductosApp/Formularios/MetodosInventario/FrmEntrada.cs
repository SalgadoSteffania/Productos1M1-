using Domain.Entities;
using Domain.Enums;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Formularios.MetodosInventario
{
    public partial class FrmEntrada : Form
    {
        public ProductoModel ProductoModel;
        public int Count { get; set; }
        public FrmEntrada()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = ++Count,
                Nombre = txtNombre.Text,
                Descripcion = txtDesc.Text,
                Existencia = (int)nudExist.Value,
                Precio = nudPrice.Value,
                FechaVencimiento = dtpCaducity.Value,
                FechaDeRegistro = dtpFechaRegistro.Value,
                UnidadMedida = (UnidadMedida)cmbMeasureUnit.SelectedIndex,
                Naturaleza = Domain.Enums.NaturalezaCuentas.Entrada
            };

            ProductoModel.Add(p);
            Dispose();
        }
    }
}
