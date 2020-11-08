using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ctrl : MonoBehaviour {

    Transform trCube;
    float CurrentZRotation = 0.0f;
    
    public float Speed = 50.0f;

	// Use this for initialization
	void Start () {
        trCube = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.RightArrow))
        {
            CurrentZRotation -= Time.deltaTime * Speed;
            trCube.rotation = Quaternion.Euler(0.0f, 0.0f, CurrentZRotation);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            CurrentZRotation += Time.deltaTime * Speed;
            trCube.rotation = Quaternion.Euler(0.0f, 0.0f, CurrentZRotation);
        }

    }
}
