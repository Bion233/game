using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ׷�� HP ׷�ٶ��� ��������   ����ģ����
/// </summary>
public class Enemy : MonoBehaviour
{
    public float enemyHP=10;
    public float enemyMaxHP=10;
    public float enemySpeed=1;
    
   


    private Animator animator;
    private string enemyAnim= "IsPlay(death)";//�����Ĳ�������
    private bool isPlay=false;//�����Ƿ񲥷�
    private bool isTrigged;//�Ƿ���ײ
    private GameObject points;
   
  


    private void Start()
    {
        enemyHP = enemyMaxHP;
        animator = GetComponent<Animator>();
        points = GameObject.Find("Points");
        
    }

    private void Update()
    {
        animator.SetBool(enemyAnim,isPlay);
        if (enemyHP <= 0)
        {
            enemySpeed = 0;
            isPlay=true;
            Invoke("Death", 0.5f);
            

        }
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            enemyHP -= GameManager.playerDamage;
        }
        
        if (enemyHP==0)
        {
            points.GetComponent<Points>().PointCreat(this.gameObject);

        }
    }

    /// <summary>
    /// ����������ʱ��ִ��
    /// </summary>
    private void Death()
    {
        
        Destroy(this.GetComponentInParent<Enemy>().gameObject);
    }
}
