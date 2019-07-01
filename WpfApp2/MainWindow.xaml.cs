using System;
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

/*
Project: Calculator
Author: Samsi
Date: 20.8.18
Description: The Application is supposed to work just like the integrated Windows Calculator.
It has a standart mode, a Datatype converter, and other mathematical features.
Note: Some things aren't implemented yet. This is still WIP.
Roadmap:
- Finishing and perfecting the basic functions of the calculator
- Implementation of more mathematical functions like pow, radix, brackets, etc.
- Adding a menu to access different functions of the calculator
- Implementing a Datatype converter (for at least Binary and Hex)
- Grafical redesign
- Implementing other converters for length, volume, weight, etc.
Known Bugs: Only 1 Operation at once is possible. Also the full operation display isn't implemented yet.
Changelog:
07.10.18 - v0.1.0-0023 : First functioning addition. Also working clear and comma buttons.
09.10.18 - v0.2.0-0046 : All basic functions work (+,-,*,/). Also added Backspace.
*/

namespace WpfApp2
{
	/// <summary>
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>

	public partial class MainWindow : Window
	{
		int ioperator = 0;
		double dtotal1 = 0;
		double dtotal2 = 0;


		public MainWindow()
		{
			InitializeComponent();
		}
		private void NumpadClear_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Clear();
		}

		private void NumpadBackspace_Click(object sender, RoutedEventArgs e)
		{
			String s = txtDisplay.Text;
			if (s.Length > 1)
			{
				s = s.Substring(0, s.Length - 1);
			}
			else
			{
				s = "0";
			}
			txtDisplay.Text = s;
		}
		
		private void NumpadNC1_Click(object sender, RoutedEventArgs e)
		{
			
		}

		private void NumpadNC2_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Du hast ein Easteregg gefunden!", "Easteregg", MessageBoxButton.OK, MessageBoxImage.Asterisk);
		}

			private void Numpad1_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "1";
		}

		private void Numpad2_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "2";
		}

		private void Numpad3_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "3";
		}

		private void Numpad4_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "4";
		}

		private void Numpad5_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "5";
		}

		private void Numpad6_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "6";
		}

		private void Numpad7_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "7";
		}

		private void Numpad8_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "8";
		}

		private void Numpad9_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "9";
		}

		private void Numpad0_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text += "0";
		}

		private void NumpadComma_Click(object sender, RoutedEventArgs e)
		{
			if (txtDisplay.Text.IndexOf(".") == -1)
			{
				txtDisplay.Text += ".";
			}
		}

		private void NumpadPlus_Click(object sender, RoutedEventArgs e)
		{
			dtotal1 += double.Parse(txtDisplay.Text);
			txtDisplay.Clear();
			ioperator = 1;
		}

		private void NumpadMinus_Click(object sender, RoutedEventArgs e)
		{
			dtotal1 += double.Parse(txtDisplay.Text);
			txtDisplay.Clear();
			ioperator = 2;
		}

		private void NumpadMultiply_Click(object sender, RoutedEventArgs e)
		{
			dtotal1 += double.Parse(txtDisplay.Text);
			txtDisplay.Clear();
			ioperator = 3;
		}

		private void NumpadDivide_Click(object sender, RoutedEventArgs e)
		{
			dtotal1 += double.Parse(txtDisplay.Text);
			txtDisplay.Clear();
			ioperator = 4;
		}

		private void NumpadEquals_Click(object sender, RoutedEventArgs e)
		{
			switch (ioperator)
			{
				case 1:
					dtotal2 = dtotal1 + double.Parse(txtDisplay.Text);
					break;
				case 2:
					dtotal2 = dtotal1 - double.Parse(txtDisplay.Text);
					break;
				case 3:
					dtotal2 = dtotal1 * double.Parse(txtDisplay.Text);
					break;
				case 4:
					dtotal2 = dtotal1 / double.Parse(txtDisplay.Text);
					break;
				default:
					/* 
					If ioperator does not include the value of one
					of the Cases the error code 1 is displayed.
					 */
					MessageBox.Show("Fehlercode: 1", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
					break;
			}
			txtDisplay.Text = dtotal2.ToString();
			dtotal1 = 0;
		}

		private void MenuExitClick(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
		// SidemenuClick ist verantwortlich für das Ein- und Ausklappen des seitlichen Menus
		private void SidemenuClick(object sender, RoutedEventArgs e)
		{
			//Das Seitenmenu und all seine Buttons wird ein und ausgeblendet
			if (gridSidemenu.Visibility == System.Windows.Visibility.Collapsed)
			{
				gridSidemenu.Visibility = System.Windows.Visibility.Visible;
				(sender as Button).Content = "X";
			}
			else
			{
				gridSidemenu.Visibility = System.Windows.Visibility.Collapsed;
				(sender as Button).Content = "=";
			}
		}

		private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}
