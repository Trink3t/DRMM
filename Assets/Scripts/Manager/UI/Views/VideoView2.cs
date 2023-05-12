using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoView2 : View
{
    [SerializeField] private Button backButton;
    [SerializeField] private VideoPlayer videoPlayer;

    public override void Init()
    {
        backButton.onClick.AddListener(()=>{

            Screen.orientation = ScreenOrientation.Portrait;
            videoPlayer.Stop();
            ViewManager.Show<VideosView>();
        });
    }

    private void OnEnable() 
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}
