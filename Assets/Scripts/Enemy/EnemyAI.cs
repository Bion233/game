using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///敌人AI：追踪玩家  血量为0时停止追踪   挂在模型的父物体上
/// </summary>
public class EnemyAI : MonoBehaviour
{
    private GameObject player;
    private float speed;
    private float hp;
   // private Transform childTrans;
    private void Start()
    {
        speed=this.GetComponentInChildren<Enemy>().enemySpeed;
        hp =this.GetComponentInChildren<Enemy>().enemyHP;
        //childTrans = this.GetComponentInChildren<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
    }



    private void Update()
    {
        EnemyMove();
    }

    private void EnemyMove()
    {
        if (hp <= 0)
        {
            speed = 0;
            return;
        }
        hp = this.GetComponentInChildren<Enemy>().enemyHP;
        Vector3 vector3 = player.transform.position - transform.position;
        this.transform.Translate(vector3.normalized * speed * Time.deltaTime);
       
    }
}
