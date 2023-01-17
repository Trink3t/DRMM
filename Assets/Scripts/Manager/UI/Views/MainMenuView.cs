using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : View
{
    [SerializeField] private Button quitButton, settingsButton, videosButton, moduleButton, statsButton;

    public override void Init()
    {
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
                
            }
        );
        statsButton.onClick.AddListener(
            ()=> 
            {
                
            }
        );
    }
}
