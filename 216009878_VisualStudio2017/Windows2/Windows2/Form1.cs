using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Windows2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Book> book = new List<Book>();
        Book b = new Book();

        string path = "File.txt";
        FileStream filee;
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                filee = new FileStream(path, FileMode.Append);

            }
            catch (IOException)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("Please fill all spaces");
                }

                else if (path != "")
                {
                    StreamWriter sw = new StreamWriter(filee);
                    sw.WriteLine(string.Format("{0},{1},{2},{3},{4}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text));
                    sw.Close();
                    filee.Close();
                    MessageBox.Show("Book saved");

                    b.ISBN = textBox1.Text;
                    b.Title = textBox2.Text;
                    b.AuthorName = textBox3.Text;
                    b.Edition = textBox4.Text;
                    b.year = textBox5.Text;
                    book.Add(b);
                    listView1.Items.Add(b.ISBN);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
            catch(NoNullAllowedException)
            {
                MessageBox.Show("");
            }
           
            
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                StreamReader sr = new StreamReader(path);

                int count = 0;
                string s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    string[] mybook = s.Split(',');
                    if (textBox6.Text == mybook[0])
                    {
                        textBox1.Text = mybook[0];
                        textBox2.Text = mybook[1];
                        textBox3.Text = mybook[2];
                        textBox4.Text = mybook[3];
                        textBox5.Text = mybook[4];
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("No book found");
                }

                sr.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Fill all book fields and add a book please");
            }


            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("File empty");
            }

            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter valid value");
            }
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter valid value");
            }

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("Please enter valid value");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid character NOT a number!");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid character NOT a number!");
            }
        }
    }
}
