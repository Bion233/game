using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///生成敌人 决定敌人的位置品种血量等
/// </summary>
public class CreateEnemy : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] Enemy;
    public float timeCreate;//创造每个敌人的时间间隔
    public float timeUpdateSpecies=60;//更改品种的时间间隔
    public float createEnemyDis = 15;

    private float i = 0;

    private void Update()
    {
        EnemyKinds(Enemy,timeUpdateSpecies);
    }

    #region 想法很好 但是计算量太大
    /*
    /// <summary>
    /// 生成敌人的函数让敌人的坐标围绕着玩家组成一个园  通过向量减法的模场做判断
    /// </summary>
    /// <param name="minObg">中心的对象</param>
    /// <param name="r">圆半径</param>
    /// <param name="inObg">生成的对象</param>
    private void InsEnemy(GameObject minObg,GameObject inObg,float max,float min)
    {
        float x=Random.Range(-1000f,1000f);
        float y=Random.Range(-1000f, 1000f);

        Vector3 vector3 = new Vector3(x,y,0);
        if ((Player.transform.position-vector3).magnitude>=min||( Player.transform.position - vector3).magnitude<=max)//最重要的一句话
        {
            GameObject.Instantiate(inObg,vector3,default,this.transform);
            Debug.Log("生成敌人");
        }
    }
    */
    #endregion

    /// <summary>
    /// 在目标对象的上下左右等八个点生成实例对象
    /// </summary>
    /// <param name="tarObg">目标对象</param>
    /// <param name="instOng">实例对象</param>
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
    /// 按照一定速度创造敌人
    /// </summary>
    /// <param name="time">创造敌人时间间隔</param>
    /// <param name="enemy">敌人的种类</param>
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
    /// 生成敌人的物种 多久改变一次
    /// </summary>
    /// <param name="enemy">种类的数组</param>
    /// <param name="time">时间间隔</param>
    private void EnemyKinds(GameObject[] enemy ,float time)
    {
        float gameTime = Time.time;
        if (gameTime <= time)
        {
            CreatCtrol(timeCreate, enemy[0]);
            Debug.Log("一倍速创造敌人");

        }
        if (gameTime > time && gameTime <=time * 2)
        {
            CreatCtrol(timeCreate/2, enemy[0]);
            Debug.Log("二倍速创造敌人");
        }
        if (gameTime>2*time&&gameTime<=3*time)
        {
            CreatCtrol(timeCreate, enemy[0]);
            CreatCtrol(timeCreate, enemy[1]);
            Debug.Log("一倍速创造敌人 ，同时创造新的敌人");
        }
    }

}
