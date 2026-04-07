using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [SerializeField] private AudioClip flysound;
    [SerializeField] private AudioClip hitSound;
    [SerializeField] private AudioClip score;
    [SerializeField] private AudioClip die;
    
    private AudioSource audioSource;
    
    private void Awake()
    {
        Instance = this;
        
        audioSource = GetComponent<AudioSource>();
    }
   
    public void PlayFlyingSound() => audioSource.PlayOneShot(flysound);
    public void PlayHitSound() => audioSource.PlayOneShot(hitSound);
    public void PlayScore() => audioSource.PlayOneShot(score);
    public void PlayDieSound() => audioSource.PlayOneShot(die);
}
