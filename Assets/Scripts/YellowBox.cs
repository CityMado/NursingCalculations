using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBox : MonoBehaviour
{
    public static YellowBox singleton;
    public bool ampulleDestroyed = false;
    // Start is called before the first frame update
    private void Awake()
    {
        singleton = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ampulle")
        {
            ampulleDestroyed = true;
            Destroy(other.gameObject);
        }  
    }
}
