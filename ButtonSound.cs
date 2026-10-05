using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clickSound;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    public void PlayClick()
    {
        audioSource.PlayOneShot(clickSound);
    }

    public void PlayCorrect()
    {
        audioSource.PlayOneShot(correctSound);
    }

    public void PlayWrong()
    {
        audioSource.PlayOneShot(wrongSound);
    }

    public void PlayVoice(AudioClip voiceClip)
    {
        audioSource.Stop();
        audioSource.clip = voiceClip;
        audioSource.Play();
    }
}