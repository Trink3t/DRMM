using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drop : MonoBehaviour, IDropHandler
{
    [SerializeField] bool isCorrect;
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject afterCorrect = null;
    [SerializeField] GameObject item = null;


    public void OnDrop(PointerEventData eventData)
    {
        if (isCorrect)
        {
            if (item != null && afterCorrect != null)
            {
                item.SetActive(false);
                afterCorrect.SetActive(true);
            }
            
            gameObject.SetActive(false);
        }

        gameManager.StartCoroutine(gameManager.ShowResult(isCorrect));
    }
}
