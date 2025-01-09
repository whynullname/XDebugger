namespace WhyNullName
{
    public interface IDebugCategory
    {
        public abstract string CategoryName { get; }
        public abstract void Show(DebugUtils utils);
        public abstract void Hide();
    }
}