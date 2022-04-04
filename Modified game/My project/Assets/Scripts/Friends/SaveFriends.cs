using UnityEngine;
using UnityEngine.UI;
public class SaveFriends : MonoBehaviour 
{
    public AudioSource FriendsSavedSound;
    
    void OnTriggerEnter(Collider other)
    {
        FriendsSavedSound.Play();
        FriendsShow.FriendsSaved +=1;
        Destroy(gameObject);
    }
}