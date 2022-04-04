using System.Collections;

using System.Collections.Generic;

using UnityEngine;

 using UnityEngine;
using UnityEngine.Events;

public class Teleporting : MonoBehaviour

{

public Transform destination;

// Start is called before the first frame update

void Start()

{

 

}

 

// Update is called once per frame

void Update()

{

 

}

public void OnTriggerEnter(Collider other)

{

other.transform.position = destination.transform.position;


}

}