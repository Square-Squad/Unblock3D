using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
/// <summary>
/// Класс, который задает поведение кнопок и активированных блоков
/// <summary>
=======
>>>>>>> master
public class Activator : MonoBehaviour
{
    public GameObject[] firstGroup;
    public GameObject[] secondGroup;
    public Activator button;
    public Material normal;
    public Material transparent;
    public bool canPush;

<<<<<<< HEAD
    /// <summary>
	/// Тригер на активирование кнопок
	/// <summary>
	/// <param name="Collider other">Объект
=======
>>>>>>> master
    private void OnTriggerEnter(Collider other)
    {
        if (canPush)
        {

            if (other.CompareTag("Cube") || other.CompareTag("Player"))
            {
                foreach (GameObject first in firstGroup)
                {
                    first.GetComponent<Renderer>().material = normal;
                    first.GetComponent<Collider>().isTrigger = false;
                }
                foreach (GameObject second in secondGroup)
                {
                    second.GetComponent<Renderer>().material = transparent;
                    second.GetComponent<Collider>().isTrigger = true;
                }
                GetComponent<Renderer>().material = transparent;
                button.GetComponent<Renderer>().material = normal;
                button.canPush = true;
            }
        }
    }
}
