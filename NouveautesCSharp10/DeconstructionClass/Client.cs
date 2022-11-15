namespace DeconstructionClass;

public class Client
{
    public int idClient { get; set; }
    public string nomClient { get; set; }

    public void Deconstruct(out int id, out string nom)
    {
        id = idClient;
        nom = nomClient;
    }
}

