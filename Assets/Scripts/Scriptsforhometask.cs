using UnityEngine;

public class Example : MonoBehaviour
{
    public Camera camera1;
    public Transform cubeTransform;
    public Vector3 vector3;

    void Start()
    {
        // 1-� �������:
        camera1.fieldOfView = 100; // ������ FOV
        camera1.backgroundColor = Color.black; // ������ background

        cubeTransform.localScale = new Vector3(1, 10, 1); // ������ ����� ����
        cubeTransform.position = new Vector3(0, 0, 0); // ������ ������� ����
    }
}
