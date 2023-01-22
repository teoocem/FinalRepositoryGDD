

namespace Assets
{
    class Collection
    {
        private Collection() { }
        public static Collection reference;

        public int sum_count = 0;

        public int current_count = 0;
        public static Collection getCollection()
        {
            if(reference == null)
            {
                reference = new Collection();
            }

            return reference;
        }
    }
}
