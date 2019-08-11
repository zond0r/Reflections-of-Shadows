using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float xCube = 4.5f, yCube = 1, zCube = 4.5f;
    public float time = 0.5f;
    public float X = 0, Z = 0;
    public float limit = 4.5f;
    public float timer = 5;
    float num = 0;

    void Start(){
        Vector3 start = new Vector3(xCube, yCube, zCube);
        transform.position = start;
    }
    void Update(){
        num += Time.deltaTime;
        X = X_Z(X);
        Z = X_Z(Z);
        lim();
        if (num < timer)
            transform.Translate(Time.deltaTime * time * X, 0, Time.deltaTime * time * Z);
        else if (num > 2*timer)
            num = 0;
    }
    public float X_Z(float num){
        if (num > 0)
            num = 1;
        else if (num < 0)
            num = -1;
        return num;
    }
    public void lim(){
        if (transform.position.x > limit || transform.position.x < -1 * limit ||
            transform.position.z > limit || transform.position.z < -1 * limit)
            transform.position = new Vector3(0, 0, 0);
    }
}
