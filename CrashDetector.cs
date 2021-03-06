using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    float delay = 1f;
    [SerializeField] ParticleSystem crashEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            Invoke("ReloadScene", delay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
