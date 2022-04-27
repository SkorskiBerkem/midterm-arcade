using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);

     
    }
   void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
    }
}
