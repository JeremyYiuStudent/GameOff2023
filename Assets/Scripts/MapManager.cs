using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public void LoadScene(string s){
        SceneManager.LoadScene(s);
    }
    public void ExitApp(){
        Application.Quit();
    }
}
