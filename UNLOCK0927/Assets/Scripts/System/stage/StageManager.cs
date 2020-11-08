using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : networkgamemanager
{

    public GameObject N_stage_lock_2;
    public GameObject N_stage_lock_3;
    public GameObject N_stage_lock_4;
    public GameObject N_stage_lock_5;

    void Update()
    {
        if (N_stage2 == 1)
        {
            Destroy(N_stage_lock_2);
        }
        if (N_stage3 == 1)
        {
            Destroy(N_stage_lock_3);
        }
        if (N_stage4 == 1)
        {
            Destroy(N_stage_lock_4);
        }
        if (N_stage5 == 1)
        {
            Destroy(N_stage_lock_5);
        }

    }
}
