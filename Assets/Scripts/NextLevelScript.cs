using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    //Scene 0 main menu
    //Scene1 level 1
    //Scene2 level 2
    public void Nextlevel_Function()
    {
        SceneManager.LoadScene(2);
    }
   
}
