using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///准星 跟随 和准星的更换
/// </summary>
public class Reticle : MonoBehaviour
{
    private Vector3 mouseWorldPos;//鼠标的世界坐标

    private void Start()
    {
        Cursor.visible = false;
    }
    private void Update()
    {
        mouseWorldPos =Input.mousePosition;
        this.transform.position = Camera.main.ScreenToWorldPoint(mouseWorldPos+new Vector3(0f,0f,10f));
        
    }
}
