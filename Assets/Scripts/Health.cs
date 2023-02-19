using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;

    private float _maxDelta = 0.1f;
    private float _target;

    private void Start()
    {
        _target = _healthSlider.value;
    }

    private void Update()
    {
        if (_healthSlider.value != _target)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, _target, _maxDelta * Time.deltaTime);
        }
    }

    public void Changed(int polarity)
    {
        float step = 0.1f;

        _target = _healthSlider.value + step * polarity;
    }
}
