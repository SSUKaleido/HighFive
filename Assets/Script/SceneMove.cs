using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public void MoveToB1(){
        SceneManager.LoadScene("Beet_1");
    }
    public void MoveToB2(){
        SceneManager.LoadScene("Beet_2");
    }
    public void MoveToB3(){
        SceneManager.LoadScene("Beet_3");
    }
    public void MoveToR1(){    //리듬게임1로 이동
        SceneManager.LoadScene("Rhythm1");
    }
    public void MoveToR2(){    //리듬게임2로 이동
        SceneManager.LoadScene("Rhythm2");
    }
    public void MoveToR3(){    //리듬게임3으로 이동
        SceneManager.LoadScene("Rhythm3");
    }
    public void MoveToMH2(){
        SceneManager.LoadScene("Mozart_4_H2");
    }
    public void MoveToMH3(){
        SceneManager.LoadScene("Mozart_4_H3");
    }
    public void MoveToMH1(){
        SceneManager.LoadScene("Mozart_4_H1");
    }




    public void GameExit(){    //게임나가기
        Application.Quit();
    }
}
