using UnityEngine;

public class Lose_Zone : MonoBehaviour
{
    [SerializeField] private ScoreInfo _score; 
    void OnTriggerStay()
    {
        if (_score.GetCount != 0) _score.ResetCount();
    }
}
