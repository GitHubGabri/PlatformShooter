using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Entity : MonoBehaviour
{
    #region Variables
    public FiniteStateMachine stateMachine;

    public D_Entity entityData;
    public Rigidbody2D rb { get; private set; }
    public Animator anim { get; private set; }
    public SpriteRenderer sp { get; private set; }
    public GameObject character { get; private set; }
    public AnimationToStatemachine atsm { get; private set; }
    public Vector2 originalPosition { get; private set; }
    public Material originalMaterial { get; private set; }

    public Vector2 movement { get; private set; }

    //Todos los estados
    public MovementState movementState { get; private set; }
    public D_MovementState dataMovementState { get; private set; }
    public IdleState idleState { get; private set; }
    public D_IdleState dataIdleState { get; private set; }
    public AttackState attackState { get; private set; }
    public D_AttackState dataAttackState { get; private set; }
    public DeathState deathState { get; private set; }
    public D_DeathState dataDeathState { get; private set; }
    public HabilidadState habilidadState { get; private set; }
    public D_HabilidadState dataHabilidadState { get; private set; }
    public DashState dashState { get; private set; }
    public D_DashState dataDashState { get; private set; }
    //Where the actual health of the enemy will be stored
    public int health { get; private set; }

    //The last damage the entity recibed
    public int damageRecibed { get; private set; }

    #endregion

    #region Unity Functions
    public virtual void Start()
    {
        character = this.gameObject;
        rb = character.GetComponent<Rigidbody2D>();
        //anim = character.GetComponent<Animator>();
        //atsm = character.GetComponent<AnimationToStatemachine>();
        sp = character.GetComponent<SpriteRenderer>();
        originalPosition = character.transform.position;
        //originalMaterial = sp.material;
        //health = entityData.maxHealth;

        idleState = new IdleState(this, stateMachine, "", dataIdleState);
        movementState = new MovementState(this, stateMachine, " " , dataMovementState);
        deathState = new DeathState(this, stateMachine, "", dataDeathState);
        habilidadState = new HabilidadState(this, stateMachine, "", dataHabilidadState);
        attackState = new AttackState(this, stateMachine, "", dataAttackState);
        dashState = new DashState(this, stateMachine, "", dataDashState);

        stateMachine = new FiniteStateMachine();
        stateMachine.Initialize(idleState);
        Debug.Log(stateMachine.currentState);
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

    #region Input Functions

    public void InMovement(InputAction.CallbackContext context)
    {
    movement = context.ReadValue<Vector2>();
    if (!(movement.x == 0) || !(movement.y == 0)){
        stateMachine.ChangeState(movementState);
    }
    }

    public void InShoot(InputAction.CallbackContext context)
    {
    if (context.started){
        stateMachine.ChangeState(attackState);
    }
    }

    public void InHability(InputAction.CallbackContext context)
    {
    if (context.started){
        stateMachine.ChangeState(habilidadState);
    }
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
        character.transform.Rotate(0f, 180f, 0f);
    }

    public virtual void Damage(int[] attackinf)
    {
        this.damageRecibed = attackinf[0];
    }
    #endregion
}