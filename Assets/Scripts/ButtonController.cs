using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _changedButton;
    [SerializeField] private int _polarity;

    private void OnEnable()
    {
        _changedButton.onClick.AddListener(OnChanged);
    }

    private void OnDisable()
    {
        _changedButton.onClick.RemoveListener(OnChanged);
    }

    private void OnChanged()
    {
        _health.Changed(_polarity);
    }
}