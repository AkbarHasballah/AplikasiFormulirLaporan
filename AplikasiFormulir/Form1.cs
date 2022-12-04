using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AplikasiFormulir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1103, 424);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cbkapal.Text != "")
            {
                if(tbkapten.Text != "")
                {
                    if(tbemail.Text != "")
                    {
                        if(tbtelpon != null)
                        {
                            if(tbkode.Text != "")
                            {
                                if(tbemail.Text != "")
                                {
                                    if (rbpekalongan.Checked)
                                    {
                                        MessageBox.Show("Data Ter Input, Lanjut ke proses Pengisian Data Pemasukan", "Lanjutkan pengisian data pemasukan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Size = new Size(1103, 900);
                                    }
                                    else if (rbbali.Checked) ;
                                    else if (rbpati.Checked) ;
                                    else if (rbcirebon.Checked) ;
                                    else if (rbjakarta.Checked) ;
                                    else
                                    {
                                        MessageBox.Show("Wajib Mengisi Tempat Docking kapal", "Untuk Melengkapi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Wajib Mengisi Email Kapten kapal", "Untuk Melengkapi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Wajib Mengisi kode kapal", "Untuk Melengkapi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Isikan no telpon!", "Untuk Melengkapi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Isi Email Kapten", "Untuk Melengkapi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Isi Nama Kapten Kapal", "Untuk Melengkapi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Pilih Nama kapal", "Untuk Melengkapi Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbkapal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbkapten_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbemail_Leave(object sender, EventArgs e)
        {
if (Regex.IsMatch(tbemail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                erw.SetError(tbemail, "");
                ers.SetError(tbemail, "");
                erb.SetError(tbemail, "Email Valid");
            }
            else
            {
                ers.SetError(tbemail, "Format Email salah");
                erw.SetError(tbemail, "");
                erb.SetError(tbemail, "");
            }
        }

        private void cbkapal_Leave(object sender, EventArgs e)
        {
            if (cbkapal.Text != "")
            {
                erb.SetError(cbkapal, "Nama Kapal telah direkam");

            }
            else
            {
                erw.SetError(cbkapal, "Masukan Nama kapal !");
            }
        }

        private void tbkapten_Leave(object sender, EventArgs e)
        {
            if (tbkapten.Text != "")
            {
                erb.SetError(tbkapten, "Nama Kapten telah direkam");

            }
            else
            {
                erw.SetError(tbkapten, "Masukan Nama kapten!");
            }
        }

        private void tbtelpon_TextChanged(object sender, EventArgs e)
        {
            if ((tbtelpon.Text).All(char.IsNumber))
            {
                erb.SetError(tbtelpon, "Benar");
              
            }
            else
            {
                ers.SetError(tbtelpon, "Inputan hanya boleh Angka!");
            }
        }

        private void tbkode_Leave(object sender, EventArgs e)
        {
            if (tbkode.Text != "")
            {
                erb.SetError(tbkode, "Nama Kapten telah direkam");

            }
            else
            {
                erw.SetError(tbkode, "Masukan Nama kapten!");
            }
        }

        private void tbalamat_Leave(object sender, EventArgs e)
        {
            if (tbalamat.Text != "")
            {
                erb.SetError(tbalamat, "Nama Kapten telah direkam");

            }
            else
            {
                erw.SetError(tbalamat, "Masukan Nama kapten!");
            }
        }

        private void rbjawa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbjawa.Checked)
            {
                cbteri.Enabled = true; cbteri.Checked = false;
                cblayang.Enabled = true; cblayang.Checked = false;
                cbbaraccuda.Enabled = true; cbbaraccuda.Checked = false;
                cbkakap.Enabled = true; cbkakap.Checked = false;
                cbcumi.Enabled = true; cbcumi.Checked = false;
                cbtenggiri.Enabled = true; cbtenggiri.Checked = false;
                cblayur.Enabled = true; cblayur.Checked = false;
                cbcakalang.Enabled = false; cbcakalang.Checked = false;
                cbtuna.Enabled = false; cbtuna.Checked = false;
                cbmarlin.Enabled = false; cbmarlin.Checked = false;
                cbsailfish.Enabled = false; cbsailfish.Checked = false;
                cbkerapu.Enabled = true; cbkerapu.Checked = false;
            }

        }

        private void rbmakasar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmakasar.Checked)
            {
                cbteri.Enabled = false; cbteri.Checked = false;
                cblayang.Enabled = true; cblayang.Checked = false;
                cbbaraccuda.Enabled = true; cbbaraccuda.Checked = false;
                cbkakap.Enabled = true; cbkakap.Checked = false;
                cbcumi.Enabled = true; cbcumi.Checked = false;
                cbtenggiri.Enabled = true; cbtenggiri.Checked = false;
                cblayur.Enabled = true; cblayur.Checked = false;
                cbcakalang.Enabled = false; cbcakalang.Checked = false;
                cbtuna.Enabled = false; cbtuna.Checked = false;
                cbmarlin.Enabled = false; cbmarlin.Checked = false;
                cbsailfish.Enabled = true; cbsailfish.Checked = false;
                cbkerapu.Enabled = true; cbkerapu.Checked = false;
            }
        }

        private void rbpapua_CheckedChanged(object sender, EventArgs e)
        {
            if (rbpapua.Checked)
            {
                cbteri.Enabled = false; cbteri.Checked = false;
                cblayang.Enabled = true; cblayang.Checked = false;
                cbbaraccuda.Enabled = false; cbbaraccuda.Checked = false;
                cbkakap.Enabled = true; cbkakap.Checked = false;
                cbcumi.Enabled = true; cbcumi.Checked = false;
                cbtenggiri.Enabled = true; cbtenggiri.Checked = false;
                cblayur.Enabled = true; cblayur.Checked = false;
                cbcakalang.Enabled = false; cbcakalang.Checked = false;
                cbtuna.Enabled = false; cbtuna.Checked = false;
                cbmarlin.Enabled = false; cbmarlin.Checked = false;
                cbsailfish.Enabled = false; cbsailfish.Checked = false;
                cbkerapu.Enabled = true; cbkerapu.Checked = false;
            }
        }

        private void rbindonesia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbindonesia.Checked)
            {
                cbteri.Enabled = false; cbteri.Checked = false;
                cblayang.Enabled = true; cblayang.Checked = false;
                cbbaraccuda.Enabled = true; cbbaraccuda.Checked = false;
                cbkakap.Enabled = true; cbkakap.Checked = false;
                cbcumi.Enabled = true; cbcumi.Checked = false;
                cbtenggiri.Enabled = true; cbtenggiri.Checked = false;
                cblayur.Enabled = true; cblayur.Checked = false;
                cbcakalang.Enabled = true; cbcakalang.Checked = false;
                cbtuna.Enabled = true; cbtuna.Checked = false;
                cbmarlin.Enabled = true; cbmarlin.Checked = false;
                cbsailfish.Enabled = true; cbsailfish.Checked = false;
                cbkerapu.Enabled = false; cbkerapu.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string docking = null;
            if (rbpekalongan.Checked)
            {
                docking = rbpekalongan.Text;
            }
            else if (rbbali.Checked)
            {
                docking = rbbali.Text;
            }else if (rbpati.Checked)
            {
                docking =rbpati.Text;
            }
            else if (rbcirebon.Checked)
            {
                docking = rbcirebon.Text;
            }
            else if (rbjakarta.Checked)
            {
                docking = rbjakarta.Text;
            }
            string FG =null;
            if (rbjawa.Checked)
            {
                FG = rbjawa.Text;
            }
            else if (rbmakasar.Checked)
            {
                FG = rbmakasar.Text;
            }
            else if (rbpapua.Checked)
            {
                FG = rbpapua.Text;
            }
            else if (rbindonesia.Checked)
            {
                FG = rbindonesia.Text;
            }
            string ikan = "";
            if (cbteri.Checked)
            {
                ikan += cbteri.Text + " ";
            }
            if (cblayang.Checked)
            {
                ikan += cblayang.Text + " ";
            }
            if (cbbaraccuda.Checked)
            {
                ikan += cbbaraccuda.Text + " ";
            }
            if (cbkakap.Checked)
            {
                ikan += cbkakap.Text + " ";
            }
            if (cbcumi.Checked)
            {
                ikan += cbcumi.Text + " ";
            }
            if (cbtenggiri.Checked)
            {
                ikan += cbtenggiri.Text + " ";
            }
            if (cblayur.Checked)
            {
                ikan += cblayur.Text + " ";
            }
            if (cbcakalang.Checked)
            {
                ikan += cbcakalang.Text + " ";
            }
            if (cbtuna.Checked)
            {
                ikan += cbtuna.Text + " ";
            }
            if (cbmarlin.Checked)
            {
                ikan += cbmarlin.Text + " ";
            }
            if (cbsailfish.Checked)
            {
                ikan += cbsailfish.Text + " ";
            }
            if (cbkerapu.Checked)
            {
                ikan += cbkerapu.Text + " ";
            }
            MessageBox.Show
               ("Nama Kapal : " + cbkapal.Text +
                   "\nNama Kapten : " + tbkapten.Text +
                   "\nEmail Kapten : " + tbkapten.Text +
                   "\nNo. Telpon Kapten : " + tbtelpon.Text +
                   "\nKode Kapal : " + tbkode.Text +
                   "\nTanggal Docking: " + dtdocking.Text +
                   "\nTempat Docking : " + docking +
                   "\n" + "\n" +
                   "\nFishing Ground : " + FG +
                   "\nPerolehan Jenis Ikan: " + ikan, " Data Sudah Masuk Ke BOS ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void hapusdata_Click(object sender, EventArgs e)
        {
            cbkakap.Text= null;
            tbkapten.Clear();
            tbalamat.Clear();
            tbemail.Text= null;
            tbtelpon.Clear();
            tbkode.Clear();
            dtdocking.Text=null;
            cbteri.Checked = false;
            cblayang.Checked = false;
            cbbaraccuda.Checked = false;
            cbkakap.Checked = false;
            cbkerapu.Checked = false;
            cbcumi.Checked = false;
            cbtenggiri.Checked = false;
            cblayur.Checked = false;
            cbcakalang.Checked = false;
            cbtuna.Checked = false;
            cbmarlin.Checked = false;
            cbsailfish.Checked = false;
            rbpekalongan.Checked = false;
            rbbali.Checked = false;
            rbcirebon.Checked = false;
            rbpati.Checked = false;
            rbjakarta.Checked = false;
            rbjawa.Checked = false;
            rbmakasar.Checked = false;
            rbpapua.Checked = false;
            rbindonesia.Checked = false;
            this.Size = new Size(1103, 748);
        }
    }
}
