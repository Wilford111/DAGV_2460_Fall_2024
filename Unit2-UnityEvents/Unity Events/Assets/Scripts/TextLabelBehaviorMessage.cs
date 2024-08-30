using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviorMessage: MonoBehaviour
{
    public Text label;
    public MessageData dataObj;
    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = dataObj.message.ToString(CultureInfo.InvariantCulture);
    }
}
