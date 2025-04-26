using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StrberryController : MonoBehaviour
{
    public GameObject message;
    // Start is called before the first frame update
    void Start()
    {
    //   transform. DOMove(new Vector3(1f,0,0),1f).SetLoops(-1,LoopType.Incremental);
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.DOFade(0,1f).OnComplete(ShowMessage);
    }
    void ShowMessage(){
        message.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
