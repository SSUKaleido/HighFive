using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    TimingManager theTimingManager;
    public int Score = 0;

    public Text txt;

    void Start(){
        theTimingManager = FindObjectOfType<TimingManager>();
        txt.text = "Score : " + Score.ToString();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)){ //왼쪽
            //판정체크   
            theTimingManager.CheckTiming();
            txt.text = "Score : " + Score.ToString();
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){ //오른쪽
            theTimingManager.CheckTiming2();
            txt.text = "Score : " + Score.ToString();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){ //오른쪽
            theTimingManager.CheckTiming3();
            txt.text = "Score : " + Score.ToString();
        }
    }
}
