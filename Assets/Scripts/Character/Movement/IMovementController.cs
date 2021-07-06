namespace Character.Movement
{
    public interface IMovementController
    {
        float MovementSpeed { get; }
        void Move();
    }
}