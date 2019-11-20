﻿namespace CommandPattern
{
  public class GarageDoorCloseCommand : ICommand
  {
    private readonly GarageDoor _garageDoor;

    public GarageDoorCloseCommand(GarageDoor garageDoor)
    {
      this._garageDoor = garageDoor;
    }

    public void Execute()
    {
      _garageDoor.Down();
    }

    public void Undo()
    {
      _garageDoor.Up();
    }
  }
}