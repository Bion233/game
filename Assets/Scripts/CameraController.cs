using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///
/// </summary>
public class CameraController : MonoBehaviour
{
    public Transform minTrans;
    private void Update()
    {
        this.transform.position = minTrans.position+new Vector3(0,0,-10f);
    }
}
