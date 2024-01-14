using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
namespace KID
{
    [DefaultExecutionOrder(0)]
    public class ScoreManager : MonoBehaviour
    {
        [Header("Score")]
        public TextMeshProUGUI textScore;

        
        [Header("TotalScore")]
        public int[] slimesScore = { 10, 20, 30, 40, 50, 60, 70, 80 };

        private int totalScore;

        public static ScoreManager instance;

        private void Awake()
        {
            instance = this;
        }
        /// <summary>
        /// 加分数
        /// </summary>
        /// <param name="_index">加几号史莱姆</param>
        public void ADDScore(int _index)
        {
            int Score = slimesScore[_index];
            totalScore += Score;
            textScore.text = totalScore.ToString();

        }
        
    }

}
