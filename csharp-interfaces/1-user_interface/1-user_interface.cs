using System;

abstract class Base
{
	public string name { get; set; }

	public override string ToString()
	{
		if (name == null)
		{
			return "is a " + GetType().Name;
		}
		else
		{
			return name + " is a " + GetType().Name;
		}

	}
}

interface IInteractive
{
	void Interact();
}

interface IBreakable
{
	int durability { get; set; }
	void Break();
}

interface ICollectable
{
	bool isCollected { get; set; }
	void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	public void Interact()
	{
		// Interact Implemnetation 
	}

	public int durability { get; set; }

	public void Break()
	{
		// Break Implementation 
	}

	public bool isCollected { get; set; }

	public void Collect()
	{
		// Collect Implementation
	}
}
