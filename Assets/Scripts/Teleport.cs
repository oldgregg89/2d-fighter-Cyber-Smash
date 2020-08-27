using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Teleport : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D Collider)
    {
        if (Collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(6);
        }
    }
}
