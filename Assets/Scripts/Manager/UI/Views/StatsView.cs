using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatsView : View
{
    [SerializeField] private TMP_Text nameText, gradeLevelText, starsCollectedText;

    [SerializeField] private Button backButton, settingsButton, moduleButton, videoButton;
    public override void Init()
    {
        nameText.text = PlayerDataManager.GetInstance().playerData.name;
        gradeLevelText.text = PlayerDataManager.GetInstance().playerData.gradelevel.ToString();
        gradeLevelText.text = PlayerDataManager.GetInstance().GetTotalStars().ToString();

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
        videoButton.onClick.AddListener(
            ()=> 
            {
                ViewManager.Show<VideosView>();
            }
        );
    }
}
