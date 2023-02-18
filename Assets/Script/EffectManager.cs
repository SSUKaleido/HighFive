using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    [SerializeField] Animator noteperfectAnimator = null;
    [SerializeField] Animator notegoodAnimator = null;
    [SerializeField] Animator notemissAnimator = null;

    string perpect = "perfectp";
    string good = "goodp";
    string miss = "missp";
    // Start is called before the first frame update
    
    public void NotePerfectEffect(){
        noteperfectAnimator.SetTrigger(perpect);
    }
    public void NoteGoodEffect(){
        notegoodAnimator.SetTrigger(good);
    }
    public void NoteMissEffect(){
        notemissAnimator.SetTrigger(miss);
    }
}
