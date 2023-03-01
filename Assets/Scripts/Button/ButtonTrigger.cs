using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
///按钮上的组件 主要是控制声音的播放
/// </summary>
public class ButtonTrigger : MonoBehaviour,IPointerEnterHandler, IPointerDownHandler
{
    /// <summary>
    /// 0:鼠标在按钮上的音乐  1：鼠标点击按钮的音乐   主要控制按钮的声音
    /// </summary>
    public GameObject[] AudioButton;

 

   

    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioButton[0].GetComponent<AudioSource>().Play();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        AudioButton[1].GetComponent<AudioSource>().Play();
    }
}
