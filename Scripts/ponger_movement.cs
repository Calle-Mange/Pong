using Godot;
using System;

public partial class ponger_movement : CharacterBody2D
{
	public const float Speed = 150.0f;
	public bool PlayerOne = true;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		if (PlayerOne)
		{
            if (Input.IsActionPressed("player_one_up"))
            {
                velocity.Y = -1 * Speed;
            }
            else if (Input.IsActionPressed("player_one_down"))
            {
                velocity.Y = 1 * Speed;
            }
            else
            {
                velocity = Vector2.Zero;
            }
        }
        else
        {
            if (Input.IsActionPressed("player_two_up"))
            {
                velocity.Y = -1 * Speed;
            }
            else if (Input.IsActionPressed("player_two_down"))
            {
                velocity.Y = 1 * Speed;
            }
            else
            {
                velocity = Vector2.Zero;
            }
        }

		Velocity = velocity;
		MoveAndSlide();
	}
}
