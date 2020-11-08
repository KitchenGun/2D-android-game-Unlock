using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next_Sc : MonoBehaviour {

    public GameObject[] t;
    public int gamestate = 0;

    public void plus() {
        t[gamestate].SetActive(false);
        t[gamestate+1].SetActive(true);
        gamestate++;
        if (gamestate > 5)
        {
            gamestate = 0;
        }
    }
    public void minus() {
        t[gamestate].SetActive(false);
        gamestate--;
        if (gamestate <0)
        {
            gamestate =5;
        }
        t[gamestate].SetActive(true);
    }
}