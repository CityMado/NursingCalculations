using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeScript : MonoBehaviour
{
    public static SyringeScript singleton;
    public bool drugTaken = false;
    public bool drugTransfered = false;
    private void Awake()
    {
        singleton = this;
    }
  private void OnTriggerEnter(Collider other)
  {
      if(other.tag == "ampulle")
      {
          drugTaken = true;
      }
      if(other.tag == "CorrectSyringe")
      {
          drugTransfered = true;
      }
  }
}
