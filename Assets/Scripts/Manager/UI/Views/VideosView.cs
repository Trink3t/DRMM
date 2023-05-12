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

    [SerializeField] private Button Video1;
    [SerializeField] private Button Video2;
    [SerializeField] private Button Video3;
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
                ViewManager.Show<StatsView>();
            }
        );


        Video1.onClick.AddListener(
            ()=>
            {
                ViewManager.Show<VideoView1>();
            }
        );

        Video2.onClick.AddListener(
            ()=>
            {
                ViewManager.Show<VideoView2>();
            }
        );
        Video3.onClick.AddListener(
            ()=>
            {
                ViewManager.Show<VideoView3>();
            }
        );
    }
}
