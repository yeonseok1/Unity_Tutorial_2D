using System;
using System.Collections.Generic;
using UnityEngine;

public class Study_Monster : MonoBehaviour
{
    List<Orc> orcs = new List<Orc>();
    List<Goblin> goblins = new List<Goblin>();

    List<Monster> monsters = new List<Monster>();

    private void Start()
    {
        Orc orc = new Orc();
        Goblin goblin = new Goblin();

        /// �ٿ� ĳ����
        /// �ڽ� Ŭ������ ���� �� �� �� ���� - Orc.Flying(); <- ???
        Monster m5 = new Monster();
        Orc orc2 = (Orc)m5;


        /// �� ĳ����
        // ����� Ŭ���� ����ȯ
        Monster m1 = (Monster)orc;  
        Monster m2 = (Monster)goblin;

        // �Ͻ��� Ŭ���� ����ȯ
        Monster m3 = orc;
        Monster m4 = goblin;
        monsters.Add(orc);
        monsters.Add(goblin);
    }
}
