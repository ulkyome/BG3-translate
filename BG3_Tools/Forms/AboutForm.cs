﻿using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BG3_Tools.Forms
{
    public partial class AboutForm : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public AboutForm()
        {
            InitializeComponent();
        }
    }
}
