using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject[] _skins;
    [SerializeField] private float _speed;
    [SerializeField] private AudioClip _deathSound;
    private Animator _animator;
    private GameObject _currentSkin;
    private bool isDead;
    private PoolSystem<Enemy> _poolSystem;

    public void SetPool(PoolSystem<Enemy> poolSystem) => _poolSystem = poolSystem;
    private void OnEnable()
    {
        OnEnabledSetup();
    }

    private void OnEnabledSetup()
    {
        int randomSkin = Random.Range(0, _skins.Length);

        _currentSkin = _skins[randomSkin];
        _animator = _currentSkin.GetComponent<Animator>();

        _skins[randomSkin].SetActive(true);
        isDead = false;
        _animator.Play("Run");
    }

    private void OnDisable() => _currentSkin.SetActive(false);

    private void Update()
    {
        if (isDead) return;

        transform.Translate(Vector2.right * _speed * Time.deltaTime);
    }

    public void Die()
    {
        if (isDead) return;

        AudioMixerSingleton.GetInstance().Play(_deathSound);
        _animator.Play("Dead");
        isDead = true;
        Invoke(nameof(Disable), 2f);
    }

    private void Disable() => _poolSystem.Return(this);
}
