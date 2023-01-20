using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class PlayerDataManager : Singleton<PlayerDataManager>
{
    public PlayerData playerData;
    public string PlayerDataPath {get; private set;}
    [SerializeField] int maxStars;
    int totalStars;
    public override void Awake()
    {
        base.Awake();

        PlayerDataPath = Application.persistentDataPath + "/data.json";
        playerData = new PlayerData();
        if (PlayerDataExists())
        {
            LoadGame();
        }

        totalStars = 0;
    }

    public void SaveGame()
    {
        string json = JsonConvert.SerializeObject(playerData);
        File.WriteAllText(PlayerDataPath, json);
    }

    public void LoadGame()
    {
        playerData = JsonConvert.DeserializeObject<PlayerData>(File.ReadAllText(PlayerDataPath));
    }

    public bool PlayerDataExists()
    {
        return File.Exists(PlayerDataPath);
    }

    public int GetTotalStars()
    {
        for (int i = 0; i < playerData.levelscompleted.Count; i++)
        {
            totalStars += playerData.levelscompleted[i].stars;
        }
        return (totalStars == 0) ? 0 : totalStars;
    }
}
