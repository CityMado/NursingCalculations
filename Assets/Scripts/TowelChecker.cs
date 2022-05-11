using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowelChecker : MonoBehaviour
{
    public static TowelChecker singleton;
    public bool hasCleanedAmpulle = false;
    public bool hasCleanedTable = false;
    private void Awake()
    {
        singleton = this;
    }
}
