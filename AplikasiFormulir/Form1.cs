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
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplikasiFormulir
{
    public partial class Form1 : Form
    {
        int row = 0;   
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

        private void button1_Click_2(object sender, EventArgs e)
        {
            CheckBox[] pilihan = new CheckBox[12];
            int[] angka = { 1, 2, 3, 4, 5,6,7,8,9,10,11,12 };
            pilihan[0] = checkBox1;
            pilihan[1] = checkBox2;
            pilihan[2] = checkBox3;
            pilihan[3] = checkBox4;
            pilihan[4] = checkBox5;
            pilihan[5] = checkBox6;
            pilihan[6] = checkBox7;
            pilihan[7] = checkBox8;
            pilihan[8] = checkBox9;
            pilihan[9] = checkBox10;
            pilihan[10] = checkBox11;
            pilihan[11] = checkBox12;
            int gt;
            gt = int.Parse(tbton.Text);
            int harga1 = 5000;
            int harga2 = 20000;
            int harga3 = 21000;
            int harga4 = 23000;
            int harga5 = 21000;
            int harga6 = 22000;
            int harga7 = 21000;
            int harga8 = 21000;
            int harga9 = 33000;
            int harga10 = 10000;
            int harga11 = 110000;
            int harga12 = 10000;
            int total=0;
            
            {
                if (pilihan[0].Checked)
                {
                    total += harga1 * gt;
                }
                if (pilihan[1].Checked)
                {
                    total += harga2 * gt;
                }
                if (pilihan[2].Checked)
                {
                    total += harga3 * gt;
                }
                if (pilihan[3].Checked)
                {
                    total += harga4 * gt;
                }
                if (pilihan[4].Checked)
                {
                    total += harga5 * gt;
                }
                if (pilihan[5].Checked)
                {
                    total += harga6 * gt;
                }
                if (pilihan[6].Checked)
                {
                    total += harga7 * gt;
                }
                if (pilihan[7].Checked)
                {
                    total += harga8 * gt;
                }
                if (pilihan[8].Checked)
                {
                    total += harga9 * gt;
                }
                if (pilihan[9].Checked)
                {
                    total += harga10 * gt;
                }
                if (pilihan[10].Checked)
                {
                    total += harga11 * gt;
                }
                if (pilihan[11].Checked)
                {
                    total += harga12 * gt;
                }tbtotal.Text = total.ToString();

            }
            string kapal, kapten, kode, docking1, fishG, ikan1;
            kapal = cbkapal.Text;
            kapten = tbkapten.Text;
            docking1 = null;
            if (rbpekalongan.Checked)
            {
                docking1 = rbpekalongan.Text;
            }
            else if (rbbali.Checked)
            {
                docking1 = rbbali.Text;
            }
            else if (rbpati.Checked)
            {
                docking1 = rbpati.Text;
            }
            else if (rbcirebon.Checked)
            {
                docking1 = rbcirebon.Text;
            }
            else if (rbjakarta.Checked)
            {
                docking1 = rbjakarta.Text;
            }
            fishG = null;
            if (rbjawa.Checked)
            {
                fishG = rbjawa.Text;
            }
            else if (rbmakasar.Checked)
            {
                fishG = rbmakasar.Text;
            }
            else if (rbpapua.Checked)
            {
                fishG = rbpapua.Text;
            }
            else if (rbindonesia.Checked)
            {
                fishG = rbindonesia.Text;
            }
            ikan1 = "";
            if (cbteri.Checked)
            {
                ikan1 += cbteri.Text + " ";
            }
            if (cblayang.Checked)
            {
                ikan1 += cblayang.Text + " ";
            }
            if (cbbaraccuda.Checked)
            {
                ikan1 += cbbaraccuda.Text + " ";
            }
            if (cbkakap.Checked)
            {
                ikan1 += cbkakap.Text + " ";
            }
            if (cbcumi.Checked)
            {
                ikan1 += cbcumi.Text + " ";
            }
            if (cbtenggiri.Checked)
            {
                ikan1 += cbtenggiri.Text + " ";
            }
            if (cblayur.Checked)
            {
                ikan1 += cblayur.Text + " ";
            }
            if (cbcakalang.Checked)
            {
                ikan1 += cbcakalang.Text + " ";
            }
            if (cbtuna.Checked)
            {
                ikan1 += cbtuna.Text + " ";
            }
            if (cbmarlin.Checked)
            {
                ikan1 += cbmarlin.Text + " ";
            }
            if (cbsailfish.Checked)
            {
                ikan1 += cbsailfish.Text + " ";
            }
            if (cbkerapu.Checked)
            {
                ikan1 += cbkerapu.Text + " ";
            }

            dgv_laporan.Rows.Add();
            dgv_laporan.Rows[row].Cells[0].Value = cbkapal.Text;
            dgv_laporan.Rows[row].Cells[1].Value = tbkapten.Text;
            dgv_laporan.Rows[row].Cells[2].Value = tbkode.Text;
            dgv_laporan.Rows[row].Cells[3].Value = docking1.ToString();
            dgv_laporan.Rows[row].Cells[4].Value = fishG.ToString();
            dgv_laporan.Rows[row].Cells[5].Value = ikan1.ToString();
            row++;
        }

        private void tbgt_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}// rebes
