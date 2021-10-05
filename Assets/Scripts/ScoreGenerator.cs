using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//Event system'e ekledim script olarak
public class ScoreGenerator : MonoBehaviour
{

    public Text coin_point_text;
    public static int coin_point = 0;

    // Update is called once per frame
    void Update()
    {
        coin_point_text.text = coin_point.ToString();
    }
}
