using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///子弹的运动 给到方向和速度  销毁的时间 及销毁的动画  和子弹的速度 伤害
/// </summary>
public class PlayerBullets : MonoBehaviour
{
    public float bulletSpeed=GameManager.bulltSpeed;//子弹速度
    
    
    
   
    private Vector3 dirBullt;//子弹的方向
    private GameObject Player;
    private bool isBoom;
    private Animator bulletAnim;
    private GameObject bulltAudio;
    


    private void Start()
    {
        
        bulletAnim = GetComponent<Animator>();
        Player =GameObject.FindWithTag("Player");
        dirBullt = Player.GetComponent<PlayerAttack>().retpos - Player.transform.position;
        bulltAudio = GameObject.Find("FireBoom");
    }
    private void Update()
    {
        
        bulletAnim.SetBool("IsBoom",isBoom);

        this.transform.Translate(dirBullt.normalized*bulletSpeed*Time.deltaTime);
        Invoke("DestoryBoom",3f);
    }

    //private void OnMouseDown() //记录一下这一帧 准星的坐标和玩家的坐标
    //{
    //    retpos = reticleTrans.position;
    //    playerpos = playerTrans.position;
    //    dirBullt = retpos - playerpos;
    //}

    private void DestoryBoom()
    {
        Destroy(this.gameObject);
        Debug.Log("销毁子弹");
    }
    private void OnTriggerEnter2D(Collider2D collision)//触发
    {
        if (collision.gameObject.tag=="Enemy")
        {
            bulltAudio.GetComponent<AudioSource>().Play();
            bulletSpeed = 0;
            isBoom = true;
            Debug.Log("与敌人碰撞");
            Invoke("DestoryBoom", 0.5f); 
            
            
        }
        
        
    }

}
