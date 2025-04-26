using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using System;

public class TextScropt : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.DOText("Text of DOtween",2f,true,ScrambleMode.All);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
