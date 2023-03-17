using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class talk : MonoBehaviour
{
    int talkCnt = 3; //대화 개수
    int strCnt = 0; //현재 대화수
    string[] talks; //대화 리스트
    public Text txt; //대화 출력
    public Text talkname; //현재 말하는 사람 이름
    public Image showText; //대화 박스 이미지
    public string sceneName; //다음씬이름
    
    int []showCnt;

    // Start is called before the first frame update
    void Start()
    {
        talks = new string[talkCnt];
        showCnt = new int[talkCnt];
        txt = GameObject.Find("Canvas").transform.Find("Text").GetComponent<Text>();
        talkname = GameObject.Find("Canvas").transform.Find("name").GetComponent<Text>();
        showText = GameObject.Find("Canvas").transform.Find("talkScreen").GetComponent<Image>();
        initialized(); //대화 설정
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
            strCnt++;
            // '마우스 오른쪽 클릭'or '스페이스바'카운터
        }
        if(strCnt == talkCnt){ //대화 종류 후 씬 바꾸기
            SceneManager.LoadScene(sceneName);
        }
        showAll();

    }

    void showAll(){
        showText.gameObject.SetActive(true); //나타나기
        txt.gameObject.SetActive(true);
        talkname.gameObject.SetActive(true);
        if(strCnt < talkCnt){
            if(showCnt[strCnt] == 1){
            
                talkname.text = "베토벤";
            }
            else{
                talkname.text = "주인공";
            }
            txt.text = talks[strCnt];
        }
        
    }

    void initialized()
    {
        // 대화 내용 추가
        talks[0] = "어쩌구 저쩌구";                    
        talks[1] = "엥 진짜 베토벤..? 여긴 어디지? 내 옷은 또 왜이래";
        talks[2] = "으악!!";
        //talks[3] = "어이, 조심하라구 lady";

        // 캐릭터의 등장 순서
        showCnt[0] = 1;     // 베토벤
        showCnt[1] = 0;     // 주인공
        showCnt[2] = 0;     // 주인공
        //showCnt[3] = 1;     // 베토벤
        
    }
}

