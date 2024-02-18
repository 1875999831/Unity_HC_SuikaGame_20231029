
using UnityEngine;


namespace KID
{
    public class SlimeSystem : MonoBehaviour
    {
        [Header("Slimenumber"), Range(0, 7)]
        

        public int index;

        private void Awake()
        {
            /*Vector2 a = new Vector2(1, 1);
            Vector2 b = new Vector2(100, 100);

            print(Vector2.Lerp(a, b, 0.5f));*/
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //给史莱姆贴标签
            tag = "Droped";
            if (index == 7) return;
            if (collision.gameObject.name == gameObject.name)
            {
                //物件坐标
                Vector2 pointA=transform.position;
                //碰撞坐标
                Vector2 pointB=collision.transform.position;
                //计算坐标
                Vector2 result = Vector2.Lerp(pointA, pointB, 0.5f);

                MergeSystem.instance.Merge(index + 1, result);
                Destroy(gameObject);

            }
        }
    }
}

    


