using System.Reflection.Emit;

namespace appdetempo;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage()
	{
 		InitializeComponent();
	}

    void TestaLayout();
	{
		Results = new Results();
		Results.Temp=23;
		Results.Description="Sunrise";
		Results.City= "Seul";
	}
	void Preencher Tela();
	{
		if (results.currently=="Sol")
		{
			if (results.rain >=50 )
				imgBackground.Source = "rainysky.jpg";
			else if (results.cloudness >=50 )
				imgBackground.Source = "ceunublado.jpg";
			else
				imgBackground.Source = "ceuensolarado.jpg";
			}
	}
		else
		{
			if (results.currently=="Night")
		{
			if (results.rain >=50 )
				imgBackground.Source = "chuvadenoite.jpg";
			else if (results.cloudness >=50 )
				imgBackground.Source = "darkernightsky.jpg";
			else
				imgBackground.Source = "nightsky.jpg";
		}

		}
}