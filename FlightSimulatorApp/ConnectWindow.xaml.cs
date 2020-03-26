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
using System.Windows.Shapes;

namespace FlightSimulatorApp
{
	/// <summary>
	/// Interaction logic for ConnectWindow.xaml
	/// </summary>
	public partial class ConnectWindow : Window
	{
		private ViewModels.FlightSimulatorViewModel vm;
		public ConnectWindow(ViewModels.FlightSimulatorViewModel viewModel)
		{
			InitializeComponent();
			vm = viewModel;
			DataContext = vm;
		}

		private void connect_server_Click(object sender, RoutedEventArgs e)
		{
			vm.VM_Connect();
			this.Hide();
		}
	}
}
