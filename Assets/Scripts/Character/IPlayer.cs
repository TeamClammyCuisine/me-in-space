namespace Character
{
    public interface IPlayer : ICharacter
    {
        ICharacter PowerUp { get; }
    }
}
