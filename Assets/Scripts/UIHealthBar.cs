using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIHealthBar : MonoBehaviour
{
    public static UIHealthBar instance{get; private set;}
    public Image mask;
    float originalSize;

    bool isPinch = false;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        originalSize = mask.rectTransform.rect.width;   
    }
    public void SetValue(float value){
        DOTween.To(
            ()=>mask.rectTransform.rect.width,
            x=>mask.rectTransform.SetSizeWithCurrentAnchors(
            RectTransform.Axis.Horizontal,x),originalSize*value,0.3f
        );
    }
}
