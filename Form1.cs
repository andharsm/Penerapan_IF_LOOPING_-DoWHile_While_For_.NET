namespace Praktikum_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtDiskon.ReadOnly = true;

        }

        private void btHasil_Click(object sender, EventArgs e)
        {
            int barang;
            barang = int.Parse(txtBarang.Text);
            if (cbPembayaran.Text == "Tunai")
            {
                if (rbYa.Checked == true)
                {
                    if (barang > 10)
                    {
                        txtDiskon.Text = 8 + "%";
                    }
                    else
                    {
                        txtDiskon.Text = 7 + "%";
                    }
                }
                if (rbTidak.Checked == true)
                {
                    if (barang > 10)
                    {
                        txtDiskon.Text = 6 + "%";
                    }
                    else
                    {
                        txtDiskon.Text = 5 + "%";
                    }
                }
            }
            else if (cbPembayaran.Text == "Kredit")
            {
                if (rbYa.Checked == true)
                {
                    if (barang > 10)
                    {
                        txtDiskon.Text = 4 + "%";
                    }
                    else
                    {
                        txtDiskon.Text = 3 + "%";
                    }
                }
                if (rbTidak.Checked == true)
                {
                    if (barang > 10)
                    {
                        txtDiskon.Text = 2 + "%";
                    }
                    else
                    {
                        txtDiskon.Text = 1 + "%";
                    }
                }
            }
        }

        private void txtBarang_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBarang.Text, "[^0-9]"))
            {
                MessageBox.Show("Hanya bisa dimasukan angka.");
                txtBarang.Text = txtBarang.Text.Remove(txtBarang.Text.Length - 1);
            }
        }

        int a = 0;
        private void btDowhile_Click(object sender, EventArgs e)
        {
            do
            {
                if (a % 4 != 0)
                {
                    listBox.Items.Add(a);
                }
                a+=2;
            }
            while (a<100);
        }

        private void btWhile_Click(object sender, EventArgs e)
        {
            while(a<100)
            {
                if (a % 4 != 0)
                {
                    listBox.Items.Add(a);
                }
                a+=2;
            }
        }

        private void btFor_Click(object sender, EventArgs e)
        {
            for(a = 0; a < 100; a+=2)
            {
                if (a % 4 != 0)
                {
                    listBox.Items.Add(a);
                }
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            a = 0;
        }
    }
}