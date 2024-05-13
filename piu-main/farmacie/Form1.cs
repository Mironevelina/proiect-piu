using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PMS2
{ 

    public partial class Form1 : Form
    {
        private const decimal MinPret = 0;

        private List<Medicament> medicamente;

    public class Medicament
    {
        public string Nume { get; set; }
        public string Producator { get; set; }
        public decimal Pret { get; set; }
        public int Cantitate { get; set; }
    }

        public Form1()
        {
            InitializeComponent();
            medicamente = new List<Medicament>();

            // Inițializare și afișare medicamente
            AfiseazaMedicamente();  
        }

        private void AfiseazaMedicamente()
        {
            string filePath = @"C:\Users\Student\Downloads\piu-main\Medicamente.txt";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                MessageBox.Show("Fișierul de date nu există și a fost creat!");
                return;
            }

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 4)
                {
                    try
                    {
                        Medicament medicament = new Medicament
                        {
                            Nume = parts[0],
                            Producator = parts[1],
                            Pret = decimal.Parse(parts[2]),
                            Cantitate = int.Parse(parts[3])
                        };
                        medicamente.Add(medicament);
                        AdaugaMedicamentLaFormular(medicament);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Eroare la parsarea uneia dintre linii.");
                        return;
                    }
                }
            }
        }

        private void AdaugaMedicamentLaFormular(Medicament medicament)
        {
            TextBox textBoxNume = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Nume: {medicament.Nume}"
            };

            TextBox textBoxProducator = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Producator: {medicament.Producator}"
            };

            TextBox textBoxPret = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Preț: {medicament.Pret} lei"
            };

            TextBox textBoxCantitate=new TextBox
            {
                Multiline=true,
                ReadOnly=true,
                Text=$"Cantitate:{medicament.Cantitate} bucati"
            };

            flowLayoutPanelMedicamente.Controls.Add(textBoxNume);
            flowLayoutPanelMedicamente.Controls.Add(textBoxProducator);
            flowLayoutPanelMedicamente.Controls.Add(textBoxPret);
            flowLayoutPanelMedicamente.Controls.Add(textBoxCantitate);
        }

        private void btnAdaugaMedicament_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) || string.IsNullOrWhiteSpace(txtProducator.Text) || nudPret.Value <= MinPret)
            {
                MessageBox.Show("Introduceți date valide pentru medicament!");
                return;
            }

            if (!int.TryParse(txtCantitate.Text, out int cantitate) || cantitate < 0)
            {
                MessageBox.Show("Cantitatea introdusă nu este validă!");
                return;
            }

            Medicament medicament = new Medicament
            {
                Nume = txtNume.Text,
                Producator = txtProducator.Text,
                Pret = nudPret.Value,
                Cantitate= cantitate
               
            };

            AdaugaMedicamentInFisier(medicament);
            AdaugaMedicamentLaFormular(medicament);

            // Resetare câmpuri
            txtNume.Text = "";
            txtProducator.Text = "";
            nudPret.Value = MinPret;
            txtCantitate.Text = "";
        }

        private void AdaugaMedicamentInFisier(Medicament medicament)
        {
            string filePath = @"C:\Users\Student\Downloads\piu-main\Medicamente.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{ medicament.Nume},{medicament.Producator},{medicament.Pret},{medicament.Cantitate}");
            }
        }



        private void CautaMedicamente(string termen)
        {
            Console.WriteLine($"Căutare pentru termenul '{termen}'...");

            // Șterge medicamentele
            flowLayoutPanelRezultate.Controls.Clear();

            // Caută medicamente
            foreach (var medicament in medicamente)
            {
                if (medicament.Nume.ToLower().Contains(termen.ToLower()) || medicament.Producator.ToLower().Contains(termen.ToLower()))
                {
                    Console.WriteLine($"Medicament găsit: {medicament.Nume}, Producător: {medicament.Producator}");
                    AdaugaMedicamentLaFormularInRezultate(medicament);
                }
            }

            Console.WriteLine($"Căutare pentru termenul '{termen}' s-a efectuat cu succes!");
        }


        private void AdaugaMedicamentLaFormularInRezultate(Medicament medicament)
        {
            TextBox textBoxNume = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Nume: {medicament.Nume}"
            };

            TextBox textBoxProducator = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Producator: {medicament.Producator}"
            };

            TextBox textBoxPret = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Preț: {medicament.Pret} lei"
            };

            TextBox textBoxCantitate = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Cantitate: {medicament.Cantitate} bucati"
            };

            flowLayoutPanelRezultate.Controls.Add(textBoxNume);
            flowLayoutPanelRezultate.Controls.Add(textBoxProducator);
            flowLayoutPanelRezultate.Controls.Add(textBoxPret);
            flowLayoutPanelRezultate.Controls.Add(textBoxCantitate);

            flowLayoutPanelRezultate.Refresh();

        }

        private void flowLayoutPanelMedicamente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducator_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudPret_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) || string.IsNullOrWhiteSpace(txtProducator.Text) || nudPret.Value <= MinPret)
            {
                MessageBox.Show("Introduceți date valide pentru medicament!");
                return;
            }

            if (!int.TryParse(txtCantitate.Text, out int cantitate) || cantitate < 0)
            {
                MessageBox.Show("Cantitatea introdusă nu este validă!");
                return;
            }

            Medicament medicament = new Medicament
            {
                Nume = txtNume.Text,
                Producator = txtProducator.Text,
                Pret = nudPret.Value,
                Cantitate = cantitate
                
                
            };

            AdaugaMedicamentInFisier(medicament);
            AdaugaMedicamentLaFormular(medicament);

            // Resetare câmpuri
            txtNume.Text = "";
            txtProducator.Text = "";
            nudPret.Value = MinPret;
            txtCantitate.Text = "";
           
        }

        private void txtCantitate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            CautaMedicamente(txtCautare.Text);
        }
        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            string termen = txtCautare.Text;
            CautaMedicamente(termen);
            Console.WriteLine("Funcția CautaMedicamente a fost apelată cu termenul: " + termen);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void radioButtonCuCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCuCard.Checked)
            {
                // Acțiuni atunci când radioButtonCuCard este selectat
                MessageBox.Show("Clientul are card de fidelitate.");
            }
        }

        private void radioButtonFaraCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFaraCard.Checked)
            {
                // Acțiuni atunci când radioButtonFaraCard este selectat
                MessageBox.Show("Clientul nu are card de fidelitate.");
            }
        }

        private void checkBoxDisponibilitate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDisponibilitate.Checked)
            {
                // Acțiuni atunci când checkBoxDisponibilitate este bifat
                MessageBox.Show("Medicamentul este disponibil.");
            }
            else
            {
                // Acțiuni atunci când checkBoxDisponibilitate este debifat
                MessageBox.Show("Medicamentul nu este disponibil.");
            }
        }

        private void btnCauta_Click_1(object sender, EventArgs e)
        {
            string numeMedicament = txtCautare.Text.Trim();
            if (string.IsNullOrWhiteSpace(numeMedicament))
            {
                MessageBox.Show("Introduceți numele medicamentului pentru căutare!");
                return;
            }

            CautaMedicamente(numeMedicament);
        }
    }
}
