using System.Globalization;
using TMPro;
using UnityEditor.Compilation;
using UnityEngine;
using UnityEngine.Events;

public class TextMeshProBehavior : MonoBehaviour
{
    private TextMeshProUGUI label;
    public UnityEvent startEvent, respondEvent;
    public GameAction textAction;
    
    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        textAction.RaiseNoArgs += Respond;
        startEvent.Invoke();
    }

    private void Respond()
    {
        respondEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}