using UnityEngine;
using UnityEngine.UI;

public class ButtonDamage : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _damageButton;

    private void OnEnable()
    {
        _damageButton.onClick.AddListener(OnTakeDamage);
    }

    private void OnDisable()
    {
        _damageButton.onClick.RemoveListener(OnTakeDamage);
    }

    private void OnTakeDamage()
    {
        _health.TakeDamage();
    }
}