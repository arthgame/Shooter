using UnityEngine;
using System.Collections;

public interface IMovement {

	/*
	 * W klasach implementujacych ten interfejs nie uzywamy klasy Input.
	 * Wszystkie input'y pobieramy w osobnym skrypcie.s
	 */

	Vector2 Direction{ set; get;}

    float Rotation { set; get; }

	bool IsMoving{ get;}

	float CurrentVelocity{ get;}

	float Speed{ set; get;}
}
