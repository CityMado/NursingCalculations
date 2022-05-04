using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowelScript : MonoBehaviour
{
    //not sure how much is going to come here but we will see.
public static TowelScript singleton;
public bool hasCleaned = false;
private void Awake()
{
    singleton = this;
}
private void Start()
{
    gameObject.SetActive(false);
}
 private void OnTriggerEnter(Collider other) {
        
        if(other.tag == "ampulle")
        {
            hasCleaned = true;
        }
    }
}
