
using UnityEngine;
namespace KID
{
    /// <summary>
    /// 音效管理器
    /// </summary>
    [DefaultExecutionOrder(0)]
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager instance;

        //播放声音元件
        private AudioSource aud;

        private void Awake()
        {
            instance = this;
            //声音元件=取得此物件上的audiosourse
            aud = GetComponent<AudioSource>();

        }
        //audioclip音效档案
        /// <summary>
        /// 播音效
        /// </summary>
        /// <param name="sound"></param>
        public void PlaySound(AudioClip sound)
        {
            //音效元件.播放一次音效（音效）
            aud.PlayOneShot(sound);
        }
    }

}
