using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCGScene : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "NPCG1")//takes you to L2G
        {
            if (GameVariables.keyObj == 1)
            {
                
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(3);
                
            }
        }

        if (collider.gameObject.tag == "NPCG2")//takes you to L3G
        {
            
            if (GameVariables.keyObj == 1)
            {
                
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(6);
            }
        }
        if (collider.gameObject.tag == "NPCG3")//takes you to L3N
        {
            
            if (GameVariables.keyObj == 1)
            {
                
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(8);
            }
        }

        if (collider.gameObject.tag == "NPCG4")//takes you to GE
        {
            if (GameVariables.keyObj == 1)
            {
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(5);
                
            }
        }
        if (collider.gameObject.tag == "NPCG5")
        {
            if (GameVariables.keyObj == 1)
            {
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(9);
            }
        }

        if (collider.gameObject.tag == "NPCB1")
        {
            if (GameVariables.keyObj == 1)
            {
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(2);
            }
        }
        if (collider.gameObject.tag == "NPCB2")
        {
            if (GameVariables.keyObj == 1)
            {
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(5);
            }
        }
        if (collider.gameObject.tag == "NPCB3")
        {
            if (GameVariables.keyObj == 1)
            {
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(9);
            }
        }
        if (collider.gameObject.tag == "NPCB4")
        {
            if (GameVariables.keyObj == 1)
            {
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(4);
            }
        }
        if (collider.gameObject.tag == "NPCB5")
        {
            if (GameVariables.keyObj == 1)
            {
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(7);
            }
        }
        if (collider.gameObject.tag == "NPCN1")
        {
            if (GameVariables.keyObj == 1)
            {
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(8);
            }
        }
        if (collider.gameObject.tag == "NPCN2")
        {
            if (GameVariables.keyObj == 1)
            {
                transform.position = new Vector3(0, 0, 0);
                GameVariables.keyObj = 0;
                SceneManager.LoadScene(7);
            }
        }
        if (collider.gameObject.tag == "Chrono")
        {
            Destroy(GameObject.FindWithTag("Player"));
            SceneManager.LoadScene(0);
            GameVariables.keyObj = 0;
            
        }
    }    
}