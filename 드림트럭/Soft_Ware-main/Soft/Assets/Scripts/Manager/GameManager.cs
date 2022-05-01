using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI totalMoneyText;

    public float money; //�ʱ����޸Ӵ�
    public float totalMoney; //�� ��

    public GameObject[] waypoints; //wayPoints

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        Money();
    }
    
    public void Money()
    {
        moneyText.text = money.ToString();
        totalMoneyText.text = totalMoney.ToString();
    }
}
