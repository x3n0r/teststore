using AnyStore.BLL;
using AnyStore.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VeriStore;

namespace VeriStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        userDAL dal = new userDAL();
        //Static String Method for Database Connection String
        static Context db = new Context();
        private void Form1_Load(object sender, EventArgs e)
        {
                        
            bool bit = true;
            if (bit)
            {
                tbl_users u = new tbl_users
                {
                    first_name = "name",
                    last_name= "name"
                };
                dal.Insert(u);
                List<tbl_users> query = dal.Select();
                foreach (var item in query)
                {
                    textBox1.Text = textBox1.Text + Environment.NewLine + item.Id + " "+item.first_name;
                }
            }
            else
            {


                var user = new tbl_users { first_name = "firstname2" };
                db.tbl_users.Add(user);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.tbl_users
                            orderby b.first_name
                            select b;

                foreach (var item in query)
                {
                    textBox1.Text = textBox1.Text + Environment.NewLine + item.Id + " " + item.first_name;
                }
            }
        }
    }
}
