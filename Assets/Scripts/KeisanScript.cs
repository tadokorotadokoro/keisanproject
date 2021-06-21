using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeisanScript : MonoBehaviour
{
    public Text kotaeText; // unityにある文字です

    float kotae;　//　答えの計算をここにだします

    // --------------------------------------------
    // Start is called before the first frame update
    //　最初に一回だけ命令を出します
    void Start()
    {
        // 注意！ 答えが小数になりそうなときは　各数字の後にfをつけよう！　例) kotae = 3f/2f   >> 1.5　になります
        //　計算式を書いてみよう！
        kotae = 3+2;
        print(kotae);

        // 答えをunity側で表示します！
        kotaeText.text = kotae.ToString();
    }

    // --------------------------------------------




    // --------------------------------------------
    // Update is called once per frame
    //　命令をずっと出します
    void Update()
    {
        
    }

    // --------------------------------------------
}


