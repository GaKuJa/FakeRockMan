using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManagement : MonoBehaviour
{
    public static HPManagement Instance { get => _instance; }
    static HPManagement _instance;
    void Awake()
    {
        _instance = this;
    }
    public void PlayerDamage(int Damage) //ダメージ
    {
        Player.Instance.PlayerHP -= Damage;
    }
    public int PlayerAtk(int EnemyHP)　//プレイヤーダメージ
    {
        EnemyHP -= 2;
        return EnemyHP;
    }

}
