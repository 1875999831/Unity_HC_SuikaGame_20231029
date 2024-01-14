using Fungus;
using System.Collections;
using System.Collections.Generic;
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
                Instantiate(prefabSlimes[_index], _point, Quaternion.identity);
            } 
            
        }

    }


} 
