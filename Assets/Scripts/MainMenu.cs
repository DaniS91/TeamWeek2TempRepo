using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // you will need to find the name of the scene to load on clicking start; 
    // and then add it to the script component

    // also you will need to add the next scene to build settings:
    // go to file>>Build Settings.. Add Open Scenes
    public string startScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(startScene);
    }

    public void ExitGame()
    {
        //this will not work in unity, it will only work in the actual game if deployed
        //remove debug line when finished
        Application.Quit();
        Debug.Log("Quitting Game");
    }
}
