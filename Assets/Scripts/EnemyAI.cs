using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    [SerializeField] Transform target = null;
    [SerializeField] float chaseRange = 10f;

    NavMeshAgent navMeshAgent = null;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        ChaseTarget();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    private void ChaseTarget()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (isProvoked || distanceToTarget <= chaseRange)
        {
            navMeshAgent.SetDestination(target.position);
        }
        if (distanceToTarget < navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    }

    private void AttackTarget()
    {
        print("Attacking target!");
    }
}
