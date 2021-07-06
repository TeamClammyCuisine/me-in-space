using Character.Movement;

namespace Character
{
    public interface ICharacter
    {
        IMovementController MovementController { get; }
        CharacterAttributes CharacterAttributes { get; }
    }
}