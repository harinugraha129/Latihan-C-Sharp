using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TGS_090518_5160411129_B
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        set Add = new set(false);

        Name nama = new Name("");

        bool dontint = false;

        private void button4_Click(object sender, EventArgs e)
        {
            
            string chickenPart = comboBox1.Text;
            int calory = 0;
            Boolean Spicy = false;
            try
            {                
                calory = int.Parse(textBox1.Text);
                jumlahCalory(calory);
            }
            catch (FormatException)
            {
                MessageBox.Show("Input data dengan benar");
            }
            catch(Calorykurang)
            {
                MessageBox.Show("Kalori Tidak Boleh Kurang Dari Lima Puluh");
            }

            
            

            void jumlahCalory(int X)
            {
                if ( X < 50)
                {
                    throw (new Calorykurang());                    
                }
                else
                {
                    Add.sett = true;
                    if (checkBox1.Checked)
                    {
                        Spicy = true;
                    }
                    FriedChicken fc1 = new FriedChicken(chickenPart, Spicy, calory);
                    textBox2.Text = fc1.GenerateFCName();
                    textBox3.Text = fc1.SetPriceForFC(); ;
                }
            }
                   
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            string topping = textBox6.Text;
            string pzName = textBox4.Text;
            string size = comboBox2.Text;
            string crusType = comboBox3.Text;
            int calory = 0;

            try
            {
                int dontInt = int.Parse(topping);
                unint(dontInt);
            }
            catch (formatJanganInteger)
            {
                MessageBox.Show("Jangan Input Topping dengan Integer");
            }
            catch(FormatException)
            {
                dontint = true;
            }

            try
            {               
                calory = int.Parse(textBox9.Text);
                int leng = pzName.Length;
                jumlahCalory(calory,leng);
            }
            catch (FormatException)
            {
                MessageBox.Show("Input data dengan benar");
            }
            catch (Calorykurang)
            {
                MessageBox.Show("Kalori Tidak Boleh Kurang Dari Lima Puluh");
            }
            catch(panjangNama)
            {
                MessageBox.Show("Nama tidak boleh kosong atau lebih dari 25 karakter");
            }

            
            void unint(int x)
            {
                throw (new formatJanganInteger());

            }

            void jumlahCalory(int X,int y)
            {
                if(y<=0 || y > 25)
                {
                    throw (new panjangNama());                    
                }
                else if (dontint)
                {
                    if (X < 50)
                    {
                        throw (new Calorykurang());
                    }
                    else
                    {
                        Add.sett = true;
                        string[] toppingx = topping.Split(',');
                        if (toppingx.Length == 1)
                        {
                            Pizza pz2 = new Pizza(pzName, toppingx[0], crusType, size, calory);
                            textBox7.Text = pz2.GeneratePizzaName();
                            textBox8.Text = pz2.SetPriceForPizza();
                        }
                        else if (toppingx.Length == 2)
                        {
                            Pizza pz2 = new Pizza(pzName, toppingx[0], toppingx[1], crusType, size, calory);
                            textBox7.Text = pz2.GeneratePizzaName();
                            textBox8.Text = pz2.SetPriceForPizza();
                        }
                        else if (toppingx.Length == 3)
                        {
                            Pizza pz2 = new Pizza(pzName, toppingx[0], toppingx[1], toppingx[2], crusType, size, calory);
                            textBox7.Text = pz2.GeneratePizzaName();
                            textBox8.Text = pz2.SetPriceForPizza();
                        }
                        
                    }
                    dontint = false;
                }
                
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string patype = comboBox4.Text;
            int numOfpat = 0;
            string ExtrFillr;

            int Calory = 0;
            ExtrFillr = textBox11.Text;
            try
            {
                int dontInt = int.Parse(ExtrFillr);
                unint(dontInt);
            }
            catch (formatJanganInteger)
            {
                MessageBox.Show("Jangan Input Extra Filler dengan Integer");
            }
            catch (FormatException)
            {
                dontint = true;
            }

            try
            {
                
                Calory = int.Parse(textBox13.Text);
                numOfpat = int.Parse(textBox12.Text);
                jumlahCalory(Calory,numOfpat);
            }
            catch (FormatException)
            {
                MessageBox.Show("Input data dengan benar");
            }
            catch (Calorykurang)
            {
                MessageBox.Show("Kalori Tidak Boleh Kurang Dari Lima Puluh");
            }
            catch(NumOfPat)
            {
                MessageBox.Show("Number Of Patty harus di isi dengan 1 atau 2 atau 3");
            }
            void unint(int x)
            {
                throw (new formatJanganInteger());

            }
            void jumlahCalory(int X,int y)
            {
                if(y<=0 || y>=4)
                {
                    throw (new NumOfPat());
                }
                else if (dontint)
                {
                    if (X < 50)
                    {

                        throw (new Calorykurang());
                    }
                    else
                    {
                        Add.sett = true;
                        string[] ExtrFillrs = ExtrFillr.Split(',');
                        if (ExtrFillrs.Length == 1)
                        {
                            hamburger hmbg2 = new hamburger(numOfpat, patype, ExtrFillrs[0], Calory);
                            textBox10.Text = hmbg2.GenerateBurgerName();
                            textBox5.Text = hmbg2.SetPriceForBurger();
                        }
                        else if (ExtrFillrs.Length == 2)
                        {
                            hamburger hmbg2 = new hamburger(numOfpat, patype, ExtrFillrs[0],ExtrFillrs[1], Calory);
                            textBox10.Text = hmbg2.GenerateBurgerName();
                            textBox5.Text = hmbg2.SetPriceForBurger();
                        }
                        else if (ExtrFillrs.Length == 3)
                        {
                            hamburger hmbg2 = new hamburger(numOfpat, patype, ExtrFillrs[0],ExtrFillrs[1],ExtrFillrs[2], Calory);
                            textBox10.Text = hmbg2.GenerateBurgerName();
                            textBox5.Text = hmbg2.SetPriceForBurger();
                        }
                        
                        
                    }
                    dontint = false;
                }
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.RowCount;
            int countName = 0;
            bool doublename=false;
            string Spice = "false";
            if(rowCount==1)
            {
                doublename = true;
            }
            else
            {
                for (int a = 0; a < rowCount; a++)
                {
                    string namedata = Convert.ToString(dataGridView1.Rows[a].Cells["Menu Name"].Value);
                    if (textBox2.Text == namedata)
                    {
                        countName++;
                    }
                    
                }

                if(countName==0)
                {
                    doublename = true;
                }
            }
            
            
            if (!Add.sett)
            {
                MessageBox.Show("Pastikan Data sudah Benar dan tidak ada yang duplikat");
            }
            else if (nama.Nama == textBox2.Text)
            {
                MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
            }
            else if (!doublename)
            {
                MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
            }
            else
            {
                if (checkBox1.Checked)
                {
                    Spice = "true";
                }
                
                /*
                string[] dataBaru = new string[] { comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, Spice };
                dataGridView1.Rows.Add(dataBaru);
                */
                fc fc1 = new fc(comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, Spice);
                bindingSourceFc.Add(fc1);

                nama.Nama=textBox2.Text;
                Add.sett = false;
                doublename = false;
            }
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView2.RowCount;
            int countName = 0;
            bool doublename = false;
            if (rowCount == 1)
            {
                doublename = true;
            }
            else
            {
                for (int a = 0; a < rowCount; a++)
                {
                    string namedata = Convert.ToString(dataGridView2.Rows[a].Cells["Menu Name"].Value);
                    if (textBox7.Text == namedata)
                    {
                        countName++;
                    }

                }

                if (countName == 0)
                {
                    doublename = true;
                }
            }

            if (!Add.sett)
            {
                MessageBox.Show("Pastikan Data sudah Benar dan tidak ada yang duplikat");
            }
            else if (nama.Nama == textBox7.Text)
            {
                MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
            }
            else if (!doublename)
            {
                MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
            }
            else
            {
                /*
                Add.sett = false;
                string[] dataBaru = new string[] { textBox4.Text, textBox9.Text, textBox7.Text, comboBox2.Text, comboBox3.Text, textBox6.Text, textBox8.Text };
                dataGridView2.Rows.Add(dataBaru);
                */

                pz pz1 = new pz(textBox4.Text, textBox9.Text, textBox7.Text, comboBox2.Text, comboBox3.Text, textBox6.Text, textBox8.Text);
                bindingSourcePz.Add(pz1);
                nama.Nama = textBox7.Text;
                doublename = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int rowCount = dataGridView3.RowCount;
            int countName = 0;
            bool doublename = false;
            if (rowCount == 1)
            {
                doublename = true;
            }
            else
            {
                for (int a = 0; a < rowCount; a++)
                {
                    string namedata = Convert.ToString(dataGridView3.Rows[a].Cells["Menu Name"].Value);
                    if (textBox10.Text == namedata)
                    {
                        countName++;
                    }

                }

                if (countName == 0)
                {
                    doublename = true;
                }
            }
            if (!Add.sett)
            {
                MessageBox.Show("Pastikan Data sudah Benar dan tidak ada yang duplikat");
            }
            else if (nama.Nama == textBox10.Text)
            {
                MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
            }
            else if (!doublename)
            {
                MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
            }
            else
            {
                /*
                Add.sett = false;
                string[] dataBaru = new string[] { comboBox4.Text, textBox12.Text, textBox13.Text, textBox10.Text, textBox11.Text, textBox5.Text };
                dataGridView3.Rows.Add(dataBaru);
                */
                hbg hbg1 = new hbg(comboBox4.Text, textBox13.Text, textBox10.Text, textBox12.Text, textBox11.Text, textBox5.Text);
                bindingSourceHbg.Add(hbg1);
                nama.Nama = textBox10.Text;
                doublename = false;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
            comboBox1.ResetText();
            checkBox1.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear(); textBox9.Clear();
            comboBox2.ResetText(); comboBox3.ResetText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.Clear(); textBox10.Clear(); textBox11.Clear(); textBox12.Clear(); textBox13.Clear();
            comboBox4.ResetText();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("friedchicken.txt");
            int rowcount = dataGridView1.Rows.Count;
            int colcount = dataGridView1.Columns.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                for (int j = 0; j < colcount; j++)
                {
                    writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    writer.Write(";");
                }
                writer.WriteLine();
            }
            writer.Close();
            MessageBox.Show("Text file was created.");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("pizza.txt");
            int rowcount = dataGridView2.Rows.Count;
            int colcount = dataGridView2.Columns.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                for (int j = 0; j < colcount; j++)
                {
                    writer.Write(dataGridView2.Rows[i].Cells[j].Value.ToString());
                    writer.Write(";");
                }
                writer.WriteLine();
            }
            writer.Close();
            MessageBox.Show("Text file was created.");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter("humberger.txt");
            int rowcount = dataGridView3.Rows.Count;
            int colcount = dataGridView3.Columns.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                for (int j = 0; j < colcount; j++)
                {
                    writer.Write(dataGridView3.Rows[i].Cells[j].Value.ToString());
                    writer.Write(";");
                }
                writer.WriteLine();
            }
            writer.Close();
            MessageBox.Show("Text file was created.");
        }
        private BindingSource bindingSourceFc = new BindingSource();

        private BindingSource bindingSourcePz = new BindingSource();

        private BindingSource bindingSourceHbg = new BindingSource();
        int selected_idx = -1;
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Set DGV Mahasiswa Column Format
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSourceFc;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CicPart";
            column.Name = "Chicken Part";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Calory";
            column.Name = "Calory";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MenuName";
            column.Name = "Menu Name";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Price";
            dataGridView1.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Spicy";
            column.Name = "Spicy";
            dataGridView1.Columns.Add(column);
            #endregion


            /**/

            dataGridView1.Rows.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader("friedchicken.txt");
            DataTable dt = new DataTable();
            dt.Columns.Add("Chicken Part", typeof(string));
            dt.Columns.Add("Calory", typeof(string));
            dt.Columns.Add("Menu Name", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Spicy", typeof(string));

            
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                string[] values = newline.Split(';');
                fc fc1 = new fc(
                    values[0], values[1], values[2], values[3], values[4]);
                bindingSourceFc.Add(fc1);
            }
            file.Close();


            #region Set DGV Mahasiswa Column Format
            
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = bindingSourcePz;
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            
            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "PizzaName";
            column1.Name = "Pizza Name";
            dataGridView2.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "Calory";
            column1.Name = "Calory";
            dataGridView2.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "MenuName";
            column1.Name = "Menu Name";
            dataGridView2.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "PizzaSize";
            column1.Name = "Pizza Size";
            dataGridView2.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "CrustType";
            column1.Name = "Crust Type";
            dataGridView2.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "TopingItem";
            column1.Name = "Toping Item";
            dataGridView2.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "Price";
            column1.Name = "Price";
            dataGridView2.Columns.Add(column1);

            
            #endregion


            /**/

            dataGridView2.Rows.Clear();
            System.IO.StreamReader file1 = new System.IO.StreamReader("pizza.txt");
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("PizzaName", typeof(string));
            dt1.Columns.Add("Calory", typeof(string));
            dt1.Columns.Add("Menu Name", typeof(string));
            dt1.Columns.Add("Pizza Size", typeof(string));
            dt1.Columns.Add("Crust Type", typeof(string));
            dt1.Columns.Add("Toping Item", typeof(string));
            dt1.Columns.Add("Price", typeof(string));
            


            string newline1;
            while ((newline1 = file1.ReadLine()) != null)
            {
                string[] values1 = newline1.Split(';');
                pz pz1 = new pz(
                    values1[0], values1[1], values1[2], values1[3], values1[4], values1[5], values1[6]);
                bindingSourcePz.Add(pz1);
            }
            file1.Close();

            #region Set DGV Mahasiswa Column Format

            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = bindingSourceHbg;
            dataGridView3.ReadOnly = true;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;

            
            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "patyType";
            column1.Name = "patyType";
            dataGridView3.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "Calory";
            column1.Name = "Calory";
            dataGridView3.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "MenuName";
            column1.Name = "Menu Name";
            dataGridView3.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "numOfPaty";
            column1.Name = "numOfPaty";
            dataGridView3.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "extraFiller";
            column1.Name = "extraFiller";
            dataGridView3.Columns.Add(column1);

            column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "Price";
            column1.Name = "Price";
            dataGridView3.Columns.Add(column1);


            #endregion


            /**/

            dataGridView3.Rows.Clear();
            System.IO.StreamReader file2 = new System.IO.StreamReader("humberger.txt");
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("patyType", typeof(string));
            dt2.Columns.Add("Calory", typeof(string));
            dt2.Columns.Add("Menu Name", typeof(string));
            dt2.Columns.Add("numOfPaty", typeof(string));
            dt2.Columns.Add("extraFiller", typeof(string));
            dt2.Columns.Add("Price", typeof(string));



            string newline2;
            while ((newline2 = file2.ReadLine()) != null)
            {
                string[] values2 = newline2.Split(';');
                hbg hbg1 = new hbg(
                    values2[0], values2[1], values2[2], values2[3], values2[4], values2[5]);
                bindingSourceHbg.Add(hbg1);
            }
            file.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (selected_idx == -1)
            {
                MessageBox.Show("Pilih data grid index sebelum Execute");
            }else
            bindingSourceFc.RemoveAt(selected_idx);
            selected_idx = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            comboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
            selected_idx = dataGridView1.CurrentRow.Index;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox2.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            comboBox3.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            selected_idx = dataGridView2.CurrentRow.Index;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (selected_idx == -1)
            {
                MessageBox.Show("Pilih data grid index sebelum Execute");
            }else
            bindingSourcePz.RemoveAt(selected_idx);
            selected_idx = -1;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox4.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            textBox10.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBox11.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            
            textBox12.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            textBox13.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            selected_idx = dataGridView3.CurrentRow.Index;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (selected_idx == -1)
            {
                MessageBox.Show("Pilih data grid index sebelum Execute");
            }
            else
            bindingSourceHbg.RemoveAt(selected_idx);
            selected_idx = -1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (selected_idx == -1)
            {
                MessageBox.Show("Pilih data grid index sebelum Execute");
            }
            else
            {
                int rowCount = dataGridView3.RowCount;
                int countName = 0;
                bool doublename = false;
                string namedata1 = Convert.ToString(dataGridView3.Rows[selected_idx].Cells["Menu Name"].Value);
                if (rowCount == 1)
                {
                    doublename = true;
                }

                else
                {
                    for (int a = 0; a < rowCount; a++)
                    {
                        string namedata = Convert.ToString(dataGridView3.Rows[a].Cells["Menu Name"].Value);
                        if (textBox10.Text == namedata)
                        {
                            countName++;
                        }

                    }

                    if (countName == 0)
                    {
                        doublename = true;
                    }
                }

                if (namedata1 == textBox10.Text)
                {
                    doublename = true;
                }

                if (!Add.sett)
                {
                    MessageBox.Show("Pastikan Data sudah Benar dan tidak ada yang duplikat");
                }
                else if (nama.Nama == textBox10.Text)
                {
                    MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
                }
                else if (!doublename)
                {
                    MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
                }
                else if (selected_idx == -1)
                {
                    MessageBox.Show("Pilih data grid index sebelum Execute");
                }
                else
                {
                    /*
                    Add.sett = false;
                    string[] dataBaru = new string[] { comboBox4.Text, textBox12.Text, textBox13.Text, textBox10.Text, textBox11.Text, textBox5.Text };
                    dataGridView3.Rows.Add(dataBaru);
                    */
                    hbg hbg1 = new hbg(comboBox4.Text, textBox13.Text, textBox10.Text, textBox12.Text, textBox11.Text, textBox5.Text);
                    bindingSourceHbg[selected_idx] = hbg1;
                    nama.Nama = textBox10.Text;
                    doublename = false;
                }
            }
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (selected_idx == -1)
            {
                MessageBox.Show("Pilih data grid index sebelum Execute");
            }else
            {
                int rowCount = dataGridView1.RowCount;
                int countName = 0;
                bool doublename = false;
                string Spice = "false";
                string namedata1 = Convert.ToString(dataGridView1.Rows[selected_idx].Cells["Menu Name"].Value);
                if (rowCount == 1)
                {
                    doublename = true;
                }

                else
                {
                    for (int a = 0; a < rowCount; a++)
                    {
                        string namedata = Convert.ToString(dataGridView1.Rows[a].Cells["Menu Name"].Value);
                        if (textBox2.Text == namedata)
                        {
                            countName++;
                        }

                    }

                    if (countName == 0)
                    {
                        doublename = true;
                    }
                }

                if (namedata1 == textBox2.Text)
                {
                    doublename = true;
                }

                if (!Add.sett)
                {
                    MessageBox.Show("Pastikan Data sudah Benar dan tidak ada yang duplikat");
                }
                else if (nama.Nama == textBox2.Text)
                {
                    MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
                }
                else if (!doublename)
                {
                    MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
                }
                else if (selected_idx == -1)
                {
                    MessageBox.Show("Pilih data grid index sebelum Execute");
                }
                else
                {
                    if (checkBox1.Checked)
                    {
                        Spice = "true";
                    }

                    /*
                    string[] dataBaru = new string[] { comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, Spice };
                    dataGridView1.Rows.Add(dataBaru);
                    */


                    fc fc1 = new fc(comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, Spice);
                    bindingSourceFc[selected_idx] = fc1;

                    nama.Nama = textBox2.Text;
                    Add.sett = false;
                    doublename = false;
                }
            }
            



        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (selected_idx == -1)
            {
                MessageBox.Show("Pilih data grid index sebelum Execute");
            }
            else
            {
                int rowCount = dataGridView2.RowCount;
                int countName = 0;
                bool doublename = false;
                string namedata1 = Convert.ToString(dataGridView2.Rows[selected_idx].Cells["Menu Name"].Value);
                if (rowCount == 1)
                {
                    doublename = true;
                }

                else
                {
                    for (int a = 0; a < rowCount; a++)
                    {
                        string namedata = Convert.ToString(dataGridView2.Rows[a].Cells["Menu Name"].Value);
                        if (textBox7.Text == namedata)
                        {
                            countName++;
                        }

                    }

                    if (countName == 0)
                    {
                        doublename = true;
                    }
                }

                if (namedata1 == textBox7.Text)
                {
                    doublename = true;
                }

                if (!Add.sett)
                {
                    MessageBox.Show("Pastikan Data sudah Benar dan tidak ada yang duplikat");
                }
                else if (nama.Nama == textBox7.Text)
                {
                    MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
                }
                else if (!doublename)
                {
                    MessageBox.Show("Pastikan nama menu tidak ada yang kembar");
                }
                else if (selected_idx == -1)
                {
                    MessageBox.Show("Pilih data grid index sebelum Execute");
                }
                else
                {
                    /*
                    Add.sett = false;
                    string[] dataBaru = new string[] { textBox4.Text, textBox9.Text, textBox7.Text, comboBox2.Text, comboBox3.Text, textBox6.Text, textBox8.Text };
                    dataGridView2.Rows.Add(dataBaru);
                    */

                    pz pz1 = new pz(textBox4.Text, textBox9.Text, textBox7.Text, comboBox2.Text, comboBox3.Text, textBox6.Text, textBox8.Text);
                    bindingSourcePz[selected_idx] = pz1;
                    nama.Nama = textBox7.Text;
                    doublename = false;
                }
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Add.sett = false;
        }
    }
}
