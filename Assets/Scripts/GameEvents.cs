using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static Action<int> OnEnemyHit;
    public static Action<int> WaveStarted;
    public static Action<Boolean> CharacterDead;
}
