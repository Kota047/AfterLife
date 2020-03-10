using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCBScene : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "NPCB")
        {
            if (GameVariables.keyObj == 1)
            {
               
                SceneManager.LoadScene(2);
            }
        }

    }

}