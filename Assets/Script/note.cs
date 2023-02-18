using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{
    public float noteSpeed = 200; //내려오는 속도
    public bool noteRperfect = false;
    public bool noteLperfect = false;
    public bool noteRgood = false;
    public bool noteLgood = false;

    UnityEngine.UI.Image notelmage;

    void Start(){
        //notelmage = GetComponent<UnityEngine.UI.Image>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.down * noteSpeed * Time.deltaTime; //내려오게 하기
    }

    public void HideNote(){
            gameObject.SetActive(false); //안보이게 하기
    }    
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Rper")){
            noteRperfect = true;
        }
        if(collision.CompareTag("Lper")){
            noteLperfect = true;
        }
        if(collision.CompareTag("Rgood")){
            noteRgood = true;
        }
        if(collision.CompareTag("Lgood")){
            noteLgood = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
        if(collision.CompareTag("Rper")){
            noteRperfect = false;
        }
        if(collision.CompareTag("Lper")){
            noteLperfect = false;
        }
        if(collision.CompareTag("Rgood")){
            noteRgood = false;
        }
        if(collision.CompareTag("Lgood")){
            noteLgood = false;
        }
    }
}
