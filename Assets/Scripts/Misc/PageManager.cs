using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PageManager : MonoBehaviour
{
    [SerializeField] GameObject page;
    int numOfPages;

    void Start()
    {
        var pageImages = Resources.LoadAll<Sprite>("Modules/English");

        //Debug.Log(pages.Length);

        for (int i = 0; i < pageImages.Length; i++)
        {
            var pagePrefab = Instantiate(page, this.transform);
            pagePrefab.GetComponent<Image>().sprite = Resources.Load<Sprite>("Modules/English/ENGLISH MODULE_Page_" + (i+1));
        }
    }
}
