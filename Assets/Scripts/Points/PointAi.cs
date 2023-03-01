using UnityEngine;

/// <summary>
///���Ƶ���ƶ� ����ʧ
/// </summary>
public class PointAi : MonoBehaviour
{
    private float speed=13f;
    private GameObject Player;
    private GameObject Audio;
    //private bool isTouch;//�ж��Ƿ�������

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Audio = GameObject.Find("GetEnergy");
    }

    private void Update()
    {
        if (Vector3.Distance(Player.transform.position, this.transform.position) <= GameManager.pickUpRange)
        {
            MovePoint();
        }
    }

    private void MovePoint()//�������ƶ��ĺ���
    {
        Vector3 pos = Player.transform.position - this.transform.position;
        this.transform.Translate(pos.normalized * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
            GameManager.pointCount++;
            Audio.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
            Debug.Log("++");
            
            //ִ�����ٺ���
        }
        
    }
    
}
