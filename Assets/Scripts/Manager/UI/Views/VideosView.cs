using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideosView : View
{
    [SerializeField] private Button backButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button moduleButton;
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
        
        moduleButton.onClick.AddListener(
            ()=> 
            {
                ViewManager.Show<ModulesView>();
            }
        );
        statsButton.onClick.AddListener(
            ()=> 
            {
                
            }
        );
    }
}
