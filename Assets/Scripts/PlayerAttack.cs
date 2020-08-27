using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class PlayerAttack : MonoBehaviour
{

    public Animator animator;
    public Transform AttackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    [SerializeField] public int atkDamage = -1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Attack();
        }
    }

    void Attack()
    {
        //Animation
        animator.SetTrigger("attack");
        //Detect Enemies
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRange, enemyLayers);
        //Damage
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<HealthSystemAttribute>().ModifyHealth(atkDamage);
            Debug.Log("We hit " + enemy.name);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
        {
            return;
        }

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(AttackPoint.position, attackRange);
    }
}
