using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject levelCompletedScreen;
    [SerializeField] private Transform starsContainers;

    List<GameObject> stars;
    int NumberOfStars;
    int CurrentNumberOfStars;

    float time;
    void Start()
    {
        levelCompletedScreen.SetActive(false);
        NumberOfStars = 3;
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

    public void ShowLevelCompleted()
    {

    }

    void Update()
    {
        CheckTime();

        
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
        List<Transform> stars = GetChildren(starsContainers);

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
