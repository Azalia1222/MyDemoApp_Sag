using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveParticle_Sagidullina : MonoBehaviour
{
    public float
speedMove = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float
   // Получаем клик по сторонам (влево, вправо)
   horInput = Input.GetAxis("Horizontal"),
// Получаем клик по направлению (вперед, назад)
verInput = Input.GetAxis("Vertical");

        Vector3
    // Получаем вектор с разницей направления
    direction = new Vector3(horInput, 0.0f, verInput);
       // Меняем положение объекта
transform.Translate(direction *speedMove*Time.deltaTime);
    }
}

    