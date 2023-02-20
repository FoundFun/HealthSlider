using UnityEngine;
using UnityEngine.UI;

public class ButtonHealth : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _healthButton;

    private void OnEnable()
    {
        _healthButton.onClick.AddListener(OnHeal);
    }

    private void OnDisable()
    {
        _healthButton.onClick.RemoveListener(OnHeal);
    }

    private void OnHeal()
    {
        _health.TakeHealth();
    }
}
