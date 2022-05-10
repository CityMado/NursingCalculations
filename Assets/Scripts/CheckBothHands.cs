using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBothHands : MonoBehaviour
{
   public static CheckBothHands singleton; 
   public bool leftHandWashed = false;
   public bool rightHandWashed = false;

   private void Awake()
   {
       singleton = this;
   }
}
