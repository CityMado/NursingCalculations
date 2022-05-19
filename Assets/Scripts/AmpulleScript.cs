using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmpulleScript : MonoBehaviour
{
    public GameObject topPart;

    // Start is called before the first frame update

    private void OnTriggerExit(Collider other) {
        
        if(other.tag == "ampulle")
        {
            Debug.Log("separated");
            MultipleObjectiveChecker.singleton.isBrokenAmpulle = true;
            topPart.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            topPart.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
        if(other.tag == "GlucoseTop")
        {
            Debug.Log("separated");
            MultipleObjectiveChecker.singleton.isBrokenGlucose = true;
            topPart.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            topPart.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
        
}

