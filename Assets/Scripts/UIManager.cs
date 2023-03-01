using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
///
/// </summary>
public class UIManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject outMeau;
    public GameObject isQute;
    public GameObject isExit;
    public GameObject scrollbar;
    public GameObject gradeText;
    public GameObject killText;
    public GameObject Skills;
    public GameObject Step01;
    public GameObject Step02;
    public GameObject Step03;
    public GameObject Step04;
    public GameObject Step05;



    
    public Button Yes;//�Ƿ��˳���Ϸ��button
    public Button No;
   
    

    private bool isEsc=true;
    private bool isPlay=true;
    private bool isOut=true;//���ڽ���Esc�����˵��Ĺ���
    private bool isSkillOut=true;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        scrollbar.GetComponent<Scrollbar>().size = GameManager.scrollBarValue;
        EscOut();//�����˵�
        SkillsOut();//�������Զ�����
        SkillsClose();
        gradeText.GetComponent<Text>().text = "Level:" + GameManager.playerGrade;
        killText.GetComponent<Text>().text = "KillCount:" + GameManager.killedEnemys;
    }

    /// <summary>
    /// �����˵�
    /// </summary>
    private void EscOut()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&isOut)
        {
            
            outMeau.SetActive(isEsc);
            if (isEsc)
            {
                Time.timeScale = 0;
                Player.GetComponent<PlayerAttack>().enabled = false;
            }
            else 
            {
                Time.timeScale = 1;
                Player.GetComponent<PlayerAttack>().enabled = true;
            }
            isEsc = !isEsc;
            
        }
    }
    #region �˳���Ϸ
    /// <summary>
    /// ѡ���Ƿ��˳���Ϸ
    /// </summary>
    public void OutGame()
    {
        outMeau.SetActive(false);
        isQute.SetActive(true);
        isOut = false;
        Yes.onClick.AddListener(YesButton);
        No.onClick.AddListener(NoButton);
        //if (Input.GetButtonDown("Yes"))
        //{
        //    Application.Quit();
        //}
        //if (Input.GetButtonDown("No"))
        //{
        //    outMeau.SetActive(true);
        //}

    }
    private void YesButton()
    {
        Application.Quit();
    }
    private void NoButton()
    {
        isOut = true;
        isQute.SetActive(false);
        outMeau.SetActive(true);
    }
    #endregion

    /// <summary>
    /// ������Ϸ
    /// </summary>
    public void PlayerGame()
    {
        outMeau.SetActive(false);
        Time.timeScale = 1;
        Player.GetComponent<PlayerAttack>().enabled = true;
    }

    /// <summary>
    /// ��ͣ����
    /// </summary>
    public void TurnofMusic()
    {
        
        if (isPlay)
        {
            Player.GetComponent<AudioSource>().Pause();
        }
        else
        {
            Player.GetComponent<AudioSource>().Play();
        }
        isPlay = !isPlay;
    }



    /// <summary>
    /// ��ת����ʼҳ��
    /// </summary>
    public void ExitToMeau()
    {
        SceneManager.LoadScene(0);
    }


    /// <summary>
    /// ��������ȼ��Զ�����
    /// </summary>
    private void SkillsOut()
    {
        if (GameManager.pointCount==8)
        {
            
            if(isSkillOut)
                Time.timeScale = 0;
            Skills.SetActive(isSkillOut);
            Step01.SetActive(isSkillOut);
            Cursor.visible = true;

        }
        if (GameManager.pointCount == 24)
        {

            if (isSkillOut)
                Time.timeScale = 0;
            Skills.SetActive(isSkillOut);
            Step02.SetActive(isSkillOut);
            Cursor.visible = true;
        }
        if (GameManager.pointCount == 56)
        {

            if (isSkillOut)
                Time.timeScale = 0;
            Skills.SetActive(isSkillOut);
            Step03.SetActive(isSkillOut);
            Cursor.visible = true;
        }
        if (GameManager.pointCount == 120)
        {
            if (isSkillOut)
                Time.timeScale = 0;
            Skills.SetActive(isSkillOut);
            Step04.SetActive(isSkillOut);
            Cursor.visible = true;
        }
        if (GameManager.pointCount == 248)
        {
            if (isSkillOut)
                Time.timeScale = 0;
            Skills.SetActive(isSkillOut);
            Step05.SetActive(isSkillOut);
            Cursor.visible = true;
        }

    }
    /// <summary>
    /// ��ת���ܵ������ж�
    /// </summary>
    private void SkillsClose()
    {
        if (GameManager.pointCount == 9|| GameManager.pointCount == 25|| GameManager.pointCount == 58|| GameManager.pointCount == 121|| GameManager.pointCount == 249)
            isSkillOut = true;
    }



    /// <summary>
    /// �����һ������ ֮��ִ�е�����
    /// </summary>
    public void Skill01Close()
    {
        GameManager.MasterSword();
        Time.timeScale = 1;
        isSkillOut = false;
        Cursor.visible = false;

    }
    /// <summary>
    /// ����ڶ������� ֮��ִ�е�����
    /// </summary>
    public void Skill02Close()
    {
        GameManager.DoranShield();
        Time.timeScale = 1;
        isSkillOut = false;
        Cursor.visible = false;
    }
    /// <summary>
    /// ������������� ֮��ִ�е�����
    /// </summary>
    public void Skill03Close()
    {
        GameManager.Frostmourne();
        Time.timeScale = 1;
        isSkillOut = false;
        Cursor.visible = false;
    }

}
