using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Event system'e ekledim script olarak
public class LifeCounter : MonoBehaviour
{
    public static int life_num = 3;
    public Text life_text;

    void Update()
    {
        life_text.text = life_num.ToString();    
    }

}
