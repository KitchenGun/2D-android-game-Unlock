using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNetwork : MonoBehaviour {

    public GameObject[] stageoj;
    private networkgamemanager Nstagemanager;


    // Use this for initialization
    public void Loadnetwork1()
    {
        //Nstagemanager.N_stage = 1;
        SceneManager.LoadScene("01_Network");
            
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
