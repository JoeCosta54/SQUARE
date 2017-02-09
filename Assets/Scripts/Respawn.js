var X = 2;
var Y = 5;
var Z = 0;
var DeathZoneY = -10;
var BadThing = GameObject;

function Update()
{


if(transform.position.y <= DeathZoneY)
	

	{

transform.position.x = X;
transform.position.y = Y;
transform.position.z = Z;
	}
}