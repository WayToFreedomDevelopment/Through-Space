using UnityEngine;

public class enemyControllerScript : MonoBehaviour
{
    public Transform plr;

    public float inDistance;
    public float outDistance;
    public float speed;
    public float damage;

    [SerializeField] private float dist;

    private void Update()
    {
        dist = Vector2.Distance(transform.position, plr.position);

        if (dist < outDistance && dist > inDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, plr.position, speed * Time.deltaTime);
        }
        else if (dist < inDistance)
        {
            plr.GetComponent<PlayerControllerScript>().health -= damage;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(this.GetComponent<BoxCollider>().bounds.center, outDistance);
        Gizmos.DrawWireSphere(this.GetComponent<BoxCollider>().bounds.center, inDistance);
    }
}