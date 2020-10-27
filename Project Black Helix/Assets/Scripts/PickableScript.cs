using UnityEngine;

public class PickableScript : MonoBehaviour
{
    public float benifit;
    public float radius;
    public LayerMask layer;
    public PlayerControllerScript scr;
    public bool isNear;

    private void Update()
    {
        Collider[] coll = Physics.OverlapSphere(this.GetComponent<BoxCollider>().bounds.center, radius, layer);

        foreach(Collider i in coll)
        {
            if(i.gameObject.tag == "Player")
            {
                isNear = true;
            }
            else
            {
                isNear  = false;
            }
        }

        if(isNear == true && Input.GetKeyDown(KeyCode.E))
        {
            scr.health += benifit;
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(this.GetComponent<BoxCollider>().bounds.center, radius);
    }
}