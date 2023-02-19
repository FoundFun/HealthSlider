using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]
public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;

    private Health _health;

    private void Start()
    {
        _health = GetComponent<Health>();
    }

    private void Update()
    {
        if (_healthSlider.value != _health.Target)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, _health.Target, _health.MaxDelta * Time.deltaTime);
        }
    }
}
