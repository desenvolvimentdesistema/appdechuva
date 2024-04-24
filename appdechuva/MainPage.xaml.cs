 
public partial class MainPage : ContentPage
{
	int count = 0;

    public MainPage()
	{
 		InitializeComponent();
	}

    void TestaLayout();
	{
		Const String Url="https://api.hgbrasil.com/weather?woeid=455927&Key=f5f447f3"
		Resulsts Resposta
		void Atualiza Tempo()
		
	}
           try
		   {
			
		   var httpClient=new Http Client();
		   var Response=await Http Client.Get Async(Url);
		   If (Response) (Is Success Status Code)
		   }
			String content=Response.Content.Read As String Async();
			-resposta=Json Serializer.Deserialize<Results>(content);
		   {

		   }
			catch (Exception e)

			{
				// Erro	
		   	}
	{
		if (results.currently=="Sol")
		{
			if (results.rain >=50 )
				imgBackground.Source = "chuvadedia.jpg";
			else if (results.cloudness >=50 )
				imgBackground.Source = "nublado.jpg";
			else
				imgBackground.Source = "sol.jpg";
			}
	}
		else
		{
			if (results.currently=="Night")
		{
			if (results.rain >=50 )
				imgBackground.Source = "chuvadenoite.jpg";
			else if (results.cloudness >=50 )
				imgBackground.Source = "noitenublada.jpg";
			else
				imgBackground.Source = "noite.jpg";
		}

		}
}

