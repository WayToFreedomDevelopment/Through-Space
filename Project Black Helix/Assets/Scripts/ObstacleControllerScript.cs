using UnityEngine;

public class ObstacleControllerScript : MonoBehaviour
{
    public PlayerControllerScript scr;

    public float damage;

    private void Update()
    {
        Debug.Log("Collided");
    }
}
