using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmpulleScript : MonoBehaviour
{
    public MultipleObjectiveChecker multiple;
    public GameObject topPart;

    // Start is called before the first frame update

    private void OnTriggerExit(Collider other) {
        
        if(other.tag == "ampulle")
        {
            Debug.Log("separated");
            multiple.isBrokenAmpulle = true;
            topPart.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            topPart.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        if(other.tag == "GlucoseTop")
        {
            Debug.Log("separated");
            multiple.isBrokenGlucose = true;
            topPart.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            topPart.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
        
}

