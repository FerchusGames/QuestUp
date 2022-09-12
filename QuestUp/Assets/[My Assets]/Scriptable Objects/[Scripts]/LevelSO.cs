using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "ScriptableObjects/LevelSO")]
public class LevelSO : ScriptableObject
{
    [field: SerializeField] public float LevelDuration { get; private set; }
}