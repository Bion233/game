using UnityEngine;

/// <summary>
///控制点的移动 和消失
/// </summary>
public class PointAi : MonoBehaviour
{
    private float speed=13f;
    private GameObject Player;
    private GameObject Audio;
    //private bool isTouch;//判断是否获得能量

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

    private void MovePoint()//能量点移动的函数
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
            
            //执行销毁函数
        }
        
    }
    
}
