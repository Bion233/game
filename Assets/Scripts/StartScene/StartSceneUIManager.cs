using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
///
/// </summary>
public class StartSceneUIManager : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject SecondPanel;
    public GameObject ConfirmButton;
    public GameObject SorryText;

    public GameObject[] Animo;
    public GameObject[] PlayerKind;
    public GameObject[] PlayerNames;

    private Color hightLightColor;//文字的
    private Color darkLightColor;

    private Color PlayerColor;
    private Color PlayerNoneColor;

    private int PlayerCount;
    


    private void Start()
    {
        hightLightColor=new Color(0.6698113f, 0.5908241f, 0.5908241f);
        darkLightColor = new Color(0.1960784f, 0.1960784f, 0.1960784f);

        PlayerColor = new Color(0.6f, 0.6f, 0.6f);
        PlayerNoneColor = new Color(0f, 0f, 0f, 0f);

        Cursor.visible = true;//光标可见
    }

    private void Update()
    {
        
    }







    /// <summary>
    /// 开始游戏
    /// </summary>
    public void PlayGame()
    {
        StartPanel.SetActive(false);
        SecondPanel.SetActive(true);
    }

    /// <summary>
    /// 退出游戏
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }

    #region 点击确认按钮后的结果
    /// <summary>
    /// 跳转到下一个场景
    /// </summary>
    public void ConfirmIn()
    {
        PlayerWho();
    }

    /// <summary>
    /// 确认选择后执行的事
    /// </summary>
    private void PlayerWho()
    {

        if (PlayerCount == 0)
        {
            SceneManager.LoadScene(1);
        }
        if (PlayerCount == 1)
        {
            SorryText.SetActive(true);
            Invoke("Sorrytest", 1);

        }
        if (PlayerCount == 2)
        {
            SorryText.SetActive(true);
            Invoke("Sorrytest", 1);
        }
        if (PlayerCount == 3)
        {
            SorryText.SetActive(true);
            Invoke("Sorrytest", 1);
        }
    }

    private void Sorrytest()
    {
        SorryText.SetActive(false);
    }

    #endregion



    public void LisaCilck()
    {
        PlayerKind[0].GetComponent<Image>().color = PlayerNoneColor;
        PlayerNames[0].GetComponent<Text>().color = hightLightColor;
        Animo[0].SetActive(true);

        Animo[1].SetActive(false );
        Animo[2].SetActive(false );
        Animo[3].SetActive(false );

        PlayerNames[1].GetComponent<Text>().color=darkLightColor;
        PlayerNames[2].GetComponent<Text>().color = darkLightColor;
        PlayerNames[3].GetComponent<Text>().color = darkLightColor;

        PlayerKind[1].GetComponent<Image>().color = PlayerColor;
        PlayerKind[2].GetComponent<Image>().color = PlayerColor;
        PlayerKind[3].GetComponent<Image>().color = PlayerColor;
        PlayerCount = 0;
        ConfirmButton.SetActive(true);

    }

    public void AliceClick()
    {
        PlayerKind[1].GetComponent<Image>().color = PlayerNoneColor;
        PlayerNames[1].GetComponent<Text>().color = hightLightColor;
        Animo[1].SetActive(true);

        Animo[0].SetActive(false);
        Animo[2].SetActive(false);
        Animo[3].SetActive(false);

        PlayerNames[0].GetComponent<Text>().color = darkLightColor;
        PlayerNames[2].GetComponent<Text>().color = darkLightColor;
        PlayerNames[3].GetComponent<Text>().color = darkLightColor;

        PlayerKind[0].GetComponent<Image>().color = PlayerColor;
        PlayerKind[2].GetComponent<Image>().color = PlayerColor;
        PlayerKind[3].GetComponent<Image>().color = PlayerColor;
        PlayerCount = 1;
        ConfirmButton.SetActive(true);
    }

    public void TiffantClick()
    {

        Debug.Log("敌法");
        PlayerKind[2].GetComponent<Image>().color = PlayerNoneColor;
        PlayerNames[2].GetComponent<Text>().color = hightLightColor;
        Animo[2].SetActive(true);

        Animo[1].SetActive(false);
        Animo[0].SetActive(false);
        Animo[3].SetActive(false);

        PlayerNames[1].GetComponent<Text>().color = darkLightColor;
        PlayerNames[0].GetComponent<Text>().color = darkLightColor;
        PlayerNames[3].GetComponent<Text>().color = darkLightColor;

        PlayerKind[1].GetComponent<Image>().color = PlayerColor;
        PlayerKind[0].GetComponent<Image>().color = PlayerColor;
        PlayerKind[3].GetComponent<Image>().color = PlayerColor;
        PlayerCount = 2;
        ConfirmButton.SetActive(true);
    }

    public void DarkKnightClick()
    {
        PlayerKind[3].GetComponent<Image>().color = PlayerNoneColor;
        PlayerNames[3].GetComponent<Text>().color = hightLightColor;
        Animo[3].SetActive(true);

        Animo[1].SetActive(false);
        Animo[2].SetActive(false);
        Animo[0].SetActive(false);

        PlayerNames[1].GetComponent<Text>().color = darkLightColor;
        PlayerNames[2].GetComponent<Text>().color = darkLightColor;
        PlayerNames[0].GetComponent<Text>().color = darkLightColor;

        PlayerKind[1].GetComponent<Image>().color = PlayerColor;
        PlayerKind[2].GetComponent<Image>().color = PlayerColor;
        PlayerKind[0].GetComponent<Image>().color = PlayerColor;
        PlayerCount = 3;
        ConfirmButton.SetActive(true);
    }

  



}
