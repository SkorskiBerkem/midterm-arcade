using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchSnake : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(5);

     
    }
   void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
    }
}
