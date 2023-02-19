using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;

    private float _maxDelta = 0.1f;
    private float _target;

    public float MaxDelta => _maxDelta;
    public float Target => _target;

    private void Start()
    {
        _target = _healthSlider.value;
    }

    public void Changed(int polarity)
    {
        float step = 0.1f;

        _target = _healthSlider.value + step * polarity;
    }
}
