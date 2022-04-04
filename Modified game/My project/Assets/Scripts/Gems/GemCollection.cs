using UnityEngine;
using UnityEngine.UI;
public class GemCollection : MonoBehaviour 
{
	public AudioSource gemSound;
	
	void OnTriggerEnter(Collider other)
	{
		gemSound.Play();
		ScoresSystem.gemsCollected +=1;
		Destroy(gameObject);
	}
}

