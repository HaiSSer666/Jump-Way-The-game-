using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scroll : MonoBehaviour
{

    public float speed = 5f;// Выбираем скорость 
    public float pos = 0f; // Позиция к которой будет стремится объект - данного скрипта
    private RectTransform rec;

    void Start()
    {
        rec = GetComponent<RectTransform>();
    }

    void Update()
    {
        if (rec.offsetMax.y != pos) // Если Y-вектор не равен указанной позиции , то двигаем его к Pos. Если нужно, чтоб меню выходило сбоку, то меняем Y на X , а x на y
        {
            rec.offsetMin += new Vector2(-rec.offsetMin.x, speed); // Свойство offsetMin задаёт угол левого нижнего угла прямоугольника относительно левой нижней привязки.
            rec.offsetMax += new Vector2(-rec.offsetMax.x, speed); // Свойство offsetMax задаёт угол правого верхнего угла прямоугольника относительно правой верхней привязки.
        }
    }

}
