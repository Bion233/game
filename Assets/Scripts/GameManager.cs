using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class GameManager : MonoBehaviour
{
    public static float shootingRange;//
    public static float shootingSpeed;//
    public static float bulltSpeed=10; //�ӵ����ƶ��ٶ�

    public static float pickUpRange=4f;//ʰȡ��������뷶Χ
    public static float pointCount=0;//ʰȡ����������

    public static float killedEnemys=0;

    public static float playerSpeed=3;//����ƶ����ٶ�
    public static float playerHP = 6;//��ҵ�Ѫ��
    public static int playerGrade = 0;
    public static int playerDamage = 1;//����˺�

    public static float scrollBarValue = 0;//�ȼ���ʾ�Ľ�����


    

    private void Update()
    {
        Debug.Log("����"+pointCount);
        playerGrade = UpGrade(pointCount);//�ȼ�
        scrollBarValue = ScrollBarShow(UpGrade(pointCount),pointCount);//��ʾ������
        
    }
    /// <summary>
    /// ���������������صȼ� 
    /// </summary>
    /// <param name="pointNum">����</param>
    /// <returns>�ȼ�</returns>
    private int UpGrade(float pointNum)
    { 
        int level=0;
        if (pointNum >= 8&&pointNum<24)
            level = 1;
        else if (pointNum >= 24 && pointNum < 56)
            level = 2;
        else if (pointNum >= 56 && pointNum < 120)
            level = 3;
        else if (pointNum >= 120 && pointNum < 248)
            level = 4;
        else if (pointNum >= 248)
            level = 5;
        return level;
        
    }

    /// <summary>
    /// ���ݵȼ��͵��� ���� ��������value
    /// </summary>
    /// <param name="grade">�ȼ�</param>
    /// <param name="pointNum">����</param>
    /// <returns>��������value</returns>
    private float ScrollBarShow(int grade ,float pointNum)
    {
        float precent=0;
        //float deltaPrecent;
        switch (grade)
        {
            case 0:
                {
                    precent = 0.125f * pointNum;
                   
                }
                break;
            case 1:
                {
                    precent = 0.0625f * (pointNum-8);
                    
                }

                break;
            case 2:
                {

                    precent = 0.03125f * (pointNum-24);
                    
                }

                break;
            case 3:
                {

                    precent = 0.015625f * (pointNum-56);
                    
                }

                break;
            case 4:
                {

                    precent = 0.0078125f * (pointNum-120);
                   
                }

                break;
            case 5:
                {

                    precent = 0.0078125f*(pointNum-248);


                }

                break;
               

        }
 
        return precent;
    }

    #region 
    /// <summary>
    /// 
    /// </summary>
    public static void MasterSword()
    {
        if (playerGrade == 1)
        {
            playerDamage = 2;
        }
        if (playerGrade == 2)
        {
            playerDamage = 4;
        }
        
        Debug.Log("ѡ���ʦ֮��");

    }


    /// <summary>
    /// 
    /// </summary>
    public static void DoranShield()
    {

        Debug.Log("ѡ���˶�����");
    }

    /// <summary>
    /// ˪֮���˵ļ���Ч��
    /// </summary>
    public static void Frostmourne()
    {
        Debug.Log("ѡ����˪֮����");
    }

    #endregion




}
