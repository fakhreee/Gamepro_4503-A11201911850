using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnStart(){
        SceneManager.LoadScene("Level");
    }

    public void OnEasy(){
        SceneManager.LoadScene("easy");
    }

    public void OnMedium(){
        SceneManager.LoadScene("medium");
    }

    public void OnHard(){
        SceneManager.LoadScene("hard");
    }
}
