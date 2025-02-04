using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordButtonManager : MonoBehaviour
{
    public DemoRecord recordManager;

    void OnTriggerEnter(Collider other)
    {
        recordManager.OnClickRecord();
    }
}
