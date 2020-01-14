using UnityEngine;

public class FBPlayerSoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip hitSound=null, jumpSound=null, scoreSound=null;

    private AudioSource hitSource, jumpSource, scoreSource;

    private void Awake()
    {
        hitSource = gameObject.AddComponent<AudioSource>() as AudioSource;
        hitSource.clip = hitSound;
        jumpSource = gameObject.AddComponent<AudioSource>() as AudioSource;
        jumpSource.clip = jumpSound;
        scoreSource = gameObject.AddComponent<AudioSource>() as AudioSource;
        scoreSource.clip = scoreSound;
    }

    private void Play(AudioSource source)
    {
        source.Play();
    }

    public void Hit()
    {
        Play(hitSource);
    }

    public void Jump()
    {
        Play(jumpSource);
    }

    public void Score()
    {
        Play(scoreSource);
    }
}
