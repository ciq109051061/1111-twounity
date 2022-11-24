using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 音效管理器
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;
        private AudioSource audio;
        private void Awake()
        {
            instance = this;
            audio= GetComponent<AudioSource>();
        }
        public void PlaySound(AudioClip sound, Vector2 rangeVolume)
        {
            float volume = Random.Range(rangeVolume.x, rangeVolume.y);
            audio.PlayOneShot(sound, volume);
        }
    }
}
