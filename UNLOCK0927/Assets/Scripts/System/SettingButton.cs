using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour {

    private bool isMenuActive;
    public GameObject SettingMenu;


    private void Start()
    {
        SettingMenu.SetActive(false);
        isMenuActive = SettingMenu.activeSelf;
        //다른 클래스와 데이터 교환이 필요하여 그 변수를 public으로 선언하고 직접 접근하게되면
        //의도치않은 데이터의 수정이 발생할 수 있기 때문에 교환이 필요한 데이터는 직접 접근 할 수 없게 private로 선언한 후,
        //데이터를 전달, 수정하기 위해 public으로 선언된 Get, Set 함수를 이용한다.
        
        //※예외적인 경우로, GameObject 클래스에서 active 데이터를 전달하는 Get함수 대신 publuc으로 선언된 activeSelf 변수를 사용한다.
    }
    
    
    public void OnSetting()//버튼클릭시 실행함수
    {
        if(isMenuActive==false)
        {
            this.SettingMenu.SetActive(true);
            isMenuActive = true;
        }
        else
        {
            this.SettingMenu.SetActive(false);
            isMenuActive = false;
        }
    }
}
