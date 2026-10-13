namespace Labs.Tasks
{
    public abstract class BaseTask
    {
        public abstract int Number { get; }
        public abstract string Description { get; }
        public abstract void Execute();
    }
}
