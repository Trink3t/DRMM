using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RegistrationView : View
{
    [SerializeField] private Button nextButton;
    [SerializeField] private TMP_InputField nameText;
    public override void Init()
    {
        nextButton.onClick.AddListener(
            ()=> 
            {
                PlayerDataManager.GetInstance().playerData.name = nameText.text;
                ViewManager.Show<GradeLevelView>();
            }
        );
    }
}
