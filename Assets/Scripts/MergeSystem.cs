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
        private void Awake()
        {
            instance = this;
        }
        public void Merge(int _index)
        {
            print("<color=#99f>Merge</color>");
            Instantiate(prefabSlimes[_index], Vector3.zero, Quaternion.identity);
        }

    }


} 
