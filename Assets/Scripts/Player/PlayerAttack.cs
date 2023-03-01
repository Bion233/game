using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///玩家的攻击 音效  生成子弹
/// </summary>
public class PlayerAttack : MonoBehaviour
{
    public GameObject bullet;
    public Transform reticleTrans;//记录上一帧准星所在位置
    public GameObject BulletsParent;
    public GameObject AttackAudio;
    [HideInInspector]
    public  Vector3 retpos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AttackAudio.GetComponent<AudioSource>().Play();
            retpos = reticleTrans.position;
            Object.Instantiate(bullet,this.transform.position,default , BulletsParent.transform);
        }
    }

}
