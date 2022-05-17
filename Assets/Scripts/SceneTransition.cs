using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public Animator transition;
    private float waitTimer = 0.5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Hit ME");
            StartCoroutine(delaySceneChange());
            
        }
    }

    IEnumerator delaySceneChange()
    {
        // play animation
       // transition.SetTrigger("Start");
        //wait for it to end
        yield return new WaitForSeconds(waitTimer);
        //load Scene
        SceneManager.LoadScene("medicationrroom 1");
    }
}
