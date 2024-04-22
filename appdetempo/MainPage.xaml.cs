using System.Reflection.Emit;

namespace appdetempo;

public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage();
	
 	InitializeComponent();
    void Testa Layout();
	{
		Results = new Results();
		Results.Temp=23;
		Results.Description="Sol";
		Results.Rain=10;
	}
	void Preencher Tela();
	{
		LabelChuva.Text=Results.Rain;
		LabelUmidade.Text=Results.Humidity;
		LabelTemp.Text=Results.Temp;

	}
	

	
}

