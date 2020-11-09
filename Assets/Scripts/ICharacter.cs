public interface ICharacter
{
    IMovementController MovementController { get; }
    ICharacterAttributes CharacterAttributes { get; }
}