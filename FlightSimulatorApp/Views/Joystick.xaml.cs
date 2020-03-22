﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlightSimulatorApp.Views
{
	/// <summary>
	/// Interaction logic for Joystick.xaml
	/// </summary>
	/// comment
	public partial class Joystick : UserControl
	{
		public Joystick()
		{
			InitializeComponent();
		}

		private Point firstPoint = new Point();

		private void Knob_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				firstPoint = e.GetPosition(this);
			}
		}

		private void Knob_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				double x = e.GetPosition(this).X - firstPoint.X;
				double y = e.GetPosition(this).Y - firstPoint.Y;
				if (Math.Sqrt(x*x + y*y) < base.Width / 2)
				{
					knobPosition.X = x;
					knobPosition.Y = y;
				}					
			}
		}

		private void Knob_MouseUp(object sender, MouseButtonEventArgs e)
		{
			knobPosition.X = 0;
			knobPosition.Y = 0;
		}
		private void centerKnob_Completed(object sender, EventArgs e) { }
	}
}
