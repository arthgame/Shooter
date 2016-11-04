using UnityEngine;
using System.Collections;

public interface IMovement {

	Vector2 Direction{ set; get;}

	bool IsMoving{ get;}

	float CurrentVelocity{ get;}

	float Speed{ set; get;}
}
