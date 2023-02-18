using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoteManager : MonoBehaviour
{
    public int bpm = 0; //1분당 비트 수
    public int checkn = 0; //노드 개수 체크

    double currentTime = 0d;
    public string sceneName; //다음씬이름
    //엘리제를 위하여

    int [] Lnotelist = {1,1,1,0,1,0,1,1,1,1,0,0,1,0,0,1,0,1,0,1,1,1,1,0,0,0,1,1,1,0,1,0,1,1,0,1,1,0,0,1,0,0,1,0,1,0,1,1,1,1,0,0,0,1,0,0,0,1,0,0};
    int [] Rnotelist = {0,1,0,1,0,1,0,0,1,0,1,1,0,1,1,0,1,0,1,0,0,1,0,0,1,0,0,0,0,1,0,1,0,0,1,1,0,0,1,0,0,1,0,1,0,1,0,0,1,0,0,1,0,0,0,1,0,0,0,1};

    [SerializeField] Transform tfNoteAL = null;
    [SerializeField] GameObject goNote = null;

    [SerializeField] Transform tfNoteAR = null;
    [SerializeField] GameObject goNote2 = null;
    
    TimingManager theTimingManager;

    // Update is called once per frame

    void Awake(){
        theTimingManager = GetComponent<TimingManager>();
    }
    void Update() //노드생성
    {
        currentTime += Time.deltaTime;

        if( currentTime >= 60d/bpm && checkn <60){
            if(Lnotelist[checkn] == 1){
                GameObject L_node = Instantiate(goNote, tfNoteAL.position, Quaternion.identity);
                L_node.transform.SetParent(this.transform);
                theTimingManager.boxNoteList.Add(L_node); //노드리스트에 넣기
            }
            if(Rnotelist[checkn] == 1){
                GameObject R_node = Instantiate(goNote2, tfNoteAR.position, Quaternion.identity);
                R_node.transform.SetParent(this.transform);
                theTimingManager.boxNoteList.Add(R_node); //노드리스트에 넣기
            }
            //L_node.transform.localScale = new Vector3(1,1,0);
            currentTime -= 60d/bpm;
            checkn++;
        }
        if(checkn >= 60 && theTimingManager.boxNoteList.Count == 0){
            SceneManager.LoadScene(sceneName);
        }
    }

    private void OnTriggerExit2D(Collider2D collision){ //끝에서 사라지게 하기
        if(collision.CompareTag("Note")){
            Destroy(collision.gameObject);
            theTimingManager.boxNoteList.Remove(collision.gameObject);
        }
    }
}
