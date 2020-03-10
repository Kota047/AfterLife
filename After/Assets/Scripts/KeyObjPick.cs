using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyObjPick : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "PickUp")
        {
           
            GameVariables.keyObj += 1;
            Destroy(collider.gameObject);
        }
    }
}
