using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class Skills : MonoBehaviour
{
    public GameObject step01;
    public GameObject skills;
    public void Close()
    {
        Time.timeScale = 1;
        GameManager.MasterSword();
        step01.SetActive(false);
        skills.SetActive(false);
    }
}
