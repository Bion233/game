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



    
    public Button Yes;//是否退出游戏的button
    public Button No;
   
    

    private bool isEsc=true;
    private bool isPlay=true;
    private bool isOut=true;//用于禁用Esc呼出菜单的功能
    private bool isSkillOut=true;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        scrollbar.GetComponent<Scrollbar>().size = GameManager.scrollBarValue;
        EscOut();//呼出菜单
        SkillsOut();//技能栏自动弹出
        SkillsClose();
        gradeText.GetComponent<Text>().text = "Level:" + GameManager.playerGrade;
        killText.GetComponent<Text>().text = "KillCount:" + GameManager.killedEnemys;
    }

    /// <summary>
    /// 呼出菜单
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
    #region 退出游戏
    /// <summary>
    /// 选择是否退出游戏
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
    /// 继续游戏
    /// </summary>
    public void PlayerGame()
    {
        outMeau.SetActive(false);
        Time.timeScale = 1;
        Player.GetComponent<PlayerAttack>().enabled = true;
    }

    /// <summary>
    /// 暂停音乐
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
    /// 跳转到初始页面
    /// </summary>
    public void ExitToMeau()
    {
        SceneManager.LoadScene(0);
    }


    /// <summary>
    /// 技能栏随等级自动弹出
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
    /// 反转技能弹窗的判断
    /// </summary>
    private void SkillsClose()
    {
        if (GameManager.pointCount == 9|| GameManager.pointCount == 25|| GameManager.pointCount == 58|| GameManager.pointCount == 121|| GameManager.pointCount == 249)
            isSkillOut = true;
    }



    /// <summary>
    /// 点击第一个技能 之后执行的内容
    /// </summary>
    public void Skill01Close()
    {
        GameManager.MasterSword();
        Time.timeScale = 1;
        isSkillOut = false;
        Cursor.visible = false;

    }
    /// <summary>
    /// 点击第二个技能 之后执行的内容
    /// </summary>
    public void Skill02Close()
    {
        GameManager.DoranShield();
        Time.timeScale = 1;
        isSkillOut = false;
        Cursor.visible = false;
    }
    /// <summary>
    /// 点击第三个技能 之后执行的内容
    /// </summary>
    public void Skill03Close()
    {
        GameManager.Frostmourne();
        Time.timeScale = 1;
        isSkillOut = false;
        Cursor.visible = false;
    }

}
