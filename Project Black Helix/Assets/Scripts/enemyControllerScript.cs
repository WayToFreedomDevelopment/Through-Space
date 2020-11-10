using UnityEngine;

public class enemyControllerScript : MonoBehaviour
{
    public Transform plr;
    public PlayerControllerScript scr;

    public float inDistance;
    public float outDistance;
    public float speed;
    public float damage;
    public float delay;
    public float health = 100f;

    [SerializeField] private float dist;

    private void Update()
    {
        dist = Vector2.Distance(transform.position, plr.position);

        if (dist < outDistance && dist > inDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, plr.position, speed * Time.deltaTime);
        }
        else if (dist < inDistance && delay <= 0)
        {
            scr.health -= damage;
            delay = 5;
        }
        else if (dist < inDistance && delay != 0 && delay > 0)
        {
            delay -= Time.deltaTime;
        }

        if(health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Killed!");
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(this.GetComponent<BoxCollider>().bounds.center, outDistance);
        Gizmos.DrawWireSphere(this.GetComponent<BoxCollider>().bounds.center, inDistance);
    }
}