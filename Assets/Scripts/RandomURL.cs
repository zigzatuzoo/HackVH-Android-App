using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenRandomArticle()
    {
        var urlList = new ArrayList()
        {
            "https://youtube.com",
            "https://google.com"
        };

        int randNum = Random.Range(0, urlList.Count);

        //Debug.Log("the number is:" + randNum);

        string urlOpened = (string)urlList[randNum];

        

        Application.OpenURL(urlOpened);
    }
    public void OpenRandomHelp()
    {
        var helpList = new ArrayList()
        {
            "https://youtube.com",
            "https://google.com"
        };

        int randNumTwo = Random.Range(0, helpList.Count);

        //Debug.Log("the number is:" + randNum);

        string helpOpened = (string)helpList[randNumTwo];



        Application.OpenURL(helpOpened);
    }

}
