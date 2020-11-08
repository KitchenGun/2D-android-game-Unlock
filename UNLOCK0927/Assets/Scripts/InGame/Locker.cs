using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    [SerializeField]
    float rotSpeed = 5.0f;
    
    float answer;
    [SerializeField]
    float Approx = 0.3f;
    float hint;
    bool isRight = false;

    // Use this for initialization
    void Start ()
    {
        answer = Random.Range(0.0f, 360.0f);
        hint = Random.Range(answer - 90.0f, answer + 90.0f);

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftShift) && (rotSpeed < 50.0f))
        {
            rotSpeed += 2;
        }
        else if (Input.GetKey(KeyCode.LeftControl) && (rotSpeed > 5))
        {
            rotSpeed -= 2;
        }

		if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(new Vector3(0, 0, rotSpeed) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(new Vector3(0, 0, -rotSpeed) * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (this.transform.eulerAngles.z > answer - Approx &&
                this.transform.eulerAngles.z < answer + Approx)
                Destroy(this.gameObject);
        }

        if (this.transform.eulerAngles.z > answer - Approx &&
                this.transform.eulerAngles.z < answer + Approx)
            isRight = true;
        else
            isRight = false;

        //this.transform.rotation.z;
        //this.transform.localRotation.z;
        //this.transform.eulerAngles.z;
        //this.transform.localEulerAngles.z;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 500, 50),
            "IsRight : " + isRight);
        GUI.Label(new Rect(10,10,1000,100),
            "현재 값 : " + this.transform.eulerAngles.z +
            "\n예측 값 : " + hint);
    }
}
