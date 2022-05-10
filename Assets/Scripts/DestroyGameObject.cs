using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    public float waitTime = 5f;

    private void Update()
    {
        DestroyObjectDelayed();
    }
        void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, waitTime);
    }

}
