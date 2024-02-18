
using UnityEngine;
using System.Collections;
/// <summary>
/// 管理器
/// </summary>
namespace KID
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField, Header("结束画面")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("原住民")]
        private ControlSystem controlSystem;
        [SerializeField, Header("生成系統")]
        private SpawnSystem spawnSystem;
        [SerializeField, Header("游戏结束音效")]
        private AudioClip soundGameover;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            print($"<color=#f69>碰到的物件：{collision.name}<color>");
            if (collision.tag == "Droped") StartCoroutine(FadeIn());
        }
        
        private IEnumerator FadeIn()
        {
            SoundManager.instance.PlaySound(soundGameover);
            controlSystem.enabled = false;//关闭人物控制
            spawnSystem.enabled = false;//关闭生成系统
            for (int i = 0; i < 10; i++) 
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.05f);
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;
            }
        }

        /* private void Awake()
         {
             StartCoroutine(Test());
             for(int i=0; i<10; i++)
             {
                 print("1");
             }
         }
         private IEnumerator Test()
         { 
             print("1");
             yield return new WaitForSeconds(1);
             print("2");
             }*/

    }

}
