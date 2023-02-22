using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    public List<GameObject> boxNoteList = new List<GameObject>();
    public GameObject player;


    [SerializeField] Transform Center = null; //중간 위치
    [SerializeField] RectTransform[] timingRect = null; //맞춤 단계
    Vector2[] timingBoxs = null;

    EffectManager theEffect;
    // Start is called before the first frame update
    void Start()
    {
        theEffect = FindObjectOfType<EffectManager>();
        timingBoxs = new Vector2[timingRect.Length];
        player = GameObject.FindWithTag("Player");
        for(int i = 0; i<timingRect.Length; i++){
            timingBoxs[i].Set(Center.localPosition.y - timingRect[i].rect.width/2, Center.localPosition.y + timingRect[i].rect.width/2);
        }
    }


    public void CheckTiming(){ //왼쪽 판정 체크
        for(int i = 0; i< boxNoteList.Count; i++){
            if(boxNoteList[i].GetComponent<note>().noteLperfect){
                boxNoteList[i].GetComponent<note>().HideNote();
                theEffect.NotePerfectEffect();
                boxNoteList.RemoveAt(i);
                Debug.Log("Hit perfect");
                player.GetComponent<PlayerController>().Score += 10;
                return;
            }
            if(boxNoteList[i].GetComponent<note>().noteLgood){
                boxNoteList[i].GetComponent<note>().HideNote();
                theEffect.NoteGoodEffect();
                boxNoteList.RemoveAt(i);
                Debug.Log("Hit good");
                player.GetComponent<PlayerController>().Score += 5;
                return;
            }
        }
        Debug.Log("Miss");
        theEffect.NoteMissEffect();
    }

    public void CheckTiming2(){ //오른쪽 판정 체크
        for(int i = 0; i< boxNoteList.Count; i++){
            if(boxNoteList[i].GetComponent<note>().noteRperfect){
                boxNoteList[i].GetComponent<note>().HideNote();
                theEffect.NotePerfectEffect();
                boxNoteList.RemoveAt(i);
                Debug.Log("Hit perfect");
                player.GetComponent<PlayerController>().Score += 10;
                return;
            }
            if(boxNoteList[i].GetComponent<note>().noteRgood){
                boxNoteList[i].GetComponent<note>().HideNote();
                theEffect.NoteGoodEffect();
                boxNoteList.RemoveAt(i);
                Debug.Log("Hit good");
                player.GetComponent<PlayerController>().Score += 5;
                return;
            }
        }
        Debug.Log("Miss");
        theEffect.NoteMissEffect();
    }
    public void CheckTiming3(){ //중앙 판정 체크
        for(int i = 0; i< boxNoteList.Count; i++){
            if(boxNoteList[i].GetComponent<note>().noteCperfect){
                boxNoteList[i].GetComponent<note>().HideNote();
                theEffect.NotePerfectEffect();
                boxNoteList.RemoveAt(i);
                Debug.Log("Hit perfect");
                player.GetComponent<PlayerController>().Score += 10;
                return;
            }
            if(boxNoteList[i].GetComponent<note>().noteCgood){
                boxNoteList[i].GetComponent<note>().HideNote();
                theEffect.NoteGoodEffect();
                boxNoteList.RemoveAt(i);
                Debug.Log("Hit good");
                player.GetComponent<PlayerController>().Score += 5;
                return;
            }
        }
        Debug.Log("Miss");
        theEffect.NoteMissEffect();
    }
}
