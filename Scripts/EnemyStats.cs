using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/EnemyStats")]
public class EnemyStats : ScriptableObject {

    public float moveSpeed = 1;
    public float lookRange = 40f;
    public float lookShellRange = 40f;
    public float grabShellRange = 40f;
    public float ShootRange = 20f;
    public float lookSphereCastRadius = 1f;
    public float WaveCooldown = 30f;
    public float GullCooldown = 30f;

    public float attackRange = 1f;
    public float attackRate = 1f;
    public float attackForce = 15f;
    public int attackDamage = 50;

    public float searchDuration = 4f;
    public float searchTurnSpeed = 120f;

    public bool clicked = false;
    public int HP = 10;
    public int SumNbr = 4;
    public GameObject SummPrefab;

}
