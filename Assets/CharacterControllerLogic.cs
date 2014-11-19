

using UnityEngine;
using System.Collections;

public class CharacterControllerLogic : MonoBehaviour 
{
	#region Variables (private)
	

	[SerializeField]
	private Animator animator;
	[SerializeField]
	private float directionDampTime = 0.25f;

	private float speed = 0f;
	private float h = 0.0f;
	private float v = 0.0f;

	#endregion

	#region Properties (public)

	#endregion

	#region Unity event functions

	/// <summary>
	/// Use this for initialization.
	/// </summary>
	void Start() 
	{
		animator = GetComponent<Animator>();
		
		if(animator.layerCount >= 2)
		{
			animator.SetLayerWeight(1, 1);
		}		
	}
	
	/// <summary>
	/// Update is called once per frame.
	/// </summary>
	void Update() 
	{
		if (animator)
		{
			h = Input.GetAxis ("Horizontal");
			v = Input.GetAxis ("Vertical");
			
			speed = new Vector2(h, v).sqrMagnitude;

			Animator.SetFloat("Speed", speed);
			Animator.SetFloat("Direction", h, directionDampTime, Time.deltaTime);

				
		} 
	}

	/// <summary>
	/// Debugging information should be put here.
	/// </summary>
	void OnDrawGizmos()
	{	
		
	}
	#endregion
	#region methods

	#endregion Methods
}	
	
	