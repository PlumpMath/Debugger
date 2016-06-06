/*
 * 사용자: philly
 * 날짜: 2016-06-06
 * 시간: 오후 8:30
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using PHL.Debugger;

namespace LogViewer
{
	public partial class MainForm : Form
	{
		Assembly current;
		public MainForm()
		{
			InitializeComponent();
		}
		
		public void LoadAssembly(string path)
		{
			try
			{
				current = Logger.Open(path);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "에러!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}
	}
}