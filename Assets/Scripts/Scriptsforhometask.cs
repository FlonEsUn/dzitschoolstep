using UnityEngine;

public class Example : MonoBehaviour
{
    public Camera camera1;
    public Transform cubeTransform;
    public Vector3 vector3;

    void Start()
    {
        // 1-й елемент:
        camera1.fieldOfView = 100; // «м≥нити FOV
        camera1.backgroundColor = Color.black; // «м≥нити background

        cubeTransform.localScale = new Vector3(1, 10, 1); // «м≥нити розм≥р куба
        cubeTransform.position = new Vector3(0, 0, 0); // «м≥нити позиц≥ю куба
    }
}
