using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///���ɵ��� �������˵�λ��Ʒ��Ѫ����
/// </summary>
public class CreateEnemy : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] Enemy;
    public float timeCreate;//����ÿ�����˵�ʱ����
    public float timeUpdateSpecies=60;//����Ʒ�ֵ�ʱ����
    public float createEnemyDis = 15;

    private float i = 0;

    private void Update()
    {
        EnemyKinds(Enemy,timeUpdateSpecies);
    }

    #region �뷨�ܺ� ���Ǽ�����̫��
    /*
    /// <summary>
    /// ���ɵ��˵ĺ����õ��˵�����Χ����������һ��԰  ͨ������������ģ�����ж�
    /// </summary>
    /// <param name="minObg">���ĵĶ���</param>
    /// <param name="r">Բ�뾶</param>
    /// <param name="inObg">���ɵĶ���</param>
    private void InsEnemy(GameObject minObg,GameObject inObg,float max,float min)
    {
        float x=Random.Range(-1000f,1000f);
        float y=Random.Range(-1000f, 1000f);

        Vector3 vector3 = new Vector3(x,y,0);
        if ((Player.transform.position-vector3).magnitude>=min||( Player.transform.position - vector3).magnitude<=max)//����Ҫ��һ�仰
        {
            GameObject.Instantiate(inObg,vector3,default,this.transform);
            Debug.Log("���ɵ���");
        }
    }
    */
    #endregion

    /// <summary>
    /// ��Ŀ�������������ҵȰ˸�������ʵ������
    /// </summary>
    /// <param name="tarObg">Ŀ�����</param>
    /// <param name="instOng">ʵ������</param>
    private void InstObg(GameObject tarObg,GameObject instOng)
    {
        int randomNum=Random.Range(1,8);

        switch (randomNum)
        {
            case 1:
                Instantiate(instOng,new Vector3(tarObg.transform.position.x- createEnemyDis, tarObg.transform.position.y,tarObg.transform.position.z),default,this.transform);
            break;
            case 2:
                Instantiate(instOng, new Vector3(tarObg.transform.position.x - createEnemyDis, tarObg.transform.position.y+ createEnemyDis, tarObg.transform.position.z), default, this.transform);
                break;
            case 3:
                Instantiate(instOng, new Vector3(tarObg.transform.position.x - createEnemyDis, tarObg.transform.position.y- createEnemyDis, tarObg.transform.position.z), default, this.transform);
                break;
            case 4:
                Instantiate(instOng, new Vector3(tarObg.transform.position.x + createEnemyDis, tarObg.transform.position.y, tarObg.transform.position.z), default, this.transform);
                break;
            case 5:
                Instantiate(instOng, new Vector3(tarObg.transform.position.x + createEnemyDis, tarObg.transform.position.y+ createEnemyDis, tarObg.transform.position.z), default, this.transform);
                break;
            case 6:
                Instantiate(instOng, new Vector3(tarObg.transform.position.x + createEnemyDis, tarObg.transform.position.y- createEnemyDis, tarObg.transform.position.z), default, this.transform);
                break;
            case 71:
                Instantiate(instOng, new Vector3(tarObg.transform.position.x , tarObg.transform.position.y- createEnemyDis, tarObg.transform.position.z), default, this.transform);
                break;
            case 8:
                Instantiate(instOng, new Vector3(tarObg.transform.position.x , tarObg.transform.position.y+ createEnemyDis, tarObg.transform.position.z), default, this.transform);
                break;
            
        }
    }



    /// <summary>
    /// ����һ���ٶȴ������
    /// </summary>
    /// <param name="time">�������ʱ����</param>
    /// <param name="enemy">���˵�����</param>
    private void CreatCtrol(float time, GameObject enemy)
    {

        i += Time.deltaTime;

        if (i >= time)
        {
            InstObg(Player, enemy);
            i = 0;
        }
    }

    /// <summary>
    /// ���ɵ��˵����� ��øı�һ��
    /// </summary>
    /// <param name="enemy">���������</param>
    /// <param name="time">ʱ����</param>
    private void EnemyKinds(GameObject[] enemy ,float time)
    {
        float gameTime = Time.time;
        if (gameTime <= time)
        {
            CreatCtrol(timeCreate, enemy[0]);
            Debug.Log("һ���ٴ������");

        }
        if (gameTime > time && gameTime <=time * 2)
        {
            CreatCtrol(timeCreate/2, enemy[0]);
            Debug.Log("�����ٴ������");
        }
        if (gameTime>2*time&&gameTime<=3*time)
        {
            CreatCtrol(timeCreate, enemy[0]);
            CreatCtrol(timeCreate, enemy[1]);
            Debug.Log("һ���ٴ������ ��ͬʱ�����µĵ���");
        }
    }

}
