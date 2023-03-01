using UnityEngine;

public class HeartController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private int _heartHealth = 4;
    public void RemoveHealth()
    {
        _heartHealth--;
        switch (_heartHealth)
        {
            case 3:
                _animator.Play("3");
                break;
            case 2:
                _animator.Play("2");
                break;
            case 1:
                _animator.Play("1");
                break;
            case 0:
                _animator.Play("0");
                break;
        }
    }
    public void AddHealth()
    {
        _heartHealth++;
        switch (_heartHealth)
        {
            case 1:
                _animator.Play("1");
                break;
            case 2:
                _animator.Play("2");
                break;
            case 3:
                _animator.Play("3");
                break;
            case 4:
                _animator.Play("4");
                break;
        }
    }
}
