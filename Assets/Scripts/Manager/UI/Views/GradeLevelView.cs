using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GradeLevelView : View
{
    [SerializeField] private Button nextButton;
    [SerializeField] private TMP_InputField gradeLevelText;
    public override void Init()
    {
        nextButton.onClick.AddListener(
            ()=> 
            {
                PlayerDataManager.GetInstance().playerData.gradelevel = Int32.Parse(gradeLevelText.text);
                PlayerDataManager.GetInstance().SaveGame();
                SceneManager.LoadScene("MainMenu");
            }
        );
    }
}
