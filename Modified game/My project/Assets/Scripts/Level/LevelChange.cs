using UnityEngine;
using UnityEngine.UI;

public class LevelChange : MonoBehaviour 
{
	public AudioSource NewLevelSound;
	
	void OnTriggerEnter(Collider other)
	{
		NewLevelSound.Play();
		LevelShow.targetHit +=1;
		Destroy(gameObject);
	}
}

