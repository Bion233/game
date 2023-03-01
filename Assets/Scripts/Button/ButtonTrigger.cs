using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
///��ť�ϵ���� ��Ҫ�ǿ��������Ĳ���
/// </summary>
public class ButtonTrigger : MonoBehaviour,IPointerEnterHandler, IPointerDownHandler
{
    /// <summary>
    /// 0:����ڰ�ť�ϵ�����  1���������ť������   ��Ҫ���ư�ť������
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
