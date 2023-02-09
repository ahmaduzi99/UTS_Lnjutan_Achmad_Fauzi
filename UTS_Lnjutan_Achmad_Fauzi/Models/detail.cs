namespace UTS_Lnjutan_Achmad_Fauzi.Models
{
    public class detail
    {
        public int jumKomik { get; set; }
        public int jumNovel { get; set; }
        public int jumSejarah { get; set; }

        public int DetailTotal
        {
            get
            {
                return (jumKomik + jumNovel + jumSejarah);
            }
            set
            {
                DetailTotal = value;
            }
        }
    }
}
