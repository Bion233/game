using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏角色的控制 动画 攻击 Hp等
/// </summary>
public class PlayerController : MonoBehaviour
{
    public float speed=1;
    private  Animator animator;
    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }
    private void Update()
    {
        speed = GameManager.playerSpeed;
        animator.SetFloat("Horizontal",Input.GetAxis("Horizontal"));
     

        Vector3 horzontal = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0f);
        this.transform.position += horzontal*Time.deltaTime*speed;
    }
}
