using Godot;

/// <summary>
/// Storing static references to input string names
/// </summary>
public static class InputNames{
    public static StringName Up {get; } = new StringName("Up");
    public static StringName Down {get; } = new StringName("Down");
    public static StringName Left {get; } = new StringName("Left");
    public static StringName Right {get; } = new StringName("Right");
    public static StringName Jump {get; } = new StringName("Jump");
    public static StringName Attack {get; } = new StringName("Attack");
    public static StringName Interact {get; } = new StringName("Interact");
    public static StringName Pause {get; } = new StringName("Pause");
}