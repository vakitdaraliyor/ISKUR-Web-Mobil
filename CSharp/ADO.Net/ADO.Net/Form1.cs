﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Data Source = myServerAddress; Initial Catalog = myDataBase; Integrated Security = SSPI;
            //User ID = myDomain\myUsername; Password = myPassword;
            // Veritabanına bağlandı
            String cnnstr = @"Data Source=localhost\SQLEXPRESS;initial catalog=İŞKUR; user id=sa; password=1234";
            SqlConnection connection = new SqlConnection(cnnstr);
            SqlCommand command = new SqlCommand("SELECT * FROM KATEGORI", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;

            adapter.Fill(dt);
        }
    }
}
