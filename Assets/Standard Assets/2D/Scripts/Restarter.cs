using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
		private IEnumerator OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
				yield return new WaitForSeconds(1);
                SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            }
        }
    }
}
