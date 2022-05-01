using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public bool tower1 = false;
    public bool tower2 = false;
    public bool randomTower = false;
    public bool ex_Tower = false;

    public void Tower1_Btn() //tower1��ư Ŭ���� Tile��ũ��Ʈ�� OnmouseOver�� ��.
    {
        tower1 = true;
        tower2 = false;
        randomTower = false;
        ex_Tower = false;
    }

    public void Tower2_Btn()
    {
        tower2 = true;
        tower1 = false;
        randomTower = false;
        ex_Tower = false;
    }

    public void RandomTower_Btn()
    {
        randomTower = true;
        tower1 = false;
        tower2 = false;
        ex_Tower = false;
    }

    public void Ex_Tower_Btn()
    {
        ex_Tower = true;
        randomTower = false;
        tower1 = false;
        tower2 = false;
    }

}
