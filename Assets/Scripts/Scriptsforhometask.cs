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
        camera1.fieldOfView = 80; 
        camera1.backgroundColor = Color.black; 

        cubeTransform.localScale = new Vector3(1, 1, 1); 
        cubeTransform.position = new Vector3(0, 0, 0);

        // 2-й елемент:
        light2.intensity = 1; 
        light2.color = Color.white; 

        vector3 = new Vector3(20, 24.77f, 89.871f); 

        camera1.enabled = false; 
        camera2.enabled = false; 
        camera3.enabled = true; 
    }
}
