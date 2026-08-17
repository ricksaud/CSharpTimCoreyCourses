namespace MiniProjectInheritance
{
    internal partial class Program
    {
        public interface IRentable : IInventoryItem

        {

            void Rent();
            void ReturnRenatl();

        }
    }
}
