using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SLoader : MonoBehaviour
{

    public void LoadNextScene()
    {
        //if(GlobalData.dropDownNr == 0)
        //{
        //    GlobalData.dropDownNr = 0;
        //}
        //else if (GlobalData.dropDownNr == 0)
        //{
        //    GlobalData.dropDownNr = 1;
        //}
        //We declare variable called currentSceneIndex and is within SceneManager class when its saying run method
        //GetActiveScene() and the thing that we want to know its build Index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    //When we want to start the game from begining
    public void LoadStartScene()
    {
        GlobalData.points = 0;   
        SceneManager.LoadScene(0);

    }

    //void DisplayTrash(Scene scene,  LoadSceneMode mode)
    //{

    //    if (scene.name == "Game Over"){
          //}
 
            
    //}

 

    //private void OnEnable()
    //{
    //    SceneManager.sceneLoaded += DisplayTrash;
    //}

    public void QuitGame()
    {
        Application.Quit();
    }

    //private void OnDisables()
    //{
    //    SceneManager.sceneLoaded -= DisplayTrash;
    //}

}
