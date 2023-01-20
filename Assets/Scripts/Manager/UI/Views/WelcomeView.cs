using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WelcomeView : View
{
    [SerializeField] private Button tapButton;

    public override void Init()
    {
        tapButton.onClick.AddListener(
            ()=>
            {
                CheckPlayerData();
            }
        );
    }

    void CheckPlayerData()
    {
        if (PlayerDataManager.GetInstance().PlayerDataExists())
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            ViewManager.Show<RegistrationView>();
        }
    }
}
