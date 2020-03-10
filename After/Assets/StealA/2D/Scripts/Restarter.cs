using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        Vector3 originalPos;
        void Start()
        {
            originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
            //alternatively, just: originalPos = gameObject.transform.position;

        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "KillZone")
            {
                gameObject.transform.position = originalPos;
            }
        }
    }
}
