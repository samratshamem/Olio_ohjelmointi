using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class JoukkueService
{
    private readonly string filePath = "joukkueet.json";

    public List<Joukkue> LataaJoukkueet()
    {
        if (!File.Exists(filePath))
        {
            return new List<Joukkue>();
        }

        string json = File.ReadAllText(filePath);

        return JsonConvert.DeserializeObject<List<Joukkue>>(json);
    }

    public void TallennaJoukkueet(List<Joukkue> joukkueet)
    {
        string json = JsonConvert.SerializeObject(joukkueet, Formatting.Indented);

        File.WriteAllText(filePath, json);
    }
}
