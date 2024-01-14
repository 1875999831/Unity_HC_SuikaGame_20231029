using Fungus;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
namespace KID
{
    [DefaultExecutionOrder(0)]
    public class MergeSystem : MonoBehaviour
    {
        [Header("AllprefabSlime")]
        public GameObject[] prefabSlimes;

        public static MergeSystem instance;

        private bool canMerge = true;

        private void Awake()
        {
            instance = this;
        }
        
        public void Merge(int _index,Vector2 _point)
        {
            if (canMerge)
            {
                canMerge = false;
                print("<color=#99f>Merge</color>");
                GameObject TempSlimes = Instantiate(prefabSlimes[_index], _point, Quaternion.identity);
                //启动碰撞
                TempSlimes.GetComponent<Collider2D>().enabled = true;

                //生成史莱姆恢复刚体
                TempSlimes.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                //生成史莱姆重力回1
                TempSlimes.GetComponent<Rigidbody2D>().gravityScale = 1;

                //延迟呼叫方法（名称， 时间）
                Invoke("CanMerge", 0.01f);

                ScoreManager.instance.ADDScore(_index);
            }
           

        }
        /// <summary>
        /// recover merge
        /// </summary>
        private void CanMerge()
        {
            canMerge = true;
        }
    }


} 
