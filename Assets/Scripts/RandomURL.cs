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
            "https://www.mindful.org/how-to-meditate-3/",
            "https://www.gaiam.com/blogs/discover/meditation-101-techniques-benefits-and-a-beginner-s-how-to",
            "https://www.mentalhealth.gov/get-help/immediate-help",
            "https://inspirobot.me",
            "https://sunshineadc.com/7-fun-games-improve-mental-health/",
            "https://www.verywellmind.com/top-websites-and-games-for-brain-exercise-2224140",
            "https://greatergood.berkeley.edu/article/item/ten_ways_to_become_more_grateful1",
            "https://careersinpsychology.org/7-quick-easy-mental-health-exercises-help-day/",
            "https://www.acmc.edu/how-students-can-stay-positive-towards-school/",
            "https://www.caba.org.uk/help-and-guides/information/how-and-why-boost-your-alpha-brainwaves"
            
            
            
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
