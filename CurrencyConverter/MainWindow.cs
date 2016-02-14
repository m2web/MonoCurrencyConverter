using System;
using Gtk;

//Author: Mark McFadden
//Date: 2/14/16
//Pupose: Demo other tools for windows form development

public partial class MainWindow: Gtk.Window
{
	Decimal decPesoConversion = 18.91m;
	Decimal decEuroConversion = 0.89m;
	Decimal decMarkConversion = 1.72m;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnBtnConvertClicked (object sender, EventArgs e)
	{
		//convert the amount of US Dollars into the currencies below
		lblPesoAmount.Text = (Convert.ToInt32(tboxAmountEntry.Text) * decPesoConversion).ToString("N2");
		lblEuroAmount.Text = (Convert.ToInt32(tboxAmountEntry.Text) * decEuroConversion).ToString("N2");
		lblMarkAmount.Text = (Convert.ToInt32(tboxAmountEntry.Text) * decMarkConversion).ToString("N2");
	}

	protected void OnBtnClearClick (object sender, EventArgs e)
	{
		//clear the form input
		tboxAmountEntry.Text = "";
		lblPesoAmount.Text = "Peso Amount";
		lblEuroAmount.Text = "Euro Amount";
		lblMarkAmount.Text = "Mark Amount";
		tboxAmountEntry.IsFocus = true;
	}

	protected void OnBtnExitClick (object sender, EventArgs e)
	{
		//stop application execution
		Application.Quit ();
	}

	//This is required by framework
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
