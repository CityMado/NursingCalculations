using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeScript : MonoBehaviour
{
    public MultipleObjectiveChecker multiple;

  private void OnTriggerEnter(Collider other)
  {
      if(other.tag == "ampulle")
      {
          multiple.drugTaken = true;
      }
      if(other.tag == "CorrectSyringe")
      {
          multiple.drugTransfered = true;
      }
  }
}
