namespace WhyNullName
{
    public interface IDebugCategory
    {
        public abstract string CategoryName { get; }
        public abstract void Show(); // Это все будет вызываться где то у меня, значит в Show я могу передавать все зависимости которые нужны, к примеру Utils и всякое такое
        public abstract void Hide();
    }
}