using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Health))]
public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;

    private Health _health;
    private Coroutine _coroutine;

    private void Awake()
    {
        _health = GetComponent<Health>();
    }

    private void OnEnable()
    {
        _health.OnChanged += Changed;
    }

    private void OnDisable()
    {
        _health.OnChanged -= Changed;
    }

    private void Changed(float target, float maxDelta)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(Shift(target, maxDelta));
    }

    private IEnumerator Shift(float target, float maxDelta)
    {
        while (_healthSlider.value != target)
        {
            _healthSlider.value = Mathf.MoveTowards(_healthSlider.value, target, maxDelta * Time.deltaTime);

            yield return null;
        }
    }
}
