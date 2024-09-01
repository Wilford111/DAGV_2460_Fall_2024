using UnityEngine;

[CreateAssetMenu(fileName = "New Int Data", menuName = "ScriptableObjects/IntData")]
public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }
}
