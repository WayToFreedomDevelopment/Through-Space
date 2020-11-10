using UnityEngine;

public class lightSaverCOntrollerScript : MonoBehaviour
{
    public LayerMask layer;
    public BoxCollider col;
    public Animator anim;

    public float radius;
    public float damage;

    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(col.bounds.center, radius, layer);

        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetBool("hit", true);
        }
        else
        {
            anim.SetBool("hit", false);
        }

        foreach (Collider i in colliders)
        {
            enemyControllerScript enemy = i.GetComponent<enemyControllerScript>();

            if(Input.GetKeyDown(KeyCode.Q))
            {
                giveDamage(enemy);
            }
        }
    }

    private void giveDamage(enemyControllerScript enemy)
    {
        enemy.health -= damage;
        Debug.Log("Gave Damage");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(col.bounds.center, radius);
    }
}
