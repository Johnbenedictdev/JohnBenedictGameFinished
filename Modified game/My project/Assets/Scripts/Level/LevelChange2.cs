using UnityEngine;
using UnityEngine.UI;

public class LevelChange2 : MonoBehaviour 
{
	public AudioSource NewLevelSound;
	
	void OnTriggerEnter(Collider other)
	{
		NewLevelSound.Play();
		LevelShow2.targetHit +=1;
		Destroy(gameObject);
	}
}

