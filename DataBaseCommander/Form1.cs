using CreateDatabase.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseCommander
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            if (context.postMapTags.Count() > 0)
            {
                textBox1.Text = $"Кількість елементів: {context.postMapTags.Count().ToString()}";
                foreach (var item in context.postMapTags.Include(p => p.Post).Include(p => p.Tag).Include(x => x.Post.category))
                {
                    string[] collElements =
                    {
                    item.Tag.Name,
                    item.Tag.UrlSlug,
                    item.Tag.Description,
                    item.Post.Title,
                    item.Post.Description,
                    item.Post.category.Name,
                    item.Post.category.Description,
                };

                    dataGridView1.Rows.Add(collElements);
                }
            }
            else 
            {
                MessageBox.Show("База данних пуста!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Якщо БД пуста вискочить MessageBox";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
