using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveCamera_Sagidullina : MonoBehaviour
{
    public Transform
target;
    public float
    height = 2f,
    distance = 5f,
    speed = 0.125f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    { 
if (target != null)
        { 
    Vector3
    // Новое положение объекта
    pos = target.position - target.forward * distance + Vector3.up*height,
    // Плавная смена положения камеры к объекту

    pos_fix = Vector3.Lerp(transform.position, pos, speed);

    transform.position = pos_fix;
transform.LookAt(target.position);
        }
    }
}

