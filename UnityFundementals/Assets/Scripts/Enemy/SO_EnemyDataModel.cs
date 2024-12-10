using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData", order = 1)]
public class SO_EnemyDataModel : ScriptableObject{
   [SerializeField] float enemyHealth;
   [SerializeField] Color enemyColor;


   public Color GetEnemyColor(){
      return enemyColor;
   }
}
