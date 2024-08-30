using UnityEngine;

[CreateAssetMenu(fileName = "New Vector3 Data", menuName = "ScriptableObjects/Vector3Data")]
public class Vector3Data : ScriptableObject
{
    public Vector3 position;

    public void UpdatePosition(Vector3 newPosition)
    {
        position = newPosition;
    }
}
