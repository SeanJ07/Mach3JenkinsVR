using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchRotation2 : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;

    void Update()
    {
        arrow1 = GameObject.Find("Pedestal");
        arrow2.transform.rotation = arrow1.transform.rotation;
    }
}
