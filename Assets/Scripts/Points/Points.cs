using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///控制能量点的生成 销毁 和数据的补给
/// </summary>
public class Points : MonoBehaviour
{
    public GameObject PointFather;
    public GameObject point;



    /// <summary>
    /// 在敌人死亡的位置 生成一个点
    /// </summary>
    /// <param name="enemy">敌人的对象</param>
    public void PointCreat(GameObject enemy)
    {
        GameManager.killedEnemys++;
        Instantiate(point,enemy.transform.position,default ,PointFather.transform);
    }
}
