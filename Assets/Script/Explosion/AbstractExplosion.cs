using UnityEngine;
abstract  public class AbstractExplosion : MonoBehaviour
{
    [SerializeField] private ScoreInfo _score;
    [SerializeField] private float _power;
    [SerializeField] private float _radiys;
    private Audio _audio;

    protected ScoreInfo Score { get => _score; }
    protected float Power { get => _power; }
    protected float Radiys { get => _radiys; }
    protected Audio Audio { get => _audio; }

    private void Awake()
    {
        if (GetComponentInChildren<Audio>())
        {
            _audio = GetComponentInChildren<Audio>();
        }
    }

    protected abstract void Boom(GameObject Enemy);

    protected abstract void PostBoom(GameObject Enemy);
}