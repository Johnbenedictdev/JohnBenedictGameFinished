using UnityEngine;
using UnityEngine.UI;

public class ScoresSystem : MonoBehaviour 
{
	public GameObject gemsText;
	public static int gemsCollected;
	void Update()
	{
		gemsText.GetComponent<Text>().text = "" +gemsCollected;
	}
}