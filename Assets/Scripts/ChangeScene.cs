using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class ChangeScene : MonoBehaviour
{
    public void changescene(string scenename)
    {
        SceneManager.LoadScene (scenename);
        
    }
}
