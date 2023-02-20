using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public UnityAction<float, float> OnChanged;

    private const float _maxValue = 1;

    private float _maxDelta = 0.1f;
    private float _step = 0.1f;
    private float _target;

    private void Start()
    {
        _target = _maxValue;
        OnChanged?.Invoke(_target, _maxDelta);
    }

    public void TakeDamage()
    {
        if (_target > 0)
        {
            _target -= _step;
            OnChanged?.Invoke(_target, _maxDelta);
        }
    }

    public void TakeHealth()
    {
        if (_target < _maxValue)
        {
            _target += _step;
            OnChanged?.Invoke(_target, _maxDelta);
        }
    }
}
