using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using DG.Tweening;

public class ImageCont : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetRequest("https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEiRuu0RWoeHs26-kJWDLyILcJZ9OljBuc_LyatexrDqGsYOBKNqKJWrt_jKhFATb1jmj124nhh4vTprkPzcRYemzFuSxbCR9cGFomOZx-vnOwQ5a16_4TmbjRWUolmtkNHg_d_5h-BtyvoTMJCvJ6ZmiiiSyu_0RfsbAStBrMaoUm8HN6NFJHIi-Lv8f0hh/s790/bird_fukurou_run.png"));
    }

    IEnumerator GetRequest(string uri){
        using(UnityWebRequest uwr = UnityWebRequestTexture.GetTexture(uri)){
            yield return uwr.SendWebRequest();
            if(uwr.result != UnityWebRequest.Result.Success){
                Debug.Log(uwr.error);
            }else {
                Texture texture = DownloadHandlerTexture.GetContent(uwr);
                Sprite sp = Sprite.Create(
                    (Texture2D)texture,
                    new Rect(0,0,texture.width,texture.height),
                    new Vector2(0.5f,0.5f)
                    );
                Image image = GetComponent<Image>();

                image.rectTransform.sizeDelta = new Vector2(
                    sp.rect.width,sp.rect.height
                );
                image.sprite = sp;
                image.transform.DORotate(new Vector3(0f,0f,-360f),2f,RotateMode.FastBeyond360)
                .SetDelay(2f);
            }
        } 
    }

    void Update()
    {
        
    }
}
