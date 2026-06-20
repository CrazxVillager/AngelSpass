using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable Objects/PlayerData")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private float playerSpeed;
    public float PlayerSpeed => playerSpeed;
    
    [SerializeField] private float playerSprintSpeed;
    public float PlayerSprintSpeed => playerSprintSpeed;
}
