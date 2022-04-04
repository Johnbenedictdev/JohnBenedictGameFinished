using UnityEngine;
using UnityEngine.UI;
public class FriendsShow : MonoBehaviour 
{
    public GameObject FriendsTexts;
    public static int FriendsSaved;
    void Update()
    {
        FriendsTexts.GetComponent<Text>().text = "" +FriendsSaved;
    }
}


