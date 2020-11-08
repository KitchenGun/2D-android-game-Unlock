using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N_GameManager : MonoBehaviour {

    private networkgamemanager Nstagemanager;

    // Use this for initialization
    void Start () {

		if(Nstagemanager.N_stage == 1)
        {
            GameObject.Find("Player").SendMessage("Map01_Start");
        } else if (Nstagemanager.N_stage == 2)
        {
            GameObject.Find("Player").SendMessage("Map02_Start");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
