using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KID
{
    public class SlimeSystem : MonoBehaviour
    {
        [Header("Slimenumber"), Range(0, 7)]
        public int index;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name==gameObject.name)
            {
                MergeSystem.instance.Merge(index+1);
                Destroy(gameObject);
               
            }
        }
    }

}
