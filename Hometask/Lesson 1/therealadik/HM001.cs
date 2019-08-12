using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class OneSC : MonoBehaviour
{ 
    public Vector3 pos0 = new Vector3(0f,0f,0f);
    public float Speed = 50f;
    public Vector3 direction = new Vector3(0f, 0f, 0f);
    public float[] Stop = { 100f, 100f, 100f };
    public float time = 5f; // время в пути
    public float stoptime = 5f; // сколько нужно стоять
    private float localtime = 0f;
    private float X;
    void Start()
    {
        transform.position = pos0;
        transform.eulerAngles = direction;
        X = stoptime;
        
    }

    void Update()
    {
        Vector3 posObj = transform.position;
        while (localtime < time) //проверяем сколько времени уже в пути наш куб
        {
            localtime += Time.deltaTime;
            transform.Translate(Speed * Time.deltaTime, 0f, 0f);
        }
        localtime = 0;
        while (stoptime > 0)// не пора ли продолжить движение
        {
            stoptime -= Time.deltaTime;
        }
        stoptime = X; //присваиваем изначальное значение

        if (posObj.x > Stop[0] | posObj.y > Stop[1] | posObj.z > Stop[2])
            transform.position = pos0;
    }
}
