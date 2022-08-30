using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "ScriptableObjects/LevelSO")]
public class LevelSO : ScriptableObject
{
    [field: SerializeField] public float levelDuration { get; private set; }
}