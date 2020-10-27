using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFOllowScript : MonoBehaviour
{
    public Transform plr;

    private void Update()
    {
        transform.position = new Vector3(plr.position.x, transform.position.y, transform.position.z);
    }
}
