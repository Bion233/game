using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///��ҵĹ��� ��Ч  �����ӵ�
/// </summary>
public class PlayerAttack : MonoBehaviour
{
    public GameObject bullet;
    public Transform reticleTrans;//��¼��һ֡׼������λ��
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
