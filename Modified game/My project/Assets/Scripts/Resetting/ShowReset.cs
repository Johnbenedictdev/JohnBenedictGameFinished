using UnityEngine;
using UnityEngine.UI;
public class ShowReset : MonoBehaviour 
{
    public GameObject ResetText;
    public static int ResetCollected;
    
    void Update()
    {
        ResetText.GetComponent<Text>().text = "" +ResetCollected;
    }
        		
}


