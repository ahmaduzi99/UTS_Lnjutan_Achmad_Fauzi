namespace UTS_Lnjutan_Achmad_Fauzi.Models
{
    public class buku
    {
        public string genre { get; set; }
        public string judul { get; set; }

        public buku(string genre1, string kategori)
        {
            genre = genre1;
            judul = kategori;
        }
    }
}
