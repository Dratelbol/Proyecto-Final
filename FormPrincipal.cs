using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestordeCitasFinal
{
    public partial class FormPrincipal : Form
    {
        List<string> Salon = new List<string>();
        List<string> Hours = new List<string>();
        List<Appoinment> Appoiments = new List<Appoinment>();
        public FormPrincipal()
        {
            InitializeComponent();

            fillSalon();
            fillHours();
        }

        private void fillSalon()
        {
            Salon.Add("Salón Multimedia");
            Salon.Add("Salón de Juegos");
            Salon.Add("Salón de Conferencias");
            cbSalon.DataSource = Salon;
        }

        private void fillHours()
        {
            Hours = Enumerable.Range(09, 09).Select(i => (DateTime.MinValue.AddHours(i)).ToString("hh.mm tt")).ToList();
            cbHours.DataSource = Hours;
        }
        private void bNuevaCita_Click(object sender, EventArgs e)
        {
            Empty();
            Default();
        }
        private void Empty()
        {
            txtCliente.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCosto.Text = string.Empty;
        }

        private void Default()
        {
            cbSalon.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void bAnular_Click(object sender, EventArgs e)
        {
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            SAppoinment();
        }
        public class Appoinment
        {
            public string ID { get; set; }
            public string Code { get; set; }
            public string ClientName { get; set; }
            public string ClientPhone { get; set; }
            public string ClientEmail { get; set; }
            public string ClientCosto { get; set; }
            public string Doctor { get; set; }
            public DateTime Date { get; set; }
            public string DateCustom
            {
                get
                {
                    return Date.ToString("MMM dd, yyyy");
                }
            }
            public string Hour { get; set; }
            public DateTime CreatedDate { get; set; }
        }

        private void GAppoinment()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Appoiments;
            dataGridView1.Columns["ClientName"].HeaderText = "Cliente";
            dataGridView1.Columns["Code"].HeaderText = "Codigo";
            dataGridView1.Columns["ClientPhone"].HeaderText = "Telefono";
            dataGridView1.Columns["ID"].HeaderText = "Cedula";
            dataGridView1.Columns["ClientEmail"].HeaderText = "Correo";
            dataGridView1.Columns["ClientCosto"].HeaderText = "Costo";
            dataGridView1.Columns["Doctor"].HeaderText = "Salón";
            dataGridView1.Columns["DateCustom"].HeaderText = "Fecha Pautada";
            dataGridView1.Columns["Hour"].HeaderText = "Hora";
            dataGridView1.Columns["CreatedDate"].HeaderText = "Fecha de Creacion";
        }


        private void SAppoinment()
        {
            var random = new Random();
            var appoinment = new Appoinment
            {
                ID = txtCedula.Text,
                Code = random.Next(1000000, 9999999).ToString(),
                ClientName = txtCliente.Text,
                ClientPhone = txtTelefono.Text,
                ClientEmail = txtCorreo.Text,
                ClientCosto = txtCosto.Text,
                Doctor = cbSalon.SelectedValue.ToString(),
                Hour = cbHours.SelectedValue.ToString(),
                CreatedDate = DateTime.Now,
            };

            var enabledAppoinments = Appoiments.Count(x => x.Date.ToString("dd/mm/yyyy") == dateTimePicker1.Value.ToString("dd/mm/yyyy")
            && x.Hour == cbHours.SelectedValue.ToString());

            if (enabledAppoinments > 0)
            {
                MessageBox.Show("El horario no esta disponible");
                return;
            }

            Appoiments.Add(appoinment);
            var hourvalue = Hours.FirstOrDefault(x => x.ToString() == cbHours.SelectedValue.ToString());
            Hours.Remove(hourvalue);
            cbHours.DataSource = null;
            cbHours.DataSource = Hours;
            GAppoinment();
            Empty();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMedica_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
