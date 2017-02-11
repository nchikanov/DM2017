#pragma strict

var Button: Sprite; 
var Button_Down: Sprite;  

function OnMouseEnter()
{
	GetComponent(SpriteRenderer).sprite = Button_Down; 
} 

function OnMouseExit()
{
	GetComponent(SpriteRenderer).sprite = Button; 
} 

function OnMouseDown()
{
	//sorry u ded
	Application.LoadLevel(4); // right now, try again (load level) 
} 
