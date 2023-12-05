namespace DesafioPOO.Models;

public abstract class Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string IMEI { get; set; }
    public int Memoria { get; set; }
    public DateTime DataFabricacao { get; set; }
    // TODO: Implementar as propriedades faltantes de acordo com o diagrama


    protected Smartphone(string numero, string modelo, string iMEI, int memoria, DateTime dataFabricacao)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = iMEI;
        Memoria = memoria;
        DataFabricacao = dataFabricacao;
    }

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public void RetornarInformacaoSmartphone()
    {
        Console.WriteLine($"Numero: {this.Numero}\nModelo: {this.Modelo}\n" +
                          $"IMEI: {this.IMEI}\nMemoria: {this.Memoria}\n" +
                          $"Ano da Fabricacao: {this.DataFabricacao.ToString("yyyy")}");
    }

    public abstract void InstalarAplicativo(string nomeApp);
}
