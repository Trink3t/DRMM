using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] private Button quitButton, settingsButton, videosButton, moduleButton, statsButton;

    public override void Init()
    {
        PlayerDataManager.GetInstance().LoadGame();
        quitButton.onClick.AddListener(
            ()=> 
            {
                Application.Quit();
            }
        );
        settingsButton.onClick.AddListener(
            ()=> 
            {
                ViewManager.Show<SettingsPanelView>();
            }
        );
        videosButton.onClick.AddListener(
            ()=> 
            {
                ViewManager.Show<VideosView>();
            }
        );
        moduleButton.onClick.AddListener(
            ()=> 
            {
                ViewManager.Show<ModulesView>();
            }
        );
        statsButton.onClick.AddListener(
            ()=> 
            {
                ViewManager.Show<StatsView>();
            }
        );
    }
}
