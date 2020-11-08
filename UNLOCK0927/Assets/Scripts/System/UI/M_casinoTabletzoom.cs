using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class M_casinoTabletzoom : MonoBehaviour
{
    public bool Tableton = false; // 타블렛이 확대되었습니다.
    public GameObject tablet_Casino_UI;
    public GameObject tablet_zoomin_UI;
    public Image M_tabletImage;//태블릿
    public Sprite[] sprites;
    public void Awake()
    {
        M_tabletImage = GetComponent<Image>();
        Debug.Log(M_tabletImage.rectTransform.localScale.x);
    }
    public void tabletzoomin() // 타블렛을 눌렀음
    {
        if (Tableton == false)
        {
            gameObject.GetComponent<Image>().sprite = sprites[0];
            float sc = 1.5f;
            this.transform.localScale = new Vector2(M_tabletImage.rectTransform.localScale.x*sc, M_tabletImage.rectTransform.localScale.y*sc); //타블렛확대
            //2080 / 1170
            Tableton = true;
            tablet_Casino_UI.SetActive(true); // UI 액티브
            tablet_zoomin_UI.SetActive(false);
        }
    }

    void Update()
    {
        if(Tableton == true) // 타블렛 확대상태
        {
            if (Input.GetKey(KeyCode.Backspace)) // 뒤로키눌름
            {
                gameObject.GetComponent<Image>().sprite = sprites[1];
                this.transform.localScale = new Vector2(1240, 790);
                    tablet_Casino_UI.SetActive(false);
                    tablet_zoomin_UI.SetActive(true);
                Tableton = false; 
            }
        }
    }


}
