using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Direction//방향지정
{
    Right=0,
    Bottom=1,
    Left=2,
    Top=3
}

public class NetworkControl : MonoBehaviour
{
    Direction N_moveDirD;
    Vector3 N_dirV;

    public float N_speedF = 1.0f;//초기 속도

    public int N_stageI = 1;

    void Start()
    {
        Restart();
    }
    
    void Update()
    {
        //예외처리
        if(Direction.Right> N_moveDirD)
        {
            N_moveDirD = Direction.Top;
        }
        if (Direction.Top < N_moveDirD)
        {
            N_moveDirD = Direction.Right;
        }
        //키 조작
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            N_moveDirD -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            N_moveDirD += 1;
        }

        //방향 설정
        switch (N_moveDirD)
        {
            case Direction.Right:
                N_dirV = Vector3.right;
                break;
            case Direction.Bottom:
                N_dirV = -Vector3.up;
                break;
            case Direction.Left:
                N_dirV = -Vector3.right;
                break;
            case Direction.Top:
                N_dirV = Vector3.up;
                break;
        }
        //방향콘솔창에띄움
        Debug.Log(N_moveDirD);
        //이동
        this.transform.position += N_dirV*N_speedF * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))//일시정지 풀기
        {
            Time.timeScale = 1;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Wall")
        {

            Restart();
            Debug.Log("!!!");
        }
    }


    void Restart()
    {
        Vector3 Reset=Vector3.zero;

        Reset.x = -5.0f;
        Reset.y = -1.0f;

        N_moveDirD = Direction.Right;//스폰방향

        Vector3 StartPos=Reset;//스타팅포인트
        
        switch(N_stageI)
        {
            case 1:
                Reset = new Vector3(-5, -1, 0);
                this.transform.position = Reset;
                break;
            case 2:
                Reset = new Vector3(15, -1, 0);
                N_moveDirD = Direction.Right;
                this.transform.position = Reset;
                break;
            case 3:
                Reset = new Vector3(35, -1, 0);
                Debug.Log("ddd");
                this.transform.position = Reset;
                break;
            case 4:
                Reset = new Vector3(55, -1, 0);
                this.transform.position = Reset;
                break;
            case 5:
                Reset = new Vector3(75, -1, 0);
                this.transform.position = Reset;
                break;
        }

        

        //Time.timeScale = 0;//일시정지
    }

    private void OnTriggerEnter(Collider other)//맵1의 골지점에 도착
    {
        GetComponent<Rigidbody>().WakeUp();
        if (other.gameObject.name == "NmM01_Goal")
        {
            Map02_Start();
        }
        if (other.gameObject.name == "NmM02_Goal")
        {
            Map03_Start();
        }
    }

    public void Map01_Start()
    {
        transform.transform.position = new Vector3(-5, -1, 0);//맵2의 시작지점으로 텔레포트

        N_moveDirD = Direction.Right;//각도 초기화

        Time.timeScale = 0;//일시정지

        GameObject.Find("Main Camera").SendMessage("Map01_Cam");//카메라 이동

        N_speedF = 2.0f;//속도 증가

        N_stageI = 2;//스테이지 2로 넘어감
    }
    public void Map02_Start()
    {
        transform.transform.position = new Vector3(15, -1, 0);//맵2의 시작지점으로 텔레포트

        N_moveDirD = Direction.Right;//각도 초기화

        Time.timeScale = 0;//일시정지

        GameObject.Find("Main Camera").SendMessage("Map02_Cam");//카메라 이동

        N_speedF = 2.0f;//속도 증가

        N_stageI = 3;//스테이지 2로 넘어감
    }
    public void Map03_Start()
    {
        transform.transform.position = new Vector3(35, -1, 0);//맵2의 시작지점으로 텔레포트

        N_moveDirD = Direction.Right;//각도 초기화

        Time.timeScale = 0;//일시정지

        GameObject.Find("Main Camera").SendMessage("Map03_Cam");//카메라 이동

        N_speedF = 2.0f;//속도 증가

        N_stageI = 4;//스테이지 4로 넘어감
    }
}

//첫번째
/*
    Player.transform.localPosition += Vector3.right*Time.deltaTime;
    if (Input.GetKey(KeyCode.RightArrow))
    {
        Player.transform.localPosition -= Vector3.right * Time.deltaTime;
        Player.transform.localPosition -= Vector3.up * Time.deltaTime;
    }
    else if (Input.GetKey(KeyCode.LeftArrow))
    {
        Player.transform.localPosition -= Vector3.right * Time.deltaTime;
        Player.transform.localPosition += Vector3.up * Time.deltaTime;
    }
*/
//두번째
/*
    public GameObject Player;
    int count = 0;//0=오른쪽, 1=아래, 2=왼쪽, 3=위쪽
 
    //예외처리
    if (count == 4)
    {
        count = 0;
    }
    if (count == -1)
    {
        count = 3;
    }
    //조작
    if (Input.GetKeyDown(KeyCode.RightArrow))
    {
        count += 1;
    }
    if (Input.GetKeyDown(KeyCode.LeftArrow))
    {
        count -= 1;
    }
    //방향설정
    if (count == 0)
    {
        Player.transform.localPosition += Vector3.right * Time.deltaTime;
    }
    if (count == 1)
    {
        Player.transform.localPosition -= Vector3.up * Time.deltaTime;
    }
    if (count == 2)
    {
        Player.transform.localPosition -= Vector3.right * Time.deltaTime;
    }
    if (count == 3)
    {
        Player.transform.localPosition += Vector3.up * Time.deltaTime;
*/
