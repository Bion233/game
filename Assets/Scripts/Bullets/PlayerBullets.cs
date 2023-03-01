using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///�ӵ����˶� ����������ٶ�  ���ٵ�ʱ�� �����ٵĶ���  ���ӵ����ٶ� �˺�
/// </summary>
public class PlayerBullets : MonoBehaviour
{
    public float bulletSpeed=GameManager.bulltSpeed;//�ӵ��ٶ�
    
    
    
   
    private Vector3 dirBullt;//�ӵ��ķ���
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

    //private void OnMouseDown() //��¼һ����һ֡ ׼�ǵ��������ҵ�����
    //{
    //    retpos = reticleTrans.position;
    //    playerpos = playerTrans.position;
    //    dirBullt = retpos - playerpos;
    //}

    private void DestoryBoom()
    {
        Destroy(this.gameObject);
        Debug.Log("�����ӵ�");
    }
    private void OnTriggerEnter2D(Collider2D collision)//����
    {
        if (collision.gameObject.tag=="Enemy")
        {
            bulltAudio.GetComponent<AudioSource>().Play();
            bulletSpeed = 0;
            isBoom = true;
            Debug.Log("�������ײ");
            Invoke("DestoryBoom", 0.5f); 
            
            
        }
        
        
    }

}
