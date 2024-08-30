using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data", menuName = "ScriptableObjects/MessageData")]
public class MessageData : ScriptableObject
{
    public string message;
    
    public void UpdateMessage(string words)
    {
        message = words;
    }
}
