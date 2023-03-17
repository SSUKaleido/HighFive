using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreReset : MonoBehaviour
{
    public void Reset(){
        ScoreManager.BeetS = 0;
        ScoreManager.MozartS = 0;
        ScoreManager.BeetScene = "Beet_1";
        ScoreManager.MozartScene = "Mozart_1";
    }
}
