using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPanelView : View
{
    [SerializeField] private Button backButton, aboutButton;
    public override void Init()
    {
        backButton.onClick.AddListener(
            ()=>
            {
                ViewManager.ShowLast();
            }
        );

        aboutButton.onClick.AddListener(
            ()=>
            {

            }
        );
    }
}
