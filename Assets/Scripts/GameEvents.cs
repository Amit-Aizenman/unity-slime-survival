using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static Action<int> OnEnemyHit;
    public static Action<int> waveStarted;
    public static Action<Boolean> characterDead;
}
