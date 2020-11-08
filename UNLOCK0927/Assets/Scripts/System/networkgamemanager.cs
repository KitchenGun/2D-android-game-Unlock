using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class networkgamemanager : MonoBehaviour {

    public int N_stage;
    public int U_stage;
    public int N_stage2 = 0;
    public int N_stage3 = 0;
    public int N_stage4 = 0;
    public int N_stage5 = 0;


    private static int count = 0;
    private int index;
    void Awake()
    {
        index = count;
        count++;
        //Debug.Log("awake, " + gameObject.name + ", index is " + index);
        if (index == 0)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);

    }

}
