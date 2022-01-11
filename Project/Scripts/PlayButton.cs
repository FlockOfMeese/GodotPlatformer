using Godot;
using System;

public class PlayButton : Button
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Connect("pressed", this, nameof(OnPlayPressed));
    }

    private void OnPlayPressed()
    {
        GD.Print("Pressed play");
        GetTree().ChangeScene("res://Scenes/Game.tscn");
    }
    
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
