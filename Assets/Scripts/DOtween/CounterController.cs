using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CounterController : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.DOCounter(500,9999,1.5f,true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
