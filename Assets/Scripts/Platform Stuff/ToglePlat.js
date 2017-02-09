#pragma strict

private var Floating : CreateObject;
private var Falling : CrushingObject;


function Start ()
{
   Floating = GetComponent(CreateObject);
   Falling = GetComponent(CrushingObject);
}


function Update ()
{
    if(Input.GetKeyDown(KeyCode.Q))
    {
        Floating.enabled = !Floating.enabled;
        Falling.enabled = !Falling.enabled;
    }
}