using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //уровень NPC
   public int health = 5;

    //уровень NPC
   public int level = 1;

    //скорость NPC
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        //прибавляет количество жизней NPC
        health += level;

        //выводит значение health 1 раз
        print(health);
        
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition;

        newPosition = transform.position;

        newPosition.z += speed * Time.deltaTime;

        transform.position = newPosition;
        
    }
}
