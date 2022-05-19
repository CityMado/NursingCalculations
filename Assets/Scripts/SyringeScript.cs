using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeScript : MonoBehaviour
{

  private void OnTriggerEnter(Collider other)
  {
      if(other.tag == "ampulle")
      {
          MultipleObjectiveChecker.singleton.drugTaken = true;
      }
      if(other.tag == "CorrectSyringe")
      {
          MultipleObjectiveChecker.singleton.drugTransfered = true;
      }
  }
}
