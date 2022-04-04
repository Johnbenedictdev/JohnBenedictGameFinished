using UnityEngine;
using UnityEngine.UI;
public class Reset : MonoBehaviour 
{


    void OnTriggerEnter(Collider other)
    {
       
        ShowReset.ResetCollected = 0;
        
    }
}

