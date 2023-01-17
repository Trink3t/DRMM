using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private List<Button> categoryButtons;
    [SerializeField] private List<Button> scenarioButtons;
    [SerializeField] private GameObject scenarioButtonsHandler;
    int currentCategory;
    int currentScenario;

    void Start()
    {
        for (int i = 0; i < categoryButtons.Count; i++)
        {
            int index = i + 1;

            if (categoryButtons[i] != null)
                categoryButtons[i].onClick.AddListener(()=> SetCategory(index));
        }

        for (int j = 0; j < scenarioButtons.Count; j++)
        {
            int index = j + 1;
            string currentButtonName = "";


            if (scenarioButtons[j] != null)
            {
                currentButtonName = scenarioButtons[j].gameObject.name;

                scenarioButtons[j].onClick.AddListener(()=> LoadScenario(currentButtonName));
            }
        }
    }

    

    //private Functions
    void SetCategory(int category)
    {
        this.currentCategory = category;
        ViewManager.Show<LevelSelectorView>();
    }

    void LoadScenario(string scenario)
    {
        SceneManager.LoadScene(currentCategory + " " + scenario);
    }

    
}
