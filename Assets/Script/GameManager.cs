using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerBall _player;

 
    [SerializeField] private Transform _pointStart;

    private void Start()
    {

        _player.transform.position = _pointStart.position;
        _player.transform.rotation = _pointStart.rotation;
    }
}
