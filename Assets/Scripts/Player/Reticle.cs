using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///׼�� ���� ��׼�ǵĸ���
/// </summary>
public class Reticle : MonoBehaviour
{
    private Vector3 mouseWorldPos;//������������

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
