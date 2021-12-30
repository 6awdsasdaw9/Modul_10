using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class Audio : MonoBehaviour
{
	[SerializeField] private AudioClip[] _sounds;
	private AudioSource _audioSource;
	private int _indexSound;

    private void Awake()
    {
		
			_audioSource = GetComponent<AudioSource>();
		


	}
    public void PlaySound()
	{
		if (_sounds.Length == 0) return;

		else
		{
			print("Audio/PlaySound");
			_indexSound = Random.Range(0, _sounds.Length);
			_audioSource.clip = _sounds[_indexSound];
			_audioSource.volume += Random.Range(-0.1f, 0.1f);
			_audioSource.pitch += Random.Range(-0.1f, 0.1f);
			_audioSource.Play();
		}
	}
}


