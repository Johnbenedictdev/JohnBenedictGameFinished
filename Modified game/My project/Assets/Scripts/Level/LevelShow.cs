using UnityEngine;
using UnityEngine.UI;

public class LevelShow : MonoBehaviour 
{
	public GameObject targetText;
	public static int targetHit =1;
	void Update()
	{
		targetText.GetComponent<Text>().text = "" +targetHit;
	}
}
