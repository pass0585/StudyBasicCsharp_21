﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformThreadApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;

            // 스레드로 분리 윈폼의 화면스레드, 처리스레드 분리

            Thread th = new Thread(() => {
                for (int i = 0; i <= 1000; i++)
                {
                    progressBar1.BeginInvoke( new Action( () => { progressBar1.Value = i;} ) );// 크로스 스레드 문제해결
                    Thread.Sleep(5);   // 5ms 걸리는 일이 있음
                }
            });
            th.IsBackground = true; // 백그라운드로 실행할지 여부
            th.Start();
        }
    }
}
