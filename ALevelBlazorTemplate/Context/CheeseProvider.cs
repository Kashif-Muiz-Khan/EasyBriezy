namespace MyCheeseShop.Context
{
    public class CheeseProvider
    {
        private readonly DatabaseContext _context;

        public CheeseProvider(DatabaseContext context)
        {
            _context = context;
        }
    }
}
