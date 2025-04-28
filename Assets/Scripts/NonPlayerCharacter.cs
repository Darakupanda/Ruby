using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class NonPlayerCharacter : MonoBehaviour
{
    public float displayTime = 4f;
    GameObject dialogBox;
    float timerDisplay;
    public TextMeshProUGUI text;

    void Start()
    {
        dialogBox = transform.GetChild(0).gameObject;
        dialogBox.SetActive(false);
        Debug.Log(text.text);
        timerDisplay = -1f;    
    }

    // Update is called once per frame
    void Update()
    {
        if(timerDisplay >= 0){
            timerDisplay -= Time.deltaTime;
            if(timerDisplay < 0){
                dialogBox.transform.DOScale(Vector3.zero,0.3f)
                .OnComplete(()=>text.text="");
            }
        }
    }
    public void DisplayDialog(){
        timerDisplay = displayTime;
        dialogBox.SetActive(true);
        text.DOText("Help!!\nFix all\nbroken Robot!",3f).SetEase(Ease.Linear);
    }
}
