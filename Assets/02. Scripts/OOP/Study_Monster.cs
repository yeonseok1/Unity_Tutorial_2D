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

        /// 다운 캐스팅
        /// 자식 클래스에 따라 안 될 수 있음 - Orc.Flying(); <- ???
        Monster m5 = new Monster();
        Orc orc2 = (Orc)m5;


        /// 업 캐스팅
        // 명시적 클래스 형변환
        Monster m1 = (Monster)orc;  
        Monster m2 = (Monster)goblin;

        // 암시적 클래스 형변환
        Monster m3 = orc;
        Monster m4 = goblin;
        monsters.Add(orc);
        monsters.Add(goblin);
    }
}
