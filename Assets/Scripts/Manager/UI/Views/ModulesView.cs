using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModulesView : View
{
    [SerializeField] private Button backButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button videosButton;
    [SerializeField] private Button statsButton;
    public override void Init()
    {
        backButton.onClick.AddListener(
            ()=>
            {
                ViewManager.Show<MainMenuView>();
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
        statsButton.onClick.AddListener(
            ()=> 
            {
                ViewManager.Show<StatsView>();
            }
        );
    }
}
