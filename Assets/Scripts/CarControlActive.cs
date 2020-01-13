using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour
{
	public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        (car.GetComponent("CarController") as MonoBehaviour).enabled = true;
    }
}
