namespace appdechuva;
public class Resposta
{
    public Results Results {get;set;}
}
    Results Results;
    Resposta Resposta;
void MainPage()
    {
        InitializeComponet();
        Atualiza Tempo();
    }
void Preenche Tela()
{
    LabelTemp.Text = Results.Temp.ToString()
    LabelTemp.Text = Resposta.Results.Temp.ToString();
}
void AtualizaTempo()
{
    Results=Json Serializer.Deserealizer<Results>(Content);
    Resposta=Json Serializer.Deserealizer<Resposta>
        PreencheTela();
}