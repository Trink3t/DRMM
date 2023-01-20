using System.Collections.Generic;

[System.Serializable]
public class Levelscompleted
{
    public string levelname { get; set; }
    public int stars { get; set; }
}

[System.Serializable]
public class PlayerData
{
    public string name { get; set; }
    public int gradelevel { get; set; }
    public List<Levelscompleted> levelscompleted { get; set; }
    public PlayerData()
    {
        this.levelscompleted = new List<Levelscompleted>();
    }
}