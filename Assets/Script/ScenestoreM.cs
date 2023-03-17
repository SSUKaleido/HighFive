using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenestoreM : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        ScoreManager.MozartScene = scene.name;
    }
}
