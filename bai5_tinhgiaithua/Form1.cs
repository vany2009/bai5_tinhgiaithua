﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5_tinhgiaithua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTinhTong_Click(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtSo.Text);
            int gt = 1;
            for (int i = 1; i <=so; i++)
            {
                gt = gt * i;    
            }
            lblkq.Text = "ket qua:" + gt.ToString();
        }
    }
}
