using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Entity : MonoBehaviour
{
    #region Variables
    public FiniteStateMachine stateMachine;

    public D_Entity entityData;
    public Rigidbody2D rb { get; private set; }
    public Animator anim { get; private set; }
    public SpriteRenderer sp { get; private set; }
    public GameObject aliveGO { get; private set; }
    public GameObject[] brokenGOs { get; private set; }
    public AnimationToStatemachine atsm { get; private set; }
    public Vector2 originalPosition { get; private set; }
    public NavMeshAgent nav { get; private set; }
    public Transform target { get; private set; }
    public Material originalMaterial { get; private set; }

    //Where the actual health of the enemy will be stored
    public int health { get; private set; }

    //The last damage the entity recibed
    public int damageRecibed { get; private set; }
    
    //The speed the last attack have
    public int speedFromAttack { get; private set; }
    #endregion

    #region Unity Functions
    public virtual void Start()
    {
        aliveGO = transform.Find("Alive").gameObject;
        brokenGOs = new GameObject[this.transform.childCount];
        for (int i = 1; i < this.transform.childCount; i++)
        {
            brokenGOs[i - 1] = this.transform.GetChild(i).gameObject;
        }
        target = GameObject.FindGameObjectWithTag(entityData.targetTag).transform;
        rb = aliveGO.GetComponent<Rigidbody2D>();
        anim = aliveGO.GetComponent<Animator>();
        atsm = aliveGO.GetComponent<AnimationToStatemachine>();
        nav = aliveGO.GetComponent<NavMeshAgent>();
        sp = aliveGO.GetComponent<SpriteRenderer>();
        nav.updateRotation = false;
        nav.updateUpAxis = false;
        originalPosition = aliveGO.transform.position;
        originalMaterial = sp.material;
        health = entityData.maxHealth;

        stateMachine = new FiniteStateMachine();
    }

    public virtual void Update()
    {
        stateMachine.currentState.LogicUpdate();
    }
    public virtual void FixedUpdate()
    {
        stateMachine.currentState.PhysicsUpdate();
    }
    #endregion

    #region Check Functions
    public virtual bool CheckMinAggro()
    {
        return Vector2.Distance(aliveGO.transform.position, target.position) <= entityData.minAggroRange;
    }

    public virtual bool CheckMaxAggro()
    {
        return Vector2.Distance(aliveGO.transform.position, target.position) <= entityData.maxAggroRange;
    }

    public virtual bool CheckPlayerInCloseRangeAction()
    {
        return Vector2.Distance(aliveGO.transform.position, target.position) <= entityData.closeRangeActionDistance;
    }
    //This function can be used to detect if the target in view of the entity and if inside the range you give it
    public virtual bool CheckSeeTarget()
    {
        //This will the variable we later will return
        bool result = false;

        // First we prepare the settings of the ray
        Vector3 start = transform.position;
        Vector3 direction = (aliveGO.transform.position - start).normalized;

        // We draw the ray in the editor for debug testing
        Debug.DrawRay(start, direction * entityData.maxAggroRange, Color.red);

        // Do the ray test
        RaycastHit2D[] sightTestResults = Physics2D.RaycastAll(start, direction, entityData.maxAggroRange);
        
        //We now search in all the results to see what happened
        for (int i = 0; i < sightTestResults.Length; i++)
        {
            if (sightTestResults[i].collider.tag == entityData.targetTag)
            if (sightTestResults[i].collider.tag == entityData.targetTag)
            if (sightTestResults[i].collider.tag == entityData.targetTag)
            {
                result = true;
                break;
            }else if(sightTestResults[i].collider.tag == "Obstacle")
            {
                break;
            }
        }
        return result;
    }
    #endregion

    #region Set Functions
    public void SetHealth(int health)
    {
        this.health = health;
    }

    public void SetMaterial(Material material)
    {
        sp.material = material;
    }
    public void ResetMaterial()
    {
        sp.material = originalMaterial;
    }
    #endregion

    #region Other Functions
    public virtual void Flip()
    {
        aliveGO.transform.Rotate(0f, 180f, 0f);
    }

    public virtual void Damage(int[] attackinf)
    {
        this.damageRecibed = attackinf[0];
        this.speedFromAttack = attackinf[1];
    }
    #endregion
}