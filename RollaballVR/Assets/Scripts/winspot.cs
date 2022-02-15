using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class winspot : MonoBehaviour
{
    public GameObject winTextObject;
    // Start is called before the first frame update
    void Start()
    {
        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
	{
		// ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("leBall"))
		{
			other.gameObject.SetActive(false);

			winTextObject.SetActive(true);
		}
	}
}
