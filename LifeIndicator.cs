using UnityEngine;

public class LifeIndicator : MonoBehaviour
{
    [SerializeField] private HeartController[] _heartControllers;
    private int _currentHealth;
    private void Awake()
    {
        _currentHealth = _heartControllers.Length * 4;
    }
    public void RemoveHealth()
    {
        _currentHealth--;

        for (int i = _heartControllers.Length - 1; i > -1; i--)
        {
            if (_currentHealth < (i + 1) * 4 && _currentHealth >= i * 4)
            {
                _heartControllers[i].RemoveHealth();
                break;
            }
        }
    }
    public void AddHealth()
    {
        _currentHealth++;

        for (int i = 0; i < _heartControllers.Length; i++)
        {
            if (_currentHealth <= (i + 1) * 4 && _currentHealth > i * 4)
            {
                _heartControllers[i].AddHealth();
                break;
            }
        }
    }
}
