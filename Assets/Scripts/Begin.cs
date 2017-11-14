using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Begin : MonoBehaviour {
    void NextLevel()
    {
        //
        SceneManager.LoadScene("Level1");
    } 
}
