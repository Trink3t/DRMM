using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject levelCompletedScreen;
    [SerializeField] private Transform starsContainers;
    [SerializeField] private Transform starsCompleted;
    [SerializeField] private GameObject wrongIcon;
    [SerializeField] private GameObject correctIcon;

    [SerializeField] private string nextLevel;

    List<Transform> stars, starsComplete;

    int TotalStars;

    bool levelNotCompleted;
    string currentScene;

    float time;
    void Start()
    {
        levelCompletedScreen.SetActive(false);
        stars = GetChildren(starsContainers);
        starsComplete = GetChildren(starsCompleted);

        wrongIcon.SetActive(false);
        correctIcon.SetActive(false);

        levelNotCompleted = true;

        CountStars();

        currentScene = SceneManager.GetActiveScene().name;
    }
    void Update()
    {
        if (levelNotCompleted)
        {
            CheckTime();
        }  
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }

    bool IsLevelDone(int i)
    {
        return PlayerDataManager.GetInstance().playerData.levelscompleted[i].levelname.Contains(currentScene) && PlayerDataManager.GetInstance().playerData.levelscompleted[i].stars < TotalStars;
    }
    

    public IEnumerator ShowResult(bool isCorrect)
    {
        levelNotCompleted = false;
        CountStars();
        if (isCorrect)
        {
            correctIcon.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            correctIcon.SetActive(false);
            levelCompletedScreen.SetActive(true);
            for (int i = 0; i < PlayerDataManager.GetInstance().playerData.levelscompleted.Count; i++)
            {
                if(IsLevelDone(i))
                {
                    
                    PlayerDataManager.GetInstance().playerData.levelscompleted.RemoveAt(i);
                    PlayerDataManager.GetInstance().playerData.levelscompleted.Add(new Levelscompleted
                    {
                        levelname = currentScene,
                        stars = TotalStars
                    } 
                    );
                }
            }

            
            PlayerDataManager.GetInstance().SaveGame();
        }
        else
        {
            wrongIcon.SetActive(true);
            yield return new WaitForSeconds(1.5f);
            wrongIcon.SetActive(false);
        }
    }



    void CountStars()
    {
        TotalStars = 0;
        for (int i = 0; i < stars.Count; i++)
        {
            if (stars[i].gameObject.activeInHierarchy)
            {
                TotalStars += 1;
                Debug.Log(TotalStars);
            }
        }
    }


    void CheckTime()
    {
        time = Mathf.Round(Time.time);
        if (time == 10)
        {
            DeductStars(2);
        }
        if (time == 20)
        {
            DeductStars(1);
        }
        CountStars();
    }

    void DeductStars(int index)
    {
        stars[index].gameObject.SetActive(false);
        starsComplete[index].gameObject.SetActive(false);
    }

    List<Transform> GetChildren(Transform parent)
    {
        List<Transform> children = new List<Transform>();

        foreach (Transform child in parent)
        {
            children.Add(child);
        }

        return children;
    }
}
