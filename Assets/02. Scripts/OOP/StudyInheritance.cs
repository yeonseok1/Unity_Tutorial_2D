using System.Collections.Generic;
using UnityEngine;

public class StudyInheritance : MonoBehaviour
{
    public List<Person> persons = new List<Person>();
    //public List<Student> students = new List<Student>();
    //public List<Soldier> soldiers = new List<Soldier>();


    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Student student = new Student();
            persons.Add(student);
            
            Soldier soldier = new Soldier();
            persons.Add(soldier);
        }

        /*
        for (int i = 0; i < 10; i++)
        {
            Student student = new Student();
            students.Add(student);
        }

        for (int i = 0; i < 10; i++)
        {
            Soldier soldier = new Soldier();
            soldiers.Add(soldier);
        }
        */
    }

    public void AllMove()
    {
        foreach (var person in persons)
            person.Walk();
        //foreach (var stu in students)
        //    stu.Walk();
        //foreach (var sol in soldiers)
        //    sol.Walk();
    }
}
