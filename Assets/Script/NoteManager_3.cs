using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NoteManager_3 : MonoBehaviour
{
    public int bpm = 0; //1분당 비트 수
    public int checkn = 0; //노드 개수 체크

    double currentTime = 0d;
    public string sceneName; //다음씬이름
    //엘리제를 위하여

    int [] Lnotelist = {1,1,0,1,1,0,1,0,1,1,1,0,1,0,0,1,0,1,0,1,1,1,1,0,0,0,0,1,1,0,0,0,0,1,0,1,1,0,0,1,0,0,1,0,1,0,1,1,1,1,0,0,0,1,0,0,0,1,0,0};
    int [] Rnotelist = {1,0,1,0,1,0,0,1,0,1,0,1,0,1,0,0,1,0,1,0,0,1,0,0,1,0,1,0,0,0,1,1,0,0,1,1,0,0,1,0,0,1,0,1,0,1,0,0,1,0,0,1,0,0,0,1,0,0,0,1};
    int [] Cnotelist = {0,0,0,0,1,1,0,1,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,1,0,0,0,1,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,1,0,1,0,1,0,1,0,1,0};

    [SerializeField] Transform tfNoteAL = null;
    [SerializeField] GameObject goNote = null;

    [SerializeField] Transform tfNoteAR = null;
    [SerializeField] GameObject goNote2 = null;

    [SerializeField] Transform tfNoteAC = null;
    [SerializeField] GameObject goNote3 = null;
    
    TimingManager theTimingManager;
    public GameObject player;
    public GameObject result;
    public Text resultt;
    public int composer;

    // Update is called once per frame

    void Awake(){
        theTimingManager = GetComponent<TimingManager>();
        player = GameObject.FindWithTag("Player");
        result = GameObject.Find("Canvas").transform.Find("result").gameObject;
        resultt = GameObject.Find("Canvas").transform.Find("resultt").GetComponent<Text>();
    }
    void Update() //노드생성
    {
        currentTime += Time.deltaTime;

        if( currentTime >= 60d/bpm && checkn <60){
            if(Lnotelist[checkn] == 1){//왼쪽 노트 생성
                GameObject L_node = Instantiate(goNote, tfNoteAL.position, Quaternion.identity);
                L_node.transform.SetParent(this.transform);
                theTimingManager.boxNoteList.Add(L_node); //노드리스트에 넣기
            }
            if(Rnotelist[checkn] == 1){ //오른쪽 노트 생성
                GameObject R_node = Instantiate(goNote2, tfNoteAR.position, Quaternion.identity);
                R_node.transform.SetParent(this.transform);
                theTimingManager.boxNoteList.Add(R_node); //노드리스트에 넣기
            }
            if(Cnotelist[checkn] == 1){//가운데 노트 생성
                GameObject C_node = Instantiate(goNote3, tfNoteAC.position, Quaternion.identity);
                C_node.transform.SetParent(this.transform);
                C_node.transform.localScale = new Vector3(40,40,40);
                theTimingManager.boxNoteList.Add(C_node); //노드리스트에 넣기
            }
            //L_node.transform.localScale = new Vector3(1,1,0);
            currentTime -= 60d/bpm;
            checkn++;
        }
        if(checkn >= 60 && theTimingManager.boxNoteList.Count == 0){
            int Sc = player.GetComponent<PlayerController>().Score;
            if(Sc > 500){
                resultt.text = "perfect - 완벽해! 당신은 나의 뮤즈야";
                
            }
            else if(Sc >100){
                resultt.text = "good - 당신이 점점 마음에 들어";
            }
            else{
                resultt.text = "bad - 조금 실망인걸 lady";

            }
            
            
            result.SetActive(true);
            resultt.gameObject.SetActive(true);
            StartCoroutine(Scenem());

        }
    }

    private void OnTriggerExit2D(Collider2D collision){ //끝에서 사라지게 하기
        if(collision.CompareTag("Note")){
            Destroy(collision.gameObject);
            theTimingManager.boxNoteList.Remove(collision.gameObject);
        }
    }

    IEnumerator Scenem()
{
	yield return new WaitForSeconds( 1.0f );
    if(ScoreManager.BeetS > 7){
        SceneManager.LoadScene("Beet_4H");
    }
    else if(ScoreManager.BeetS > 4){
        SceneManager.LoadScene("Beet_4N");
    }
    else{
        SceneManager.LoadScene("Beet_4B");
    }
    
}
}
