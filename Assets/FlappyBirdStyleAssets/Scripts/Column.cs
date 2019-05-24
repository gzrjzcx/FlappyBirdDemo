using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		// GameControl.instance.BirdScored();
		if(other.GetComponent<bird>() != null)
		{
			GameControl.instance.BirdScored();
		}
	}
}
