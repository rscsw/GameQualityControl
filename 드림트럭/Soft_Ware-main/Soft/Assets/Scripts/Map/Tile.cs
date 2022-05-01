using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Color StartColor;
    public Color SelectColor;
    Renderer rd;

    public TowerManager tm;

    public GameObject tower1;
    public GameObject tower2;
    public GameObject random_Tower;

    public GameObject ex_Tower;

    public float tower1_money; //��ġ��
    public float tower2_money;
    public float random_Tower_Money;

    public float ex_Tower_Money;


    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    private void OnMouseExit() //Ÿ�� ��ġ���� ���콺�� ��������
    {
        rd.material.color = StartColor;
    }

    private void OnMouseOver() //Ÿ�� ��ġ�� ���콺�� �������� (���� �ٲ�)
    {
        rd.material.color = SelectColor;

        if (Input.GetMouseButtonDown(0)) // Ÿ�� ��ġ
        {
            if(GameManager.instance.money < tower1_money && tm.tower1 == true)
            {
                Debug.Log("Ÿ�� 1��(��) ��ġ�ϱ⿡ ����� ���� �����ϴ�.");
            }
            else if(GameManager.instance.money < tower2_money && tm.tower2 == true)
            {
                Debug.Log("Ÿ�� 2��(��) ��ġ�ϱ⿡ ����� ���� �����ϴ�.");
            }
            else if (GameManager.instance.money < random_Tower_Money && tm.randomTower == true)
            {
                Debug.Log("���� Ÿ����(��) ��ġ�ϱ⿡ ����� ���� �����ϴ�.");
            }
            else if(GameManager.instance.money < ex_Tower_Money && tm.ex_Tower == true)
            {
                Debug.Log("Ex_Tower��(��) ��ġ�ϱ⿡ ����� ���� �����ϴ�.");
            }
            else
            {
                if (tm.tower1)
                {
                    //��ġ�� ����.
                    GameManager.instance.money -= tower1_money;
                    Instantiate(tower1, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.tower1 = false;
                }
                else if (tm.tower2)
                {
                    GameManager.instance.money -= tower2_money;
                    Instantiate(tower2, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.tower2 = false;
                }
                else if (tm.randomTower)
                {
                    GameManager.instance.money -= random_Tower_Money;
                    Instantiate(random_Tower, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.randomTower = false;
                }
                else if (tm.ex_Tower)
                {
                    GameManager.instance.money -= ex_Tower_Money;
                    Instantiate(ex_Tower, transform.position, Quaternion.identity);
                    rd.material.color = StartColor;
                    tm.ex_Tower = false;
                }
            }
        }
    }
}
