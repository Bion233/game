using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 追踪 HP 追踪动画 死亡动画   挂在模型上
/// </summary>
public class Enemy : MonoBehaviour
{
    public float enemyHP=10;
    public float enemyMaxHP=10;
    public float enemySpeed=1;
    
   


    private Animator animator;
    private string enemyAnim= "IsPlay(death)";//动画的参数名称
    private bool isPlay=false;//动画是否播放
    private bool isTrigged;//是否碰撞
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
    /// 敌人死亡的时候执行
    /// </summary>
    private void Death()
    {
        
        Destroy(this.GetComponentInParent<Enemy>().gameObject);
    }
}
