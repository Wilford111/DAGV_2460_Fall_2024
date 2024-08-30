using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data", menuName = "ScriptableObjects/FloatData")]
public class FloatData : ScriptableObject
{
    public float value;

    public void SetValue(float num)
    {
        value = num;
    }

    public void UpdateValue(float num)
    {
        value += num;
    }
}
