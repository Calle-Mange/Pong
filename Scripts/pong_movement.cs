using Godot;
using System;

public partial class pong_movement : CharacterBody2D
{
	public const float Speed = 300.0f;

	protected Vector2 Direction;

    public override void _Ready()
    {
		StartMovement();
    }

    public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		if (GetLastSlideCollision() != null)
		{
			Direction = Direction.Bounce(GetLastSlideCollision().GetNormal()).Normalized();
		}

        velocity = Direction * Speed;

        Velocity = velocity;

        MoveAndSlide();
	}

	public void StartMovement()
	{
		//Randomizes which direction the pong should begin moving towards, and sends it in that direction.
		Random random = new Random();
		RandomNumberGenerator rng = new RandomNumberGenerator();

		int dirX = random.Next(2);
		int dirY = rng.RandiRange(-10, 10);

        if (dirY == 0)
        {
            dirY = rng.RandiRange(-10, -1);
        }

        if (dirX == 0 )
		{
			Direction = new Vector2(1, dirY);
		}
		else
		{
			Direction = new Vector2(-1, dirY);
		}
	}

	public void ChangeDirection()
	{
		
	}
}
