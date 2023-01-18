using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public bool isCorrect;

    [SerializeField] private GameManager gameManager;

    void Start()
    {

        gameObject.GetComponent<Button>().onClick.AddListener(
            ()=>
            {
                gameManager.StartCoroutine(gameManager.ShowResult(isCorrect));
            }
        );
    }

    
}
