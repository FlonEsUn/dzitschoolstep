using UnityEngine;

public class Example : MonoBehaviour
{
    public Camera camera1;
    public Transform cubeTransform;
    public Light light2;
    public Vector3 vector3;
    public Camera camera2;
    public Camera camera3;

    void Start()
    {
        // 1-й елемент:
        camera1.fieldOfView = 60; // Змінити FOV
        camera1.backgroundColor = Color.black; // Змінити background

        cubeTransform.localScale = new Vector3(1, 1, 1); // Змінити розмір куба
        cubeTransform.position = new Vector3(0, 0, 0); // Змінити позицію куба

        // 2-й елемент:
        light2.intensity = 1; // Змінити intensity
        light2.color = Color.white; // Змінити color

        vector3 = new Vector3(20, 24.77f, 89.871f); // Задати вектор

        // 3-й елемент:
        camera1.enabled = false; // Виключити першу камеру
        camera2.enabled = false; // Виключити другу камеру
        camera3.enabled = true; // Ввімкнути третю камеру
    }
}
