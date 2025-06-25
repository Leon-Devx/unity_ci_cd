using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private int _count = 0;

    private TextMeshProUGUI _text;

    private void Awake() => _text = GetComponentInChildren<TextMeshProUGUI>();

    public void IncreaseCount()
    {
        _count+=2;
        _text.text = _count.ToString();
    }
}
