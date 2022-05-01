using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    public float limit_Time;
    public float surviveCnt;
    public float failCnt;

    bool stageStart = false;
    public Text timeText;
        

    void Update()
    {
        if (stageStart)
        {
            limit_Time -= Time.deltaTime;
        }

        timeText.text = limit_Time.ToString("N0");

        if (limit_Time <= 0)
        {
            timeText.text = "�ð����� ����";
            Time.timeScale = 0;
        }

        if(surviveCnt >= failCnt)
        {
            Time.timeScale = 0;
            timeText.text = "���ļ� ����";
        }
    }
    public void TimeGo()
    {
        stageStart = true;
    }

}
