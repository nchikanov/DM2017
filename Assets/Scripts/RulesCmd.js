#pragma strict

//private var csScript : PlayerController;

var Button: Sprite; 
var Button_Down: Sprite;  
var script;
var cs;

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
	//script.reStart(); 
	Application.LoadLevel(1); 
} 
