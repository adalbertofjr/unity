using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public static int scorep1;
    public static int scorep2;


    // Start is called before the first frame update
    void Start()
    {
        scorep1 = 0;
        scorep2 = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 90, 30), "Player 1: " + scorep1);
        GUI.Box(new Rect(Screen.width - 100, 10, 90, 30), "Player 2: " + scorep2);
    }
}
