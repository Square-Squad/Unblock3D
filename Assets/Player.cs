using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Класс, который задает поведение главного блока
/// <summary>
public class Player : MonoBehaviour
{
	
	[SerializeField] KeyCode keyOne;
	[SerializeField] KeyCode keyTwo;
	[SerializeField] Vector3 moveDirection;
	/// <summary>
	/// Метод, который назначает клавиши
	/// <summary>
	/// <param name="Collider other">Клавиша
	private void FixedUpdate()
	{
		if(Input.GetKey(keyOne))
		{
			GetComponent<Rigidbody>().velocity += moveDirection;
		}

		if(Input.GetKey(keyTwo))
		{
			GetComponent<Rigidbody>().velocity -= moveDirection;
		}
		
		if (Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
	/// <summary>
	/// Тригер на прохождения уровня
	/// <summary>
	/// <param name="Collider other">Объект
	private void OnTriggerEnter(Collider other)
	{
		if(this.CompareTag("Player") && other.CompareTag("Finish"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		if(this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
			foreach(Activator button in FindObjectsOfType<Activator>())
            {
				button.canPush = false;
            }
        }
	}
	/// <summary>
	/// Тригер на активирование кнопок
	/// <summary>
	/// <param name="Collider other">Объект
    private void OnTriggerExit(Collider other)
    {
		if (this.CompareTag("Cube") && other.CompareTag("Cube"))
		{
			foreach (Activator button in FindObjectsOfType<Activator>())
			{
				button.canPush = true;
			}
		}
	}
}
