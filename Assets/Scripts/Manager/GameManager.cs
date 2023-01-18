using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject levelCompletedScreen;
    [SerializeField] private Transform starsContainers;
    [SerializeField] private GameObject wrongIcon;
    [SerializeField] private GameObject correctIcon;

    List<Transform> stars;

    int TotalStars;

    bool levelNotCompleted;

    float time;
    void Start()
    {
        levelCompletedScreen.SetActive(false);
        stars = GetChildren(starsContainers);

        wrongIcon.SetActive(false);
        correctIcon.SetActive(false);

        levelNotCompleted = true;
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

    }

    public void RestartLevel()
    {

    }

    public void NextLevel(Scene scene)
    {

    }

    

    public IEnumerator ShowResult(bool isCorrect)
    {
        levelNotCompleted = false;
        if (isCorrect)
        {
            correctIcon.SetActive(true);
            yield return new WaitForSeconds(3);
            correctIcon.SetActive(false);
            levelCompletedScreen.SetActive(true);
        }
        else
        {
            wrongIcon.SetActive(true);
            yield return new WaitForSeconds(3);
            wrongIcon.SetActive(false);
        }
    }



    void CountStars()
    {
        for (int i = 0; i < stars.Count; i++)
        {
            if (stars[i].gameObject.activeInHierarchy)
            {
                TotalStars += 1;
                //Debug.Log(TotalStars);
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
    }

    void DeductStars(int index)
    {
        stars[index].gameObject.SetActive(false);
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
