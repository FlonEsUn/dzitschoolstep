using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public Light light2;
    public Vector3 vector3;

    void Start()
    {
        light2.intensity = 1; // ������ intensity
        light2.color = Color.white; // ������ color

        vector3 = new Vector3(20, 24.77f, 89.871f); // ������ ������
    }
}
