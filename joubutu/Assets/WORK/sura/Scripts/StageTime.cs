using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTime : MonoBehaviour {

    [SerializeField]
    private int maxTime;
    [SerializeField]
    private int nowTime;

    // Use this for initialization
    void Start()
    {
        //初期化しよう
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        //制限時間をあれする
        Time();
    }

    void Init()
    {
        //nowTimeを初期化
        nowTime = 0;
    }

    void Time()
    {
        //maxTimeまでカウントしような
        if (maxTime >= nowTime)
        {
            nowTime++;
        }
        else
        {
            //生き残ったな
            FadeScene();
            nowTime = 0;
        }
    }

    public void FadeScene()
    {
        FadeManager.Instance.LoadScene("Clear", 1.0f);
    }
}
