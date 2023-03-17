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
    public void MoveTo4H1(){
        SceneManager.LoadScene("Beet_4H1");
    }
    public void MoveTo4H2(){
        SceneManager.LoadScene("Beet_4H2");
    }
    public void MoveTo4H3(){
        SceneManager.LoadScene("Beet_4H3");
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
    public void MoveToR4(){    //리듬게임4으로 이동
        SceneManager.LoadScene("Rhythm4");
    }
    public void MoveToR5(){    //리듬게임5으로 이동
        SceneManager.LoadScene("Rhythm5");
    }
    public void MoveToR6(){    //리듬게임6으로 이동
        SceneManager.LoadScene("Rhythm6");
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
    public void SaveBeet(){
        SceneManager.LoadScene(ScoreManager.BeetScene);
    }
    public void SaveMozart(){
        SceneManager.LoadScene(ScoreManager.MozartScene);
    }
    public void Moveroom(){
        SceneManager.LoadScene("room2");
    }
    public void Moveroom_s(){
        SceneManager.LoadScene("room_S");
    }




    public void GameExit(){    //게임나가기
        Application.Quit();
    }
}
