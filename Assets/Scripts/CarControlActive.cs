using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour
{
	public GameObject car;
	public GameObject dreamcar01;
    // Start is called before the first frame update
    void Start()
    {
        (car.GetComponent("CarController") as MonoBehaviour).enabled = true;
		(dreamcar01.GetComponent("CarAIControl") as MonoBehaviour).enabled = true;
    }
}
