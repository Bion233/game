using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///��������������� ���� �����ݵĲ���
/// </summary>
public class Points : MonoBehaviour
{
    public GameObject PointFather;
    public GameObject point;



    /// <summary>
    /// �ڵ���������λ�� ����һ����
    /// </summary>
    /// <param name="enemy">���˵Ķ���</param>
    public void PointCreat(GameObject enemy)
    {
        GameManager.killedEnemys++;
        Instantiate(point,enemy.transform.position,default ,PointFather.transform);
    }
}
