using BE;
using BLL;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class FrmBitacora : Form
    {
        List<EventoBitacora> eventos = GestorBitacora.ObtenerInstancia.LeerBitacora();
        List<EventoBitacora> eventosFiltrados = new List<EventoBitacora> { };
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            UsuarioBusiness usuarioBLL = new UsuarioBusiness();
            cbUser.DataSource = usuarioBLL.ListarNoBoss();
            cbUser.DisplayMember = "NombreUsuario";
            CargarEventos(eventos);
            //Subject.AgregarObserver(this);

        }

        private void AplicarBtn_Click(object sender, EventArgs e)
        {
            if (checkBoxfecha.Checked == true & checkBoxUsuario.Checked == true & checkBoxActividad.Checked == true)
            {
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventos, dateTimePicker1.Value, dateTimePicker2.Value);
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventosFiltrados, (UsuarioEntity)cbUser.SelectedItem);
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventosFiltrados, textBox2.Text);
                CargarEventos(eventosFiltrados);
            }
            else if (checkBoxfecha.Checked == true & checkBoxUsuario.Checked == true & checkBoxActividad.Checked == false)
            {
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventos, dateTimePicker1.Value, dateTimePicker2.Value);
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventosFiltrados, (UsuarioEntity)cbUser.SelectedItem);
                CargarEventos(eventosFiltrados);

            }
            else if (checkBoxfecha.Checked == true & checkBoxUsuario.Checked == false & checkBoxActividad.Checked == true)
            {
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventos, dateTimePicker1.Value, dateTimePicker2.Value);
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventosFiltrados, textBox2.Text);
                CargarEventos(eventosFiltrados);
            }
            else if (checkBoxfecha.Checked == false & checkBoxUsuario.Checked == true & checkBoxActividad.Checked == true)
            {
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventos, (UsuarioEntity)cbUser.SelectedItem);
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventosFiltrados, textBox2.Text);
                CargarEventos(eventosFiltrados);
            }
            else if (checkBoxfecha.Checked == true & checkBoxUsuario.Checked == false & checkBoxActividad.Checked == false)
            {
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventos, dateTimePicker1.Value, dateTimePicker2.Value);
                CargarEventos(eventosFiltrados);

            }
            else if (checkBoxfecha.Checked == false & checkBoxUsuario.Checked == true & checkBoxActividad.Checked == false)
            {
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventos, (UsuarioEntity)cbUser.SelectedItem);
                CargarEventos(eventosFiltrados);
            }
            else if (checkBoxfecha.Checked == false & checkBoxUsuario.Checked == false & checkBoxActividad.Checked == true)
            {
                eventosFiltrados = GestorBitacora.ObtenerInstancia.Filtrar(eventos, textBox2.Text);
                CargarEventos(eventosFiltrados);
            }
            else
            {
                CargarEventos(eventos);
            }
        }


        private void CargarEventos(List<EventoBitacora> eventosACargar)
        {
            listViewEventos.Clear();
            listViewEventos.View = View.Details;
            listViewEventos.LabelEdit = false;
            listViewEventos.AllowColumnReorder = true;
            listViewEventos.FullRowSelect = true;

            foreach (EventoBitacora evento in eventosACargar)
            {
                ListViewItem esteEvento = new ListViewItem(evento.idEvento.ToString());
                esteEvento.SubItems.Add(evento.actividad);
                esteEvento.SubItems.Add(evento.información);
                esteEvento.SubItems.Add(evento.fecha.ToString());
                esteEvento.SubItems.Add(evento.nombreUsuario);
                listViewEventos.Items.Add(esteEvento);
            }


            listViewEventos.Columns.Add("Id", 50);
            listViewEventos.Columns.Add("Evento", 115);
            listViewEventos.Columns.Add("Descripcion", 400);
            listViewEventos.Columns.Add("Fecha y Hora", 120);
            listViewEventos.Columns.Add("Usuario", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportesPDF reportesPDF = new ReportesPDF();
            List<Object> objetosPDF = new List<Object>();
            foreach (var item in eventosFiltrados)
            {
                objetosPDF.Add(item);
            }

            reportesPDF.CrearReportePDF(objetosPDF);
        }

        private void checkBoxActividad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxActividad.Checked == true)
            {
                textBox2.Enabled = true;
            }
            if (checkBoxActividad.Checked == false)
            {
                textBox2.Enabled = false;
            }
        }

        private void checkBoxfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxfecha.Checked == true)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            if (checkBoxfecha.Checked == false)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void checkBoxUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUsuario.Checked == true)
            {
                cbUser.Enabled = true;
            }
            if (checkBoxUsuario.Checked == false)
            {
                cbUser.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
