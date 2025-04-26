using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PanelComtroller : MonoBehaviour
{
    RectTransform target;
    // Start is called before the first frame update
    void Start()
    {
       target = GetComponent<RectTransform>();
       target.localScale = Vector3.zero;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            target = GetComponent<RectTransform>();
            target.DOAnchorPos(new Vector2(0f,0f),0.6f).SetEase(ease:Ease.OutBack);
            target.DOLocalRotate(new Vector3(360f,0,0),0.6f,RotateMode.FastBeyond360)
            .SetEase(Ease.OutCubic);

            target.DOScale(1f,0.6f).SetEase(Ease.OutBack,5f);
        }
        
    }
}
